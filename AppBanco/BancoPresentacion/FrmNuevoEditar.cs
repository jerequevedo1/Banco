using BancoAccesoDatos;
using BancoPresentacion;
using BancoPresentacion.Entidades;
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
using static BancoPresentacion.Enumeraciones;

namespace BancoPresentacion
{
	public partial class FrmNuevoEditar : Form
	{
		private IClienteService gestorCliente;
		private ICuentaService gestorCuenta;
		private Accion modo;
		private Tipo tipo;
		private Cliente oCliente;
		private Cuenta oCuenta;
		private bool clienteExistente;
		public FrmNuevoEditar(Accion modo, Tipo tipo,Cliente cliente)
		{
			InitializeComponent();
			gestorCliente = new ServiceFactory().CrearClienteService(new DaoFactory());
			gestorCuenta = new ServiceFactory().CrearCuentaService(new DaoFactory());
			oCliente = new Cliente();
			oCuenta = new Cuenta();
			oCliente = cliente;
			this.modo = modo;
			this.tipo = tipo;
			this.clienteExistente = false;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (!txtCliente.Text.Equals(string.Empty))
			{
				int nroCliente = 0;
				List<Parametro> parametro = new List<Parametro>();
				parametro.Add(new Parametro("@ClienteNombre", txtCliente.Text));

				FrmConsultaCliente frm = new FrmConsultaCliente(parametro);

				frm.ShowDialog();
				nroCliente = frm.GetNroCliente();
				clienteExistente = frm.GetClienteExistente();

				if (nroCliente!=0)
				{
					CargarCliente(nroCliente);
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
					CargarCliente(oCliente.IdCliente);
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
					CargarCuenta(oCliente);
					CargarCliente(oCliente.IdCliente);
					txtCliente.Visible = false;
					btnBuscar.Visible = false;
					lblBuscarCliente.Visible = false;
					panelCliente.Enabled = false;
					this.Size = new Size(782, 454);
				}
			}
	
		    btnNuevo.Visible = false;
			
	
		}

		private void CargarCuenta(Cliente oCliente)
		{
			foreach (Cuenta item in oCliente.Cuentas)
			{
				int i = 0;
				txtCbu.Text = oCliente.Cuentas[i].Cbu;
				txtLimiteDesc.Text = oCliente.Cuentas[i].LimiteDescubierto.ToString();
				
				txtAlias.Text = oCliente.Cuentas[i].Alias;
				if (oCliente.Cuentas[i].TipoMoneda.Equals("P"))
				{
					cboTipoMoneda.SelectedValue =1;
				}
				else
				{
					cboTipoMoneda.SelectedValue = 2;
				}
				txtDepositoInicial.Text = oCliente.Cuentas[i].Saldo.ToString();
				cboTipoCuenta.SelectedValue = oCliente.Cuentas[i].TipoCuenta.IdTipoCuenta;
			}
		}

