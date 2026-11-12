using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;
using ComercioArtes.Data;
using ComercioArtes.Estructuras;
using ComercioArtes.Helpers;
using ComercioArtes.Models;

namespace ComercioArtes.Forms.Panels
{
    // Panel del modulo de estructuras de datos.
    // Tiene tres pestañas:
    //   1. Cola de pedidos pendientes
    //   2. Arbol de categorias (con recursividad)
    //   3. Grafo de artistas, obras y galerias
    // Este panel solo lo ve el Administrador.
    public class EstructurasPanel : UserControl
    {
        // Datos de un pedido que esta en la cola
        private class PedidoCola
        {
            public int Id;
            public string Comprador;
            public DateTime Fecha;
            public decimal Total;
            public string Estado;
        }

        private CN_Transacciones negocioTrans = new CN_Transacciones();
        private CN_Obras negocioObras = new CN_Obras();

        private Cola<PedidoCola> _cola = new Cola<PedidoCola>();
        private Grafo _grafo = new Grafo();

        // Controles de la cola
        private DataGridView gridCola;
        private Label lblFrenteCola;

        // Controles del arbol
        private TreeView treeCategorias;

        // Controles del grafo
        private ComboBox cmbArtistaGrafo;
        private ListBox lstGrafo;

        public EstructurasPanel()
        {
            BackColor = UIHelper.ContentBg;
            Dock = DockStyle.Fill;

            TabControl tabs = new TabControl();
            tabs.Dock = DockStyle.Fill;
            tabs.Font = new Font("Segoe UI", 10F);
            tabs.TabPages.Add(CrearPestañaCola());
            tabs.TabPages.Add(CrearPestañaArbol());
            tabs.TabPages.Add(CrearPestañaGrafo());
            Controls.Add(tabs);

            CargarCola();
            CargarArbol();
            CargarGrafo();
        }

        // ══════════════════════════════════════════════════════════
        //  PESTAÑA 1: COLA DE PEDIDOS
        // ══════════════════════════════════════════════════════════
        private TabPage CrearPestañaCola()
        {
            TabPage pagina = new TabPage("Cola de pedidos");
            pagina.BackColor = UIHelper.ContentBg;

            Label lblInfo = new Label();
            lblInfo.Text = "Los pedidos pendientes se atienden en el orden en que llegaron. El primero de la lista es el siguiente.";
            lblInfo.Font = new Font("Segoe UI", 9.5F);
            lblInfo.ForeColor = UIHelper.TextSecondary;
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(16, 14);
            pagina.Controls.Add(lblInfo);

            Button btnAtender = UIHelper.BotonAccion("Atender siguiente", UIHelper.Verde, 160);
            btnAtender.Location = new Point(16, 46);
            btnAtender.Click += btnAtenderSiguiente_Click;
            pagina.Controls.Add(btnAtender);

            Button btnActualizarCola = UIHelper.BotonAccion("Actualizar", UIHelper.Indigo, 110);
            btnActualizarCola.Location = new Point(186, 46);
            btnActualizarCola.Click += btnActualizarCola_Click;
            pagina.Controls.Add(btnActualizarCola);

            lblFrenteCola = new Label();
            lblFrenteCola.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFrenteCola.ForeColor = UIHelper.TextPrimary;
            lblFrenteCola.AutoSize = true;
            lblFrenteCola.Location = new Point(16, 92);
            pagina.Controls.Add(lblFrenteCola);

            gridCola = new DataGridView();
            gridCola.Location = new Point(16, 122);
            gridCola.Size = new Size(760, 330);
            gridCola.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            gridCola.ReadOnly = true;
            gridCola.AllowUserToAddRows = false;
            gridCola.AllowUserToDeleteRows = false;
            gridCola.RowHeadersVisible = false;
            gridCola.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCola.BackgroundColor = Color.White;
            gridCola.BorderStyle = BorderStyle.None;
            gridCola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCola.Columns.Add("colOrden", "Orden");
            gridCola.Columns.Add("colPedido", "Pedido");
            gridCola.Columns.Add("colFecha", "Fecha");
            gridCola.Columns.Add("colComprador", "Comprador");
            gridCola.Columns.Add("colTotal", "Total");
            gridCola.Columns.Add("colEstado", "Estado");
            UIHelper.EstiloGrid(gridCola);
            pagina.Controls.Add(gridCola);

            return pagina;
        }

