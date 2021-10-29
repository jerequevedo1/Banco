using BancoAccesoDatos;
using BancoDominio;
using BancoDominio.Entidades;
using BancoServicios;
using BancoServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoPresentacion
{
	public partial class FrmConsulta : Form
	{
		public IService gestor;
		//private Form activeForm;

		public FrmConsulta()
		{
			InitializeComponent();
			gestor = new ServiceFactory().CrearService(new DaoFactory());
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			//opcion con ventana emergente
			new FrmNuevo().ShowDialog(); 

			//opcion con ventana embebida
			//panelConsulta.Visible = false;
			//OpenChildForm(new FrmNuevo(), sender);
			//panelConsulta.Visible = true;
		}
		//public void OpenChildForm(Form childForm, object btnSender)
		//{

		//	if (activeForm != null)
		//	{
		//		activeForm.Close();
		//	}
		//	//ActivateButton(btnSender);
		//	activeForm = childForm;
		//	childForm.TopLevel = false;
		//	childForm.FormBorderStyle = FormBorderStyle.None;
		//	childForm.Dock = DockStyle.Fill;
		//	this.panelConsulta.Controls.Add(childForm);
		//	this.panelConsulta.Tag = childForm;
		//	childForm.BringToFront();
		//	childForm.Show();
		//}
		private void btnConsultar_Click(object sender, EventArgs e)
		{
			CargarGrillaClientes();
		}

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
			CargarTiposFiltros();
			CargarFiltroFecha();
			Cargarheadergrid();

        }

        private void Cargarheadergrid()
        {
			this.dgvConsulta.Columns[0].HeaderText = "NRO CLIENTE";
			this.dgvConsulta.Columns[1].HeaderText = "NOMBRE";
			this.dgvConsulta.Columns[2].HeaderText = "DNI";
			this.dgvConsulta.Columns[3].HeaderText = "DIRECCION";
			this.dgvConsulta.Columns[4].HeaderText = "TELEFONO";
			this.dgvConsulta.Columns[5].HeaderText = "EMAIL";
		}

        private void CargarGrillaClientes()
		{

			List<Cliente> lst = new List<Cliente>();
			List<Parametro> filtros = CargarParametros();// Acá una acción de acuerdo a como venía el form

			dgvConsulta.Rows.Clear();
			lst = gestor.GetByFiltersCliente(filtros);


			foreach (Cliente item in lst)
			{
				dgvConsulta.Rows.Add(new object[] { item.IdCliente, item.NomCliente.ToString() +" "+
			    item.ApeCliente.ToString(), item.Dni, item.Direccion.ToString(), item.Telefono, item.Email.ToString(), ""/*item.GetFechaBajaFormato()*/ }) ;
			}

		}

		private List<Parametro> CargarParametros()
		{
            List<Parametro> filtros = new List<Parametro>();
           // filtros.Add(new Parametro("@fechaDesde", dtpFechaDesde.Value)); //Esta comentado para definir si agregamos enum
          // filtros.Add(new Parametro("@fechaHasta", dtpFechaHasta.Value));

            object filtroTexto = DBNull.Value;
            if (!String.IsNullOrEmpty(txtFiltro.Text))
                filtroTexto = txtFiltro.Text;

			// aca tambien modos
            if (cboFiltro.SelectedIndex == 0)
            {
                filtros.Add(new Parametro("@nroCliente", filtroTexto));
            }
            else
            {
                filtros.Add(new Parametro("@clienteNombre", filtroTexto));
            }

            //string conInactivos = "N";
            //if (chkBajas.Checked)
            //    conInactivos = "S";
           // filtros.Add(new Parametro("@activo", conInactivos));

            filtros.Add(new Parametro("@tipo", cboFiltro.SelectedIndex));

            return filtros;
        }

		private void CargarFiltroFecha()
		{
			string[] filtrosFecha = new string[] { "Hoy", "Ayer", "Ultimos 7 dias", "Ultimos 14 dias", "Ultimos 28 dias" };
			cboFiltroFecha.Items.Clear();
			cboFiltroFecha.Items.AddRange(filtrosFecha);
			cboFiltroFecha.SelectedIndex = 4;
		}
		private void CargarTiposFiltros()
		{
				string[] tiposFiltros = new string[] { "Numero de Cliente", "Nombre Cliente", "Inactivos" };

				cboFiltro.Items.Clear();
				cboFiltro.Items.AddRange(tiposFiltros);
				cboFiltro.SelectedIndex = 0;
		}

        private void cboFiltroFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
			switch (cboFiltroFecha.SelectedIndex)
			{
				case 0:
					dtpFechaDesde.Value = DateTime.Today;
					break;
				case 1:
					dtpFechaDesde.Value = DateTime.Today.AddDays(-1);
					break;
				case 2:
					dtpFechaDesde.Value = DateTime.Today.AddDays(-7);
					break;
				case 3:
					dtpFechaDesde.Value = DateTime.Today.AddDays(-14);
					break;
				case 4:
					dtpFechaDesde.Value = DateTime.Today.AddDays(-28);
					break;
			}
		}



    }


}