		private void CargarCliente(int nro)
		{
			Cliente oClienteAux= gestorCliente.GetClienteId(nro);

			if (modo.Equals(Accion.Create) && tipo.Equals(Tipo.Cuenta))
			{
				oCliente = oClienteAux;
			}

			txtCliNombre.Text = oClienteAux.NomCliente;
			txtCliApellido.Text = oClienteAux.ApeCliente;
			txtCliDNI.Text = oClienteAux.Dni.ToString();
			txtCliCuil.Text = oClienteAux.Cuil.ToString();
			cboClienteBarrio.SelectedValue = oClienteAux.Barrio.IdBarrio;
			txtCliDire.Text = oClienteAux.Direccion;
			txtCliTel.Text = oClienteAux.Telefono;
			txtCliEmail.Text = oClienteAux.Email;

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
					//if (txtCliente.Text == "")
					//{
					//	MessageBox.Show("Debe especificar un cliente.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					//	txtCliente.Focus();
					//	return;
					//}
					if (!clienteExistente)
					{
						GuardarCuentaConCliente();
					}
					else
					{
						GuardarCuenta();
					}
					
				}
				if (modo.Equals(Accion.Update))
				{
					//validaciones

					GuardarCuenta();
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

			
			oCliente.NomCliente = txtCliNombre.Text;
			oCliente.ApeCliente = txtCliApellido.Text;
			oCliente.Dni = int.Parse(txtCliDNI.Text);
			oCliente.Cuil = long.Parse(txtCliCuil.Text);
			oCliente.Direccion = txtCliDire.Text;
			oCliente.Telefono = txtCliTel.Text;
			oCliente.Email = txtCliEmail.Text;
			oCliente.Barrio = new Barrio();
			oCliente.Barrio.IdBarrio = Convert.ToInt32(cboClienteBarrio.SelectedValue);
			
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
		    
			if (modo.Equals(Accion.Create))
			{
				int i = 0;
				oCuenta.Cbu = txtCbu.Text;
				oCuenta.Alias = txtAlias.Text;
				oCuenta.Saldo = Convert.ToInt32(txtDepositoInicial.Text);

				oCuenta.TipoCuenta = new TipoCuenta();
				oCuenta.TipoCuenta.IdTipoCuenta = Convert.ToInt32(cboTipoCuenta.SelectedValue);
				oCuenta.LimiteDescubierto = Convert.ToDouble(txtLimiteDesc.Text);

				oCliente.AgregarCuenta(oCuenta);

				if (cboTipoMoneda.SelectedValue.Equals(1))
				{
					oCliente.Cuentas[i].TipoMoneda = "P";
				}
				if (cboTipoMoneda.SelectedValue.Equals(2))
				{
					oCliente.Cuentas[i].TipoMoneda = "D";
				}

				if (gestorCuenta.NuevaCuentaClienteExist(oCliente))
				{
					MessageBox.Show("Cuenta registrada al Cliente "+ oCliente.NombreCompleto() + " con exito.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else
				{
					MessageBox.Show("ERROR. No se pudo registrar la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			if (modo.Equals(Accion.Update))
			{
				foreach (Cuenta item in oCliente.Cuentas)
				{
					int i = 0;
					oCliente.Cuentas[i].Cbu = txtCbu.Text;
					oCliente.Cuentas[i].Alias = txtAlias.Text;
					oCliente.Cuentas[i].Saldo = Convert.ToInt32(txtDepositoInicial.Text);

					oCliente.Cuentas[i].TipoCuenta = new TipoCuenta();
					oCliente.Cuentas[i].TipoCuenta.IdTipoCuenta = Convert.ToInt32(cboTipoCuenta.SelectedValue);
					oCliente.Cuentas[i].LimiteDescubierto = Convert.ToDouble(txtLimiteDesc.Text);


					if (cboTipoMoneda.SelectedValue.Equals(1))
					{
						oCliente.Cuentas[i].TipoMoneda = "P";
					}
					if (cboTipoMoneda.SelectedValue.Equals(2))
					{
						oCliente.Cuentas[i].TipoMoneda = "D";
					}

				}
				if (gestorCuenta.ModificarCuenta(oCliente))
				{
					MessageBox.Show("Cuenta del Cliente " + oCliente.NombreCompleto() + " actualizada con exito.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else
				{
					MessageBox.Show("ERROR. No se pudo actualizar la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void txtCliNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
			Validar.SoloLetra(e);
		}

        private void txtCliApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
			Validar.SoloLetra(e);
		}

        private void txtCliDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
			Validar.SoloNumeros(e);
		}

        private void txtCliCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
			Validar.SoloNumeros(e);
		}

        private void txtCliTel_KeyPress(object sender, KeyPressEventArgs e)
        {
			Validar.SoloNumeros(e);
		}

        private void txtCbu_KeyPress(object sender, KeyPressEventArgs e)
        {
			Validar.SoloNumeros(e);
		}

        private void txtLimiteDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
			Validar.SoloTipoPlata(e);
		}

        private void txtDepositoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
			Validar.SoloTipoPlata(e);
		}
    }
}
