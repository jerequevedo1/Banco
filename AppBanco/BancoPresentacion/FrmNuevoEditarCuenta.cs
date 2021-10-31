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
	public partial class FrmNuevoEditarCuenta : Form
	{
		private IClienteService gestorCliente;
		private ICuentaService gestorCuenta;
		private List<Cliente> lst = new List<Cliente>();
		private Cliente cliente = new Cliente();
		public FrmNuevoEditarCuenta()
		{
			InitializeComponent();
			gestorCliente = new ServiceFactory().CrearClienteService(new DaoFactory());
			gestorCuenta = new ServiceFactory().CrearCuentaService(new DaoFactory());
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			List<Parametro> parametro = new List<Parametro>();
			parametro.Add(new Parametro("@ClienteNombre",txtCliente.Text));

			lst= gestorCliente.GetClienteByName(parametro);

			dgvClientes.Rows.Clear();
			foreach (Cliente item in lst)
			{
				dgvClientes.Rows.Add(new object[] { item.IdCliente.ToString(),item.NombreCompleto(),item.Dni,item.Email });
			}
		}

		private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int nroCliente = int.Parse(dgvClientes.CurrentRow.Cells["cId"].Value.ToString());

			foreach (Cliente item in lst)
			{
				if(item.IdCliente.Equals(nroCliente))
				{
					cliente = item;
					txtCliente.Text = cliente.NombreCompleto() + ", " + cliente.Dni.ToString();
				}

			}
			
		}
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			//aca se abre el form nuevo cliente
			new FrmNuevoEditarCliente().ShowDialog();
		}

		private void FrmNuevoEditarCuenta_Load(object sender, EventArgs e)
		{
			CargarTipoCuenta();
			CargarTipoMoneda();
		}

		private void CargarTipoMoneda()
		{ 
			var lstMonedas = new [] { new { id = 1, moneda = "Pesos" }, new { id = 2, moneda = "Dolares" } };
	
			cboTipoMoneda.Items.Clear();
			cboTipoMoneda.DataSource = lstMonedas;
			cboTipoMoneda.ValueMember = "id";
			cboTipoMoneda.DisplayMember = "moneda";
			cboTipoMoneda.SelectedIndex=0;
		}

		private void CargarTipoCuenta()
		{
			List<TipoCuenta> lstTC = new List<TipoCuenta>();

			lstTC = gestorCuenta.GetTipoCuenta();

			cboTipoCuenta.Items.Clear();
			cboTipoCuenta.DataSource = lstTC;
			cboTipoCuenta.ValueMember = "IdTipoCuenta";
			cboTipoCuenta.DisplayMember = "DescTipoCuenta";
			cboTipoCuenta.SelectedIndex = 0;
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
