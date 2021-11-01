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
using static BancoDominio.Enumeraciones;

namespace BancoPresentacion
{
	public partial class FrmNuevoEditarCuenta : Form
	{
		private IClienteService gestorCliente;
		private ICuentaService gestorCuenta;
		private Accion modo;
		private List<Cliente> lst;
		private Cliente oCliente;
		private Cuenta oCuenta;
		public FrmNuevoEditarCuenta(Accion modo)
		{
			InitializeComponent();
			gestorCliente = new ServiceFactory().CrearClienteService(new DaoFactory());
			gestorCuenta = new ServiceFactory().CrearCuentaService(new DaoFactory());
			lst = new List<Cliente>();
			oCliente = new Cliente();
			oCuenta = new Cuenta();
			this.modo = modo;
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
					oCliente = item;
					txtCliente.Text = oCliente.NombreCompleto() + ", " + oCliente.Dni.ToString();
				}

			}
			
		}
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			//aca se abre el form nuevo cliente
			new FrmNuevoEditarCliente(Accion.Create,0).ShowDialog();
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
			//validaciones de campo antes de guardar
			if (txtCliente.Text == "")
			{
				MessageBox.Show("Debe especificar un cliente.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCliente.Focus();
				return;
			}
			
			GuardarCuenta();
		}
		private void GuardarCuenta()
		{
			oCuenta.Cbu = txtCbu.Text;
			oCuenta.Alias = txtAlias.Text;
			//validar si modo es create
			oCuenta.Saldo = Convert.ToInt32(txtDepositoInicial.Text);

			oCuenta.TipoCuenta = new TipoCuenta();
			oCuenta.TipoCuenta.IdTipoCuenta =Convert.ToInt32(cboTipoCuenta.SelectedValue);
			oCuenta.LimiteDescubierto = Convert.ToDouble(txtLimiteDesc.Text);
			

			if (cboTipoMoneda.SelectedValue.Equals(1))
			{
				oCuenta.TipoMoneda = "P";
			}
			if (cboTipoMoneda.SelectedValue.Equals(2))
			{
				oCuenta.TipoMoneda = "D";
			}

			oCliente.AgregarCuenta(oCuenta);
			
			if (modo.Equals(Accion.Create))
			{
				if (gestorCuenta.NuevaCuenta(oCliente))
				{
					MessageBox.Show("Cuenta registrada con exito.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else
				{
					MessageBox.Show("ERROR. No se pudo registrar la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				//if (gestorCuenta.EditarCuenta(oCuenta))
				//{
				//	MessageBox.Show("Presupuesto editado con exito.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//	Close();
				//}
				//else
				//{
				//	MessageBox.Show("ERROR. No se pudo editar el presupuesto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//}
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