        // Lee los pedidos pendientes de la base de datos y los mete en la cola
        private void CargarCola()
        {
            try
            {
                _cola = new Cola<PedidoCola>();
                DataTable tabla = negocioTrans.ObtenerPedidosPendientes();

                // La consulta ya viene ordenada del mas antiguo al mas nuevo
                foreach (DataRow fila in tabla.Rows)
                {
                    PedidoCola pedido = new PedidoCola();
                    pedido.Id = Convert.ToInt32(fila["PedidoID"]);
                    pedido.Comprador = fila["Comprador"].ToString();
                    pedido.Fecha = Convert.ToDateTime(fila["FechaPedido"]);
                    pedido.Total = Convert.ToDecimal(fila["Total"]);
                    pedido.Estado = fila["Estado"].ToString();
                    _cola.Encolar(pedido);
                }
                MostrarCola();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la cola de pedidos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarCola()
        {
            gridCola.Rows.Clear();

            int orden = 1;
            foreach (PedidoCola pedido in _cola.ComoLista())
            {
                gridCola.Rows.Add(orden, pedido.Id, pedido.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    pedido.Comprador, string.Format("${0:N2}", pedido.Total), pedido.Estado);
                orden++;
            }

            if (_cola.EstaVacia())
            {
                lblFrenteCola.Text = "No hay pedidos pendientes.";
            }
            else
            {
                PedidoCola primero = _cola.VerFrente();
                lblFrenteCola.Text = "Siguiente en atender: pedido #" + primero.Id + " de " + primero.Comprador +
                                     "  (" + _cola.Cantidad + " en la cola)";
            }
        }

        private void btnAtenderSiguiente_Click(object sender, EventArgs e)
        {
            if (_cola.EstaVacia())
            {
                MessageBox.Show("No hay pedidos pendientes.", "Cola vacía",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                PedidoCola pedido = _cola.VerFrente();

                // Primero se marca como atendido en la base de datos
                negocioTrans.AtenderPedido(pedido.Id);

                // Despues se saca de la cola
                _cola.Desencolar();
                MostrarCola();

                MessageBox.Show("Pedido #" + pedido.Id + " atendido.", "Pedido atendido",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarCola_Click(object sender, EventArgs e)
        {
            CargarCola();
        }

        // ══════════════════════════════════════════════════════════
        //  PESTAÑA 2: ARBOL DE CATEGORIAS
        // ══════════════════════════════════════════════════════════
        private TabPage CrearPestañaArbol()
        {
            TabPage pagina = new TabPage("Árbol de categorías");
            pagina.BackColor = UIHelper.ContentBg;

            Label lblInfo = new Label();
            lblInfo.Text = "Cada categoría muestra cuántas obras tiene y su valor, sumando también sus subcategorías.";
            lblInfo.Font = new Font("Segoe UI", 9.5F);
            lblInfo.ForeColor = UIHelper.TextSecondary;
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(16, 14);
            pagina.Controls.Add(lblInfo);

            Button btnActualizarArbol = UIHelper.BotonAccion("Actualizar", UIHelper.Indigo, 110);
            btnActualizarArbol.Location = new Point(16, 46);
            btnActualizarArbol.Click += btnActualizarArbol_Click;
            pagina.Controls.Add(btnActualizarArbol);

            treeCategorias = new TreeView();
            treeCategorias.Location = new Point(16, 92);
            treeCategorias.Size = new Size(760, 360);
            treeCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            treeCategorias.Font = new Font("Segoe UI", 10.5F);
            treeCategorias.BorderStyle = BorderStyle.None;
            pagina.Controls.Add(treeCategorias);

            return pagina;
        }

        // Arma el arbol con las obras de la base de datos
        private void CargarArbol()
        {
            try
            {
                ArbolCategorias arbol = ArbolCategorias.CrearPorDefecto();

                DataTable obras = negocioObras.ObtenerObras();
                foreach (DataRow fila in obras.Rows)
                {
                    string categoria = ArbolCategorias.CategoriaDeTecnica(fila["Tecnica"].ToString());
                    decimal precio = Convert.ToDecimal(fila["Precio"]);
                    arbol.AgregarObra(categoria, precio);
                }

                treeCategorias.Nodes.Clear();
                treeCategorias.Nodes.Add(CrearNodoVisual(arbol, arbol.Raiz));
                treeCategorias.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el árbol de categorías: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Convierte un nodo de categoria en un nodo del TreeView (recursivo)
        private TreeNode CrearNodoVisual(ArbolCategorias arbol, NodoCategoria categoria)
        {
            int totalObras = arbol.ContarObras(categoria);
            decimal totalValor = arbol.SumarValor(categoria);

            string texto = categoria.Nombre + "   (" + totalObras + " obras, $" + totalValor.ToString("N2") + ")";
            TreeNode nodoVisual = new TreeNode(texto);

            foreach (NodoCategoria hijo in categoria.Hijos)
            {
                nodoVisual.Nodes.Add(CrearNodoVisual(arbol, hijo));
            }
            return nodoVisual;
        }

        private void btnActualizarArbol_Click(object sender, EventArgs e)
        {
            CargarArbol();
        }

        // ══════════════════════════════════════════════════════════
        //  PESTAÑA 3: GRAFO DE ARTISTAS, OBRAS Y GALERIAS
        // ══════════════════════════════════════════════════════════
        private TabPage CrearPestañaGrafo()
        {
            TabPage pagina = new TabPage("Grafo de galerías");
            pagina.BackColor = UIHelper.ContentBg;

            Label lblInfo = new Label();
            lblInfo.Text = "Elige un artista para ver en qué galerías exhibe sus obras (datos del módulo Galerías).";
            lblInfo.Font = new Font("Segoe UI", 9.5F);
            lblInfo.ForeColor = UIHelper.TextSecondary;
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(16, 14);
            pagina.Controls.Add(lblInfo);

            cmbArtistaGrafo = new ComboBox();
            cmbArtistaGrafo.Location = new Point(16, 48);
            cmbArtistaGrafo.Size = new Size(300, 30);
            cmbArtistaGrafo.Font = new Font("Segoe UI", 10F);
            cmbArtistaGrafo.DropDownStyle = ComboBoxStyle.DropDownList;
            pagina.Controls.Add(cmbArtistaGrafo);

            Button btnVerGalerias = UIHelper.BotonAccion("Ver galerías", UIHelper.Verde, 120);
            btnVerGalerias.Location = new Point(330, 46);
            btnVerGalerias.Click += btnVerGalerias_Click;
            pagina.Controls.Add(btnVerGalerias);

            Button btnActualizarGrafo = UIHelper.BotonAccion("Actualizar", UIHelper.Indigo, 110);
            btnActualizarGrafo.Location = new Point(460, 46);
            btnActualizarGrafo.Click += btnActualizarGrafo_Click;
            pagina.Controls.Add(btnActualizarGrafo);

            lstGrafo = new ListBox();
            lstGrafo.Location = new Point(16, 96);
            lstGrafo.Size = new Size(760, 356);
            lstGrafo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            lstGrafo.Font = new Font("Segoe UI", 10.5F);
            lstGrafo.BorderStyle = BorderStyle.None;
            pagina.Controls.Add(lstGrafo);

            return pagina;
        }

        // Arma el grafo con los artistas, obras y galerias que hay en el DataStore
        private void CargarGrafo()
        {
            DataStore datos = DataStore.Instancia;
            _grafo = new Grafo();

            // Un nodo por cada artista, obra y galeria
            foreach (Artista artista in datos.Artistas)
                _grafo.AgregarNodo("A" + artista.Id, artista.Nombre);

            foreach (Obra obra in datos.Obras)
                _grafo.AgregarNodo("O" + obra.Id, obra.Titulo);

            foreach (Galeria galeria in datos.Galerias)
                _grafo.AgregarNodo("G" + galeria.Id, galeria.Nombre);

            // Una arista une al artista con cada una de sus obras
            foreach (Obra obra in datos.Obras)
                _grafo.AgregarArista("A" + obra.IdArtista, "O" + obra.Id);

            // Otra arista une cada obra con las galerias donde esta
            foreach (GaleriaObra union in datos.GaleriasObras)
                _grafo.AgregarArista("G" + union.IdGaleria, "O" + union.IdObra);

            // Llenamos la lista de artistas
            cmbArtistaGrafo.DataSource = null;
            cmbArtistaGrafo.DataSource = datos.Artistas;
            cmbArtistaGrafo.DisplayMember = "Nombre";
            lstGrafo.Items.Clear();
        }

        private void btnVerGalerias_Click(object sender, EventArgs e)
        {
            Artista artista = cmbArtistaGrafo.SelectedItem as Artista;
            if (artista == null)
            {
                MessageBox.Show("Selecciona un artista.", "Grafo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstGrafo.Items.Clear();
            lstGrafo.Items.Add("Galerías donde exhibe " + artista.Nombre + ":");
            lstGrafo.Items.Add("");

            // Recorrido en anchura desde el artista
            string inicio = "A" + artista.Id;
            Dictionary<string, string> padres = _grafo.RecorrerEnAnchura(inicio);

            int encontradas = 0;
            foreach (string clave in padres.Keys)
            {
                // Solo nos interesan las galerias (claves que empiezan con G)
                if (!clave.StartsWith("G"))
                    continue;

                // Camino: artista -> obra -> galeria (3 nodos) son las galerias directas
                List<string> camino = _grafo.CaminoHasta(padres, clave);
                if (camino.Count != 3)
                    continue;

                string texto = "";
                for (int i = 0; i < camino.Count; i++)
                {
                    texto = texto + _grafo.NombreDe(camino[i]);
                    if (i < camino.Count - 1)
                        texto = texto + "  →  ";
                }
                lstGrafo.Items.Add(texto);
                encontradas++;
            }

            if (encontradas == 0)
                lstGrafo.Items.Add("Este artista todavía no exhibe obras en ninguna galería.");
        }

        private void btnActualizarGrafo_Click(object sender, EventArgs e)
        {
            CargarGrafo();
        }
    }
}
