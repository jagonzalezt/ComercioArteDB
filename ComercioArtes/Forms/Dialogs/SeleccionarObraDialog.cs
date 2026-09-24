using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaDatos; // Tu capa donde reside ConexionBD
using ComercioArtes.Models;

namespace ComercioArtes.Forms.Dialogs
{
    public partial class SeleccionarObraDialog : BaseDialog
    {
        // Esta propiedad seguirá devolviendo la obra elegida con su ID real de la BD
        public Obra ObraElegida { get; private set; }

        private ConexionBD conexionBD = new ConexionBD();

        // Mantenemos los constructores para que no te marque error en FacturaDialog
        public SeleccionarObraDialog() : this(null) { }

        public SeleccionarObraDialog(List<Obra> obrasIgnoradas) : base("Seleccionar Obra")
        {
            InitializeComponent();
            CargarObrasDesdeBD();
        }

        // ── CARGAR OBRAS REALES DESDE SQL SERVER ─────────────────────────────────
        private void CargarObrasDesdeBD()
        {
            try
            {
                gridSelObra.Rows.Clear();

                using (SqlConnection con = conexionBD.ObtenerConexion())
                {
                    // Consultamos las obras directamente uniendo el nombre del Artista (Usuario) y la Categoría (Técnica)
                    string query = @"SELECT o.ObraID, o.Titulo, u.Nombre + ' ' + u.Apellido AS Artista, 
                                            c.NombreCategoria AS Tecnica, o.Precio
                                     FROM ObrasArte o
                                     INNER JOIN Usuarios u ON o.ArtistaID = u.UsuarioID
                                     INNER JOIN Categorias c ON o.CategoriaID = c.CategoriaID
                                     WHERE o.Disponible = 1"; // Solo las que no se han vendido

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader leer = cmd.ExecuteReader())
                        {
                            while (leer.Read())
                            {
                                // Agregamos las filas al DataGridView usando los identificadores reales de la BD
                                gridSelObra.Rows.Add(
                                    leer["ObraID"],
                                    leer["Titulo"],
                                    leer["Artista"],
                                    leer["Tecnica"],
                                    string.Format("${0:N2}", leer["Precio"])
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar obras desde la base de datos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── SELECCIONAR Y DEVOLVER LA OBRA REAL ──────────────────────────────────
        private void btnAgregarSel_Click(object sender, EventArgs e)
        {
            if (gridSelObra.CurrentRow == null) return;

            try
            {
                // Recuperamos los valores de la fila seleccionada por el usuario
                int idReal = Convert.ToInt32(gridSelObra.CurrentRow.Cells[0].Value);
                string titulo = gridSelObra.CurrentRow.Cells[1].Value.ToString();

                // Limpiamos el formato de moneda ($1,200.00 -> 1200.00) para evitar fallas de conversión
                string precioTexto = gridSelObra.CurrentRow.Cells[4].Value.ToString()
                                     .Replace("$", "").Replace(",", "").Trim();
                decimal precioReal = Convert.ToDecimal(precioTexto);

                // Instanciamos el objeto Obra con los datos fidedignos de la Base de Datos
                ObraElegida = new Obra
                {
                    Id = idReal,
                    Titulo = titulo,
                    Precio = precioReal
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la selección de la obra: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarSel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}