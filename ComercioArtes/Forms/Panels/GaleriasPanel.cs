using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ComercioArtes.Data;
using ComercioArtes.Forms.Dialogs;
using ComercioArtes.Helpers;
using ComercioArtes.Models;

namespace ComercioArtes.Forms.Panels
{
    public partial class GaleriasPanel : UserControl
    {
        public GaleriasPanel()
        {
            InitializeComponent();
            RefrescarGalerias();
        }

        private void btnNuevaGaleria_Click(object sender, EventArgs e) => AbrirDialogoGaleria(null);

        private void btnEditarGaleria_Click(object sender, EventArgs e) => EditarGaleria();

        private void btnEliminarGaleria_Click(object sender, EventArgs e) => EliminarGaleria();

        private void btnAgregarObra_Click(object sender, EventArgs e) => AgregarObra();

        private void btnQuitarObra_Click(object sender, EventArgs e) => QuitarObra();

        private void gridGalerias_SelectionChanged(object sender, EventArgs e) => RefrescarObras();

        // ── Lógica ───────────────────────────────────────────────
        private void RefrescarGalerias()
        {
            var ds = DataStore.Instancia;
            gridGalerias.Rows.Clear();
            foreach (var g in ds.Galerias)
            {
                int cantObras = ds.GaleriasObras.Count(go => go.IdGaleria == g.Id);
                gridGalerias.Rows.Add(g.Id, g.Nombre, g.Ubicacion, cantObras, g.Telefono);
            }
        }

        private void RefrescarObras()
        {
            gridObrasGaleria.Rows.Clear();
            var galeria = GaleriaSeleccionada();
            if (galeria == null) return;

            lblObrasEnGaleria.Text = $"Obras en: {galeria.Nombre}";
            var ds = DataStore.Instancia;
            foreach (var o in ds.ObrasDeGaleria(galeria.Id))
            {
                var artista = ds.BuscarArtista(o.IdArtista);
                int idx = gridObrasGaleria.Rows.Add(o.Id, o.Titulo, artista?.Nombre ?? "—",
                                                     $"${o.Precio:N2}", o.Estado);
                gridObrasGaleria.Rows[idx].DefaultCellStyle.BackColor =
                    UIHelper.ColorEstadoObra(o.Estado.ToString());
            }
        }

        private Galeria GaleriaSeleccionada()
        {
            if (gridGalerias.CurrentRow == null) return null;
            int id = (int)gridGalerias.CurrentRow.Cells[0].Value;
            return DataStore.Instancia.BuscarGaleria(id);
        }

        private void AbrirDialogoGaleria(Galeria g)
        {
            using (var dlg = new GaleriaDialog(g))
                if (dlg.ShowDialog() == DialogResult.OK) { RefrescarGalerias(); RefrescarObras(); }
        }

        private void EditarGaleria()
        {
            var g = GaleriaSeleccionada();
            if (g != null) AbrirDialogoGaleria(g);
        }

        private void EliminarGaleria()
        {
            var g = GaleriaSeleccionada();
            if (g == null) return;
            if (MessageBox.Show($"¿Eliminar la galería \"{g.Nombre}\"?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var ds = DataStore.Instancia;
                ds.GaleriasObras.RemoveAll(go => go.IdGaleria == g.Id);
                ds.Galerias.Remove(g);
                RefrescarGalerias();
                gridObrasGaleria.Rows.Clear();
                lblObrasEnGaleria.Text = "Obras en la galería";
            }
        }

        private void AgregarObra()
        {
            var galeria = GaleriaSeleccionada();
            if (galeria == null) { MessageBox.Show("Selecciona una galería primero."); return; }

            var ds = DataStore.Instancia;
            var idsYaEnGaleria = ds.GaleriasObras
                .Where(go => go.IdGaleria == galeria.Id)
                .Select(go => go.IdObra)
                .ToList();

            var obrasDispo = ds.Obras.FindAll(o => !idsYaEnGaleria.Contains(o.Id));
            if (obrasDispo.Count == 0)
            {
                MessageBox.Show("Todas las obras ya están en esta galería.", "Sin obras disponibles",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new SeleccionarObraDialog(obrasDispo))
            {
                if (dlg.ShowDialog() == DialogResult.OK && dlg.ObraElegida != null)
                {
                    ds.GaleriasObras.Add(new GaleriaObra(ds.SiguienteIdGaleriaObra(),
                                                          galeria.Id, dlg.ObraElegida.Id));
                    RefrescarGalerias();
                    RefrescarObras();
                }
            }
        }

        private void QuitarObra()
        {
            var galeria = GaleriaSeleccionada();
            if (galeria == null || gridObrasGaleria.CurrentRow == null) return;

            int idObra = (int)gridObrasGaleria.CurrentRow.Cells[0].Value;
            var ds = DataStore.Instancia;
            var relacion = ds.GaleriasObras
                .Find(go => go.IdGaleria == galeria.Id && go.IdObra == idObra);

            if (relacion != null)
            {
                ds.GaleriasObras.Remove(relacion);
                RefrescarGalerias();
                RefrescarObras();
            }
        }
    }
}
