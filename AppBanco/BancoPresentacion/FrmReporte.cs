using BancoAccesoDatos;
using BancoDominio;
using BancoPresentacion.Reportes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoPresentacion
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var saldoMin = Decimal.Parse(txtSaldoMinimo.Text);

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                string appFolder = Path.GetDirectoryName(Application.StartupPath);
                var rutaRpt = Path.Combine(Application.StartupPath, @"~/Reportes\RptCuentasPorCliente.rdlc");
                //ubicacion del reporte
                string pathAbosluto = Application.StartupPath;
                string fullPath = Path.Combine(pathAbosluto, @"..\..\..\Reportes\RptCuentasPorCliente.rdlc");
                fullPath = Path.GetFullPath(fullPath);
                //asignamos la ruta
                reportViewer1.LocalReport.ReportPath = fullPath;

                //parametros de filtro del SP
                DataSetCuentasCliente ds = new DataSetCuentasCliente();
                List<Parametro> parametros = new List<Parametro>();
                parametros.Add(new Parametro("@saldoMinimo", saldoMin));

                reportViewer1.LocalReport.DataSources.Clear();

                //invocamos al SP con param
                var datos = HelperDao.ObtenerInstancia().ConsultaSQLParametros("PA_REPORTE_CUENTAS_CLIENTE", parametros);
                //seteamos el DATASOURCE al reporte
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", datos);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                //refrescamos cambios
                reportViewer1.Refresh();
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo generar el informe, reintente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
