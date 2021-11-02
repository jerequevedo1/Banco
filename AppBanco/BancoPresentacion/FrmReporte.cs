using BancoAccesoDatos;
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
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            string appFolder = Path.GetDirectoryName(Application.StartupPath);
            var rutaRpt = Path.Combine(Application.StartupPath, @"~/Reportes\RptCuentasPorCliente.rdlc");


            string pathAbosluto = Application.StartupPath;
            string fullPath = Path.Combine(pathAbosluto, @"..\..\..\Reportes\RptCuentasPorCliente.rdlc");
            fullPath = Path.GetFullPath(fullPath);

            reportViewer1.LocalReport.ReportPath = fullPath;

            //reportViewer1.LocalReport.ReportPath = @"C:\Users\jpolt\OneDrive\Escritorio\Banco_JJRS\AppBanco\BancoPresentacion\Reportes\RptCuentasPorCliente.rdlc";
            reportViewer1.Refresh();


            DataSetCuentasCliente ds = new DataSetCuentasCliente();

            var datos = HelperDao.ObtenerInstancia().ConsultaSQL("PA_REPORTE_CUENTAS_CLIENTE");
            //DATASOURCE
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", datos);

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.Refresh();

        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
