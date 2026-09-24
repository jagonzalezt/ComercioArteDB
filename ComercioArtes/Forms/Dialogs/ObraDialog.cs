using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;
using ComercioArtes.Models;

namespace ComercioArtes.Forms.Dialogs
{
    public partial class ObraDialog : BaseDialog
    {
        private CN_Obras objetoNegocio = new CN_Obras();
        private CN_Artistas negocioArtistas = new CN_Artistas();
        private readonly int? _obraID;

        // Constructor para Nueva Obra
        public ObraDialog() : this(null) { }

        // CONSTRUCTOR CORREGIDO: Ahora acepta el ID numérico de SQL Server
        public ObraDialog(int? obraID)
            : base(obraID == null ? "Nueva Obra" : "Editar Obra")
        {
            _obraID = obraID;
            InitializeComponent();

            this.Load += new System.EventHandler(this.ObraDialog_Load);
        }

        private void ObraDialog_Load(object sender, EventArgs e)
        {
            // 1. Cargar Enums locales
            foreach (var t in Enum.GetValues(typeof(TecnicaObra)))
                cmbTecnica.Items.Add(t);
            foreach (var eEnum in Enum.GetValues(typeof(EstadoObra)))
                cmbEstadoObra.Items.Add(eEnum);

            if (cmbTecnica.Items.Count > 0) cmbTecnica.SelectedIndex = 0;
            if (cmbEstadoObra.Items.Count > 0) cmbEstadoObra.SelectedIndex = 0;

            numAnio.Maximum = DateTime.Now.Year;
            numAnio.Value = DateTime.Now.Year;

            // 2. Cargar los artistas desde la Base de Datos SQL
            CargarComboArtistas();

            // 3. Ajustar UI y Precargar si es edición
            if (_obraID != null)
            {
                lblSubtitleDlg.Text = "Modificando los datos de la obra seleccionada";
                PreCargar();
            }
            else
            {
                lblSubtitleDlg.Text = "Registra una nueva obra en el catálogo";
            }
        }

        private void CargarComboArtistas()
        {
            try
            {
                DataTable artistas = negocioArtistas.ObtenerArtistas();
                if (artistas != null)
                {
                    cmbArtistaObra.DataSource = artistas;
                    cmbArtistaObra.DisplayMember = "Nombre";
                    cmbArtistaObra.ValueMember = "UsuarioID";
                    cmbArtistaObra.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los artistas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreCargar()
        {
            try
            {
                DataTable obras = objetoNegocio.ObtenerObras();
                if (obras == null) return;

                DataRow[] filas = obras.Select($"ObraID = {_obraID}");

                if (filas.Length > 0)
                {
                    DataRow obra = filas[0];

                    txtTituloObra.Text = obra["Titulo"].ToString();
                    txtDescripcion.Text = obra["Descripcion"].ToString();
                    txtDimensiones.Text = obra["Dimensiones"].ToString();

                    if (obra["Anio"] != DBNull.Value)
                        numAnio.Value = Convert.ToInt32(obra["Anio"]);

                    if (obra["Precio"] != DBNull.Value)
                        numPrecio.Value = Convert.ToDecimal(obra["Precio"]);

                    // CORRECCIÓN LÍNEA 103: Uso de parseo clásico compatible con todas las versiones de .NET
                    string tecnicaStr = obra["Tecnica"].ToString();
                    try
                    {
                        TecnicaObra tecnicaEnum = (TecnicaObra)Enum.Parse(typeof(TecnicaObra), tecnicaStr, true);
                        cmbTecnica.SelectedItem = tecnicaEnum;
                    }
                    catch
                    {
                        if (cmbTecnica.Items.Count > 0) cmbTecnica.SelectedIndex = 0;
                    }

                    // CORRECCIÓN LÍNEA 115: Uso de parseo clásico compatible con todas las versiones de .NET
                    string estadoStr = obra["Estado"].ToString();
                    try
                    {
                        EstadoObra estadoEnum = (EstadoObra)Enum.Parse(typeof(EstadoObra), estadoStr, true);
                        cmbEstadoObra.SelectedItem = estadoEnum;
                    }
                    catch
                    {
                        if (cmbEstadoObra.Items.Count > 0) cmbEstadoObra.SelectedIndex = 0;
                    }

                    if (obra["ArtistaID"] != DBNull.Value)
                    {
                        cmbArtistaObra.SelectedValue = Convert.ToInt32(obra["ArtistaID"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de la obra desde la BD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarObra_Click(object sender, EventArgs e)
        {
            if (!Validar(txtTituloObra)) return;
            if (cmbArtistaObra.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un artista.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idArtista = Convert.ToInt32(cmbArtistaObra.SelectedValue);
                string titulo = txtTituloObra.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                string tecnica = cmbTecnica.SelectedItem.ToString();
                string dimensiones = txtDimensiones.Text.Trim();
                int anio = (int)numAnio.Value;
                decimal precio = numPrecio.Value;
                string estado = cmbEstadoObra.SelectedItem.ToString();
                string imagenUrl = "";

                // CORRECCIÓN DE BASE DE DATOS: Cambiamos el entero fijo '1' por un ID válido de Categoría.
                // Si tienes un ComboBox de categorías usa su SelectedValue, de lo contrario, dejamos 1 
                // asegurando que en tu tabla 'Categorias' de SQL Server exista obligatoriamente un ID numérico 1.
                int idCategoria = 1;

                if (_obraID == null)
                {
                    // OPERACIÓN EN SQL: INSERTAR NUEVA OBRA
                    objetoNegocio.GuardarObra(idArtista, titulo, descripcion, precio, idCategoria, imagenUrl, tecnica, anio.ToString(), dimensiones, estado);
                    MessageBox.Show("Obra registrada con éxito.", "Catálogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // OPERACIÓN EN SQL: ACTUALIZAR OBRA EXISTENTE
                    objetoNegocio.ActualizarObra(_obraID.Value, idArtista, titulo, descripcion, precio, idCategoria, imagenUrl, tecnica, anio.ToString(), dimensiones, estado);
                    MessageBox.Show("Obra actualizada con éxito.", "Catálogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la obra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarObra_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}