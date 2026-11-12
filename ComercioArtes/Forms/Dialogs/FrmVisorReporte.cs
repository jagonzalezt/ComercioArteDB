using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ComercioArtes.Helpers;

namespace ComercioArtes.Forms.Dialogs
{
    // Visor generico: muestra cualquier reporte .rdlc del proyecto.
    // Recibe el nombre del reporte, el nombre del conjunto de datos dentro del .rdlc
    // y la tabla con los datos.
    public class FrmVisorReporte : Form
    {
        private ReportViewer RvReporte;

        private readonly string _recurso;       // Ej: "ComercioArtes.Reportes.RptObras.rdlc"
        private readonly string _nombreDataSet; // Ej: "DataSet1"
        private readonly DataTable _datos;
        private readonly string _filtro;

        public FrmVisorReporte(string titulo, string recurso, string nombreDataSet, DataTable datos, string filtro)
        {
            _recurso = recurso;
            _nombreDataSet = nombreDataSet;
            _datos = datos;
            _filtro = filtro;

            Text = titulo;
            Size = new Size(1000, 650);
            StartPosition = FormStartPosition.CenterParent;

            RvReporte = new ReportViewer();
            RvReporte.Dock = DockStyle.Fill;
            Controls.Add(RvReporte);

            Load += FrmVisorReporte_Load;
        }

        // El reporte se carga cuando se abre el formulario
        private void FrmVisorReporte_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Que reporte mostrar
                RvReporte.LocalReport.ReportEmbeddedResource = _recurso;

                // 2. Con que datos (el nombre debe ser igual al del conjunto de datos del .rdlc)
                RvReporte.LocalReport.DataSources.Clear();
                RvReporte.LocalReport.DataSources.Add(new ReportDataSource(_nombreDataSet, _datos));

                // 3. Parametros del reporte: el usuario que lo abrio y el filtro usado
                ReportParameter[] parametros = new ReportParameter[]
                {
                    new ReportParameter("Usuario", Sesion.Nombre),
                    new ReportParameter("Filtro", _filtro)
                };
                RvReporte.LocalReport.SetParameters(parametros);

                // 4. Dibujarlo
                RvReporte.SetDisplayMode(DisplayMode.PrintLayout);
                RvReporte.ZoomMode = ZoomMode.PageWidth;
                RvReporte.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NicaArt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
