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
	public partial class FrmNuevoEditar : Form
	{
		private IClienteService gestorCliente;
		private ICuentaService gestorCuenta;
		private Accion modo;
		private Tipo tipo;
		private List<Cliente> lst;
		private Cliente oCliente;
		private Cuenta oCuenta;
		private int nro= new int();
		private bool clienteExistente;
		public FrmNuevoEditar(Accion modo, Tipo tipo,int nro)
		{
			InitializeComponent();
			gestorCliente = new ServiceFactory().CrearClienteService(new DaoFactory());
			gestorCuenta = new ServiceFactory().CrearCuentaService(new DaoFactory());
			lst = new List<Cliente>();
			oCliente = new Cliente();
			oCuenta = new Cuenta();
			this.modo = modo;
			this.tipo = tipo;
			this.nro = nro;
			this.clienteExistente = false;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (!txtCliente.Text.Equals(string.Empty))
			{
				List<Parametro> parametro = new List<Parametro>();
				parametro.Add(new Parametro("@ClienteNombre", txtCliente.Text));

				FrmConsultaCliente frm = new FrmConsultaCliente(parametro);

				frm.ShowDialog();
				nro = frm.GetNroCliente();
				clienteExistente = frm.GetClienteExistente();

				if (nro!=0)
				{
					CargarCliente(nro);
					txtCliente.Text = oCliente.NombreCompleto();
					panelCliente.Enabled = false;
					btnNuevo.Visible = true;
					btnBuscar.Enabled = false;
					txtCliente.Enabled = false;
				}
				
			}
			else
			{
				MessageBox.Show("Debe especificar un cliente.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
		}
		
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			btnBuscar.Enabled = true;
			txtCliente.Enabled = true;
			panelCliente.Enabled = true;
			btnNuevo.Visible = false;
			foreach (Control item in panelCliente.Controls)
			{
				if (item is TextBox)
				{
					((TextBox)item).Clear();
				}
				if (item is ComboBox)
				{
					((ComboBox)item).SelectedIndex = -1;

				}
				//if (item is RadioButton)
				//{
				//	((RadioButton)item).Checked = false;
				//}
				//if (item is CheckBox)
				//{
				//	((CheckBox)item).Checked = false;
				//}
			}
			txtCliente.Text = "";
		}

		private void FrmNuevoEditar_Load(object sender, EventArgs e)
		{
			CargarTipoCuenta();
			CargarTipoMoneda();
			CargarBarrios();
			CargarLocalidades();
			CargarProvincias();

			if (tipo.Equals(Tipo.Cliente))
			{
				if (modo.Equals(Accion.Create))
				{
					this.Text = "Nueva Cuenta";
					txtCliente.Visible = false;
					btnBuscar.Visible = false;
					lblBuscarCliente.Visible = false;					
					this.Size = new Size(782, 454);
				}
				if (modo.Equals(Accion.Update))
				{
					this.Text = "Editar Cliente";
					CargarCliente(nro);
					txtCliente.Visible = false;
					btnBuscar.Visible = false;
					lblBuscarCliente.Visible = false;
					this.Size = new Size(782, 310);
					panelCliente.Location = new Point(42, 40);
					lblNroCliente.Location = new Point(19, 20);
					panelCuenta.Visible = false;
					lblNroCuenta.Visible = false;
				}
			}
			if (tipo.Equals(Tipo.Cuenta))
			{
				if (modo.Equals(Accion.Create))
				{
					this.Text = "Nueva Cuenta";
				}
				if (modo.Equals(Accion.Update))
				{
					this.Text = "Editar Cuenta";
					CargarCliente(nro);
					txtCliente.Visible = false;
					btnBuscar.Visible = false;
					lblBuscarCliente.Visible = false;
					panelCliente.Enabled = false;
					this.Size = new Size(782, 454);
				}
			}
	
		    btnNuevo.Visible = false;
			
			
			//SetFormDefault();
		}

		private void SetFormDefault()
		{
			cboClienteBarrio.SelectedValue = 2;
			cboTipoCuenta.SelectedValue = 2;
			cboTipoMoneda.SelectedValue = 2;
		}

		private void CargarCliente(int nro)
		{
			oCliente.Barrio = new Barrio();
			this.oCliente = gestorCliente.GetClienteId(nro);
			

			txtCliNombre.Text = oCliente.NomCliente;
			txtCliApellido.Text = oCliente.ApeCliente;
			txtCliDNI.Text = oCliente.Dni.ToString();
			txtCliCuil.Text = oCliente.Cuil.ToString();
			//cboClienteBarrio.ValueMember = oCliente.Barrio.IdBarrio.ToString();
			cboClienteBarrio.SelectedValue = oCliente.Barrio.IdBarrio;
			txtCliDire.Text = oCliente.Direccion;
			txtCliTel.Text = oCliente.Telefono;
			txtCliEmail.Text = oCliente.Email;

		}
		private void CargarLocalidades()
		{
			List<Localidad> lst = new List<Localidad>();
			lst = gestorCliente.GetLocalidades();

			cboCliLocalidad.Items.Clear();
			cboCliLocalidad.DataSource = lst;
			cboCliLocalidad.ValueMember = "IdLocalidad";
			cboCliLocalidad.DisplayMember = "NomLocalidad";
			cboCliLocalidad.SelectedIndex = 0;
		}

		private void CargarProvincias()
		{
			List<Provincia> lstP = new List<Provincia>();
			lstP = gestorCliente.GetProvincias();

			cboCliProvincia.Items.Clear();
			cboCliProvincia.DataSource = lstP;
			cboCliProvincia.ValueMember = "IdProvincia";
			cboCliProvincia.DisplayMember = "NomProvincia";
			cboCliProvincia.SelectedIndex = 0;
		}


		private void CargarBarrios()
		{
			List<Barrio> lstB = new List<Barrio>();
			lstB = gestorCliente.GetBarrios();

			cboClienteBarrio.Items.Clear();
			cboClienteBarrio.DataSource = lstB;
			cboClienteBarrio.ValueMember = "IdBarrio";
			cboClienteBarrio.DisplayMember = "NomBarrio";
			cboClienteBarrio.SelectedIndex = 0;
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

			if (tipo.Equals(Tipo.Cuenta))
			{
				if (modo.Equals(Accion.Create))
				{
					//validaciones de campo antes de guardar por ejemplo:
					if (txtCliente.Text == "")
					{
						MessageBox.Show("Debe especificar un cliente.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						txtCliente.Focus();
						return;
					}
					if (!clienteExistente)
					{
						GuardarCuentaConCliente();
					}
					else
					{
						GuardarCuenta();
					}
					
				}
			}
			if (tipo.Equals(Tipo.Cliente))
			{
				//VALIDAR 

				if (modo.Equals(Accion.Create))
				{
					GuardarCuentaConCliente();
				}
								
				List<Parametro> parametro = new List<Parametro>();
				parametro.Add(new Parametro("@id_cliente", oCliente.IdCliente));
				parametro.Add(new Parametro("@nom_cliente", txtCliNombre.Text.ToString()));
				parametro.Add(new Parametro("@ape_cliente", txtCliApellido.Text.ToString()));
				parametro.Add(new Parametro("@dni", int.Parse(txtCliDNI.Text)));
				parametro.Add(new Parametro("@cuil", long.Parse(txtCliCuil.Text)));
				parametro.Add(new Parametro("@direccion", txtCliDire.Text.ToString()));
				parametro.Add(new Parametro("@telefono", txtCliTel.Text.ToString()));
				parametro.Add(new Parametro("@email", txtCliEmail.Text.ToString()));
				parametro.Add(new Parametro("@id_barrio", Convert.ToInt32(cboClienteBarrio.SelectedValue)));


				if (modo.Equals(Accion.Update))
				{
					if (gestorCliente.ModificarClienteSQL(parametro))
					{
						MessageBox.Show("El cliente se actualizo correctamente!!!", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Dispose();
					}
					else
					{
						MessageBox.Show("El cliente NO se pudo actualizar!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
			}
			
		}
		private void GuardarCuentaConCliente()
		{

			if (modo.Equals(Accion.Create) && tipo.Equals(Tipo.Cliente))
			{
				oCliente.NomCliente = txtCliNombre.Text;
				oCliente.ApeCliente = txtCliApellido.Text;
				oCliente.Dni = int.Parse(txtCliDNI.Text);
				oCliente.Cuil = long.Parse(txtCliCuil.Text);
				oCliente.Direccion = txtCliDire.Text;
				oCliente.Telefono = txtCliTel.Text;
				oCliente.Email = txtCliEmail.Text;
				oCliente.Barrio.IdBarrio = Convert.ToInt32(cboClienteBarrio.SelectedValue);
			}
			oCuenta.Cbu = txtCbu.Text;
			oCuenta.Alias = txtAlias.Text;
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
		}
		private void GuardarCuenta()
		{
			

			oCuenta.Cbu = txtCbu.Text;
			oCuenta.Alias = txtAlias.Text;
			//validar si modo es create
			oCuenta.Saldo = Convert.ToInt32(txtDepositoInicial.Text);

			oCuenta.TipoCuenta = new TipoCuenta();
			oCuenta.TipoCuenta.IdTipoCuenta = Convert.ToInt32(cboTipoCuenta.SelectedValue);
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
				if (gestorCuenta.NuevaCuentaClienteExist(oCliente))
				{
					MessageBox.Show("Cuenta registrada al Cliente "+oCliente.ApeCliente+", "+oCliente.NomCliente +" con exito.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
