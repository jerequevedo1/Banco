
using BancoAccesoDatos;
using BancoPresentacion;
using BancoPresentacion.Client;
using BancoPresentacion.Entidades;
using BancoServicios;
using BancoServicios.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BancoPresentacion.Enumeraciones;

namespace BancoPresentacion
{
	public partial class FrmNuevoEditar : Form
	{
		//private IClienteService gestorCliente;
		//private ICuentaService gestorCuenta;
		private Accion modo;
		private Tipo tipo;
		private Cliente oCliente;
		private Cuenta oCuenta;
		private bool clienteExistente;
		private int nro;
		private bool esPrimero;
		public FrmNuevoEditar(Accion modo, Tipo tipo,Cliente cliente)
		{
			InitializeComponent();
			//gestorCliente = new ServiceFactory().CrearClienteService(new DaoFactory());
			//gestorCuenta = new ServiceFactory().CrearCuentaService(new DaoFactory());
			//gestorCliente = new ServiceFactory().CrearClienteService();
			//gestorCuenta = new ServiceFactory().CrearCuentaService();
			oCliente = new Cliente();
			oCuenta = new Cuenta();
			//oCliente.Provincia = new Provincia();
			if (!modo.Equals(Accion.Create))
			{
				oCliente = cliente;
			}

			esPrimero = true;
			this.modo = modo;
			this.tipo = tipo;
			this.clienteExistente = false;
		}

		private async void btnBuscar_Click(object sender, EventArgs e)
		{

			if (!txtCliente.Text.Equals(string.Empty))
			{
				
				List<Parametro> parametro = new List<Parametro>();
				parametro.Add(new Parametro("@ClienteNombre", txtCliente.Text));

				FrmConsultaCliente frm = new FrmConsultaCliente(parametro);

				frm.ShowDialog();
				nro = frm.GetNroCliente();
				clienteExistente = frm.GetClienteExistente();

				//oCliente = gestorCliente.GetClienteId(nro);

				string url = "https://localhost:44304/api/Cliente/" + nro;
				var data = await ClientSingleton.ObtenerInstancia().GetAsync(url);

				oCliente = JsonConvert.DeserializeObject<Cliente>(data);

				if (nro!=0)
				{
					CargarCliente(oCliente);
					lblNroCliente.Text = "Nro Cliente: " + nro;
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
			oCliente = null;
			clienteExistente = false;
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
					((ComboBox)item).SelectedIndex = 0;

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

		private async void FrmNuevoEditar_Load(object sender, EventArgs e)
		{
			await CargarTipoCuenta();
			CargarTipoMoneda();
			await CargarProvincias();

			if (tipo.Equals(Tipo.Cliente))
			{
				if (modo.Equals(Accion.Create))
				{
					this.Text = "Nueva Cuenta";
					SetFormDefault();
					this.Size = new Size(782, 454);
					await CargarProximos();
				}

				if (modo.Equals(Accion.Update))
				{
					this.Text = "Editar Cliente";
					CargarCliente(oCliente);
					SetFormDefault();
					SetFormCliente();

					lblNroCliente.Text = "Nro Cliente: " + oCliente.IdCliente.ToString();
				}
				if (modo.Equals(Accion.Read))
				{
					this.Text = "Consulta Cliente";
					CargarCliente(oCliente);
					SetFormDefault();
					SetFormCliente();

					panelCliente.Enabled = false;
					btnAceptar.Visible = false;
					lblNroCliente.Text = "Nro Cliente: " + oCliente.IdCliente.ToString();
				}

			}
			if (tipo.Equals(Tipo.Cuenta))
			{
				if (modo.Equals(Accion.Create))
				{
					this.Text = "Nueva Cuenta";
					await CargarProximos();
				}
				if (modo.Equals(Accion.Update))
				{
					this.Text = "Editar Cuenta";
					CargarCliente(oCliente);
					CargarCuenta(oCliente);
					SetFormDefault();
					SetFormCuenta();
					lblNroCliente.Text = "Nro Cliente: " + oCliente.IdCliente.ToString();
					lblNroCuenta.Text = "Nro Cuenta: " + oCliente.Cuentas[0].IdCuenta.ToString();
					cboTipoCuenta.Enabled = false;
					cboTipoMoneda.Enabled = false;
					txtCbu.Enabled = false;
				}
				if (modo.Equals(Accion.Read))
				{
					this.Text = "Consulta Cuenta";
					CargarCliente(oCliente);
					CargarCuenta(oCliente);
					SetFormDefault();
					SetFormCuenta();
					panelCuenta.Enabled = false;

					btnAceptar.Visible = false;
					lblNroCliente.Text = "Nro Cliente: " + oCliente.IdCliente.ToString();
					lblNroCuenta.Text = "Nro Cuenta: " + oCliente.Cuentas[0].IdCuenta.ToString();
				}

			}

			btnNuevo.Visible = false;
		}

		private async Task CargarProximos()
		{
			int nroCliente = await ObtenerProximoCliente();
			lblNroCliente.Text = "Nro Cliente: " + nroCliente;
			int nroCuenta= await ObtenerProximaCuenta();
			lblNroCuenta.Text = "Nro Cuenta: " + nroCuenta;
		}
		private void SetFormCuenta()
		{
			panelCliente.Enabled = false;
			this.Size = new Size(782, 454);
		}

		private void SetFormCliente()
		{
			this.Size = new Size(782, 310);
			panelCliente.Location = new Point(42, 40);
			lblNroCliente.Location = new Point(19, 20);
			panelCuenta.Visible = false;
			lblNroCuenta.Visible = false;
		}

		public void SetFormDefault()
		{
			txtCliente.Visible = false;
			btnBuscar.Visible = false;
			lblBuscarCliente.Visible = false;
		}
		private async Task<int> ObtenerProximoCliente()
		{
			string url = "https://localhost:44304/api/Cliente/proximoId";
			var data = await ClientSingleton.ObtenerInstancia().GetAsync(url);
			int nro = JsonConvert.DeserializeObject<int>(data);
			return nro;
		}
		private async Task<int> ObtenerProximaCuenta()
		{
			string url = "https://localhost:44304/api/Cuenta/proximoId";
			var data = await ClientSingleton.ObtenerInstancia().GetAsync(url);
			int nro = JsonConvert.DeserializeObject<int>(data);
			return nro;
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

		private async void CargarCliente(Cliente oCliente)
		{
				
			txtCliNombre.Text = oCliente.NomCliente;
			txtCliApellido.Text = oCliente.ApeCliente;
			txtCliDNI.Text = oCliente.Dni.ToString();
			txtCliCuil.Text = oCliente.Cuil.ToString();

			cboCliProvincia.SelectedValue = oCliente.Provincia.IdProvincia;
			await CargarLocalidades(oCliente.Provincia.IdProvincia);
			cboCliLocalidad.SelectedValue = oCliente.Provincia.lLocalidad[0].IdLocalidad;
			await CargarBarrios(oCliente.Provincia.lLocalidad[0].IdLocalidad);
			cboClienteBarrio.SelectedValue = oCliente.Provincia.lLocalidad[0].lBarrio[0].IdBarrio;

			txtCliDire.Text = oCliente.Direccion;
			txtCliTel.Text = oCliente.Telefono;
			txtCliEmail.Text = oCliente.Email;
		}
		private async Task CargarLocalidades(int id_prov)
		{
			List<Localidad> lst = new List<Localidad>();
			List<Parametro> parametro = new List<Parametro>();

			parametro.Add(new Parametro("@id_prov", id_prov));

			string parametrosJson = JsonConvert.SerializeObject(parametro);

			string url = "https://localhost:44304/api/Cliente/getLocalidades";
			var result = await ClientSingleton.ObtenerInstancia().PostAsync(url, parametrosJson);

			lst = JsonConvert.DeserializeObject<List<Localidad>>(result);

			//lst = gestorCliente.GetLocalidades(parametro);

			//cboCliLocalidad.Items.Clear();
			cboCliLocalidad.DataSource = lst;
			cboCliLocalidad.ValueMember = "IdLocalidad";
			cboCliLocalidad.DisplayMember = "NomLocalidad";
			//cboCliLocalidad.SelectedIndex = 0;

		}

		private async Task CargarProvincias()
		{
			List<Provincia> lstP = new List<Provincia>();
			//lstP = gestorCliente.GetProvincias();

			string url = "https://localhost:44304/api/Cliente/getProvincias";
			var data = await ClientSingleton.ObtenerInstancia().GetAsync(url);
			lstP = JsonConvert.DeserializeObject<List<Provincia>>(data);

			//cboCliProvincia.Items.Clear();
			cboCliProvincia.DataSource = lstP;
			cboCliProvincia.ValueMember = "IdProvincia";
			cboCliProvincia.DisplayMember = "NomProvincia";
			cboCliProvincia.SelectedIndex = 0;
		}

		private async Task CargarBarrios(int id_loc)
		{
			List<Barrio> lstB = new List<Barrio>();
			List<Parametro> parametro = new List<Parametro>();

			parametro.Add(new Parametro("@id_loc", id_loc));

			string parametrosJson = JsonConvert.SerializeObject(parametro);

			string url = "https://localhost:44304/api/Cliente/getBarrios";
			var result = await ClientSingleton.ObtenerInstancia().PostAsync(url, parametrosJson);

			lstB = JsonConvert.DeserializeObject<List<Barrio>>(result);

			//lstB = gestorCliente.GetBarrios(parametro);

			//cboClienteBarrio.Items.Clear();
			cboClienteBarrio.DataSource = lstB;
			cboClienteBarrio.ValueMember = "IdBarrio";
			cboClienteBarrio.DisplayMember = "NomBarrio";

			
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

		private async Task CargarTipoCuenta()
		{
			List<TipoCuenta> lstTC = new List<TipoCuenta>();

			string url = "https://localhost:44304/api/Cuenta/tipoCuenta";
			var data = await ClientSingleton.ObtenerInstancia().GetAsync(url);

			lstTC = JsonConvert.DeserializeObject<List<TipoCuenta>>(data);

			//lstTC = gestorCuenta.GetTipoCuenta();

			cboTipoCuenta.Items.Clear();
			cboTipoCuenta.DataSource = lstTC;
			cboTipoCuenta.ValueMember = "IdTipoCuenta";
			cboTipoCuenta.DisplayMember = "DescTipoCuenta";
			cboTipoCuenta.SelectedIndex = 0;
		}

		private async void btnAceptar_Click(object sender, EventArgs e)
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
                    if (ValidarAll())
                    {
						if (clienteExistente)
						{
							await GuardarCuenta();
						}
						else
						{
							await GuardarCuentaConCliente();
						}
					}				
					
				}
				if (modo.Equals(Accion.Update))
				{
					//validaciones
					if (ValidarAll())
                    {
						await GuardarCuenta();
					}
						
				}
			}
			if (tipo.Equals(Tipo.Cliente))
			{
				//VALIDAR 
				if (ValidarAll())
                {
					if (modo.Equals(Accion.Create))
					{
						await GuardarCuentaConCliente();
					}
					if (modo.Equals(Accion.Update))
					{
						await GuardarCuenta();
					}
				}
					

			}
			
		}
		private async Task GuardarCuentaConCliente()
		{
			Provincia provincia = new Provincia();
			Barrio barrio = new Barrio();
			Localidad localidad = new Localidad();
			provincia.AgregarLocalidad(localidad);
			localidad.AgregarBarrio(barrio);
			oCliente.Provincia = provincia;


			oCliente.NomCliente = txtCliNombre.Text;
			oCliente.ApeCliente = txtCliApellido.Text;
			oCliente.Dni = int.Parse(txtCliDNI.Text);
			oCliente.Cuil = long.Parse(txtCliCuil.Text);
			oCliente.Direccion = txtCliDire.Text;
			oCliente.Telefono = txtCliTel.Text;
			oCliente.Email = txtCliEmail.Text;

			oCliente.Provincia.IdProvincia = Convert.ToInt32(cboCliProvincia.SelectedValue);
			oCliente.Provincia.lLocalidad[0].IdLocalidad = Convert.ToInt32(cboCliLocalidad.SelectedValue);

			oCliente.Provincia.lLocalidad[0].lBarrio[0].IdBarrio = Convert.ToInt32(cboClienteBarrio.SelectedValue);
			

			oCuenta.Cbu = txtCbu.Text;
			oCuenta.Alias = txtAlias.Text;
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

			string url = "";
			if (tipo.Equals(Tipo.Cuenta))
			{
				url = "https://localhost:44304/api/Cuenta/newCuenta";
			}
			if (tipo.Equals(Tipo.Cliente))
			{
				url = "";
			}
			
			var guardarOk = await GuardarCuentaAsync(oCliente, url);

			if (modo.Equals(Accion.Create))
			{
				if (guardarOk)
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
		private async Task GuardarCuenta()
		{
			if (tipo.Equals(Tipo.Cuenta))
			{
				if (modo.Equals(Accion.Update))
				{
					//actualizando cuenta
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
					string url = "https://localhost:44304/api/Cuenta/modifyCuenta";
					var guardarOk = await EditarAsync(oCliente, url);

					if (guardarOk)
					{
						MessageBox.Show("Cuenta del Cliente " + oCliente.NombreCompleto() + " actualizada con exito.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Close();
					}
					else
					{
						MessageBox.Show("ERROR. No se pudo actualizar la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				
				// insertar una cuenta cliente existente
				if (modo.Equals(Accion.Create))
				{
					if (oCliente.Cuentas.Count==0)
					{
						oCliente.AgregarCuenta(oCuenta);
					}
					
					int i = 0;
					oCuenta.Cbu = txtCbu.Text;
					oCuenta.Alias = txtAlias.Text;
					oCuenta.Saldo = Convert.ToInt32(txtDepositoInicial.Text);

					oCuenta.TipoCuenta = new TipoCuenta();
					oCuenta.TipoCuenta.IdTipoCuenta = Convert.ToInt32(cboTipoCuenta.SelectedValue);
					oCuenta.LimiteDescubierto = Convert.ToDouble(txtLimiteDesc.Text);
					
					if (cboTipoMoneda.SelectedValue.Equals(1))
					{
						oCliente.Cuentas[i].TipoMoneda = "P";
					}
					if (cboTipoMoneda.SelectedValue.Equals(2))
					{
						oCliente.Cuentas[i].TipoMoneda = "D";
					}

					string url = "https://localhost:44304/api/Cuenta/newCuentaOnly";
					var editarOk=await GuardarCuentaAsync(oCliente,url);


					if (editarOk)
					{
						MessageBox.Show("Cuenta registrada al Cliente " + oCliente.NombreCompleto() + " con exito.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Close();
					}
					else
					{
						MessageBox.Show("ERROR. No se pudo registrar la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}

			// actualizar un cliente
			
			if (tipo.Equals(Tipo.Cliente) && modo.Equals(Accion.Update))
			{
				
				if (tipo.Equals(Tipo.Cliente))
				{
					
					Provincia provincia = new Provincia();
					Barrio barrio = new Barrio();
					Localidad localidad = new Localidad();
					provincia.AgregarLocalidad(localidad);
					localidad.AgregarBarrio(barrio);
					oCliente.Provincia = provincia;

					oCliente.NomCliente = txtCliNombre.Text;
					oCliente.ApeCliente = txtCliApellido.Text;
					oCliente.Dni = int.Parse(txtCliDNI.Text);
					oCliente.Cuil = long.Parse(txtCliCuil.Text);
					oCliente.Direccion = txtCliDire.Text;
					oCliente.Telefono = txtCliTel.Text;
					oCliente.Email = txtCliEmail.Text;

					oCliente.Provincia.IdProvincia = Convert.ToInt32(cboCliProvincia.SelectedValue);
					oCliente.Provincia.lLocalidad[0].IdLocalidad = Convert.ToInt32(cboCliLocalidad.SelectedValue);

					oCliente.Provincia.lLocalidad[0].lBarrio[0].IdBarrio = Convert.ToInt32(cboClienteBarrio.SelectedValue);

					string url = "https://localhost:44304/api/Cliente/modifyCliente";

					bool editarOk=await EditarAsync(oCliente,url);

					if (editarOk)
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

		private async Task<bool> GuardarCuentaAsync(Cliente oCliente,string url)
		{

			string oClienteJson = JsonConvert.SerializeObject(oCliente);

			var result = await ClientSingleton.ObtenerInstancia().PostAsync(url, oClienteJson);

			return result.Equals("true");
		}
		private async Task<bool> EditarAsync(Cliente oCliente, string url)
		{
			string oClienteJson = JsonConvert.SerializeObject(oCliente);

			var result = await ClientSingleton.ObtenerInstancia().PutAsync(url, oClienteJson);

			return result.Equals("true");
		}
		//private async Task<bool> EditarClienteAsync(List<Parametro> parametro, string url)
		//{
		//	string parametroJson = JsonConvert.SerializeObject(parametro);

		//	var result = await ClientSingleton.ObtenerInstancia().PutAsync(url, parametroJson);

		//	return result.Equals("true");
		//}
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private async void cboCliProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
		

			if(modo.Equals(Accion.Create))
			{

				if (esPrimero)
				{
					esPrimero = false;
					return;
				}
				else
				{
					int id_prov = Convert.ToInt32(cboCliProvincia.SelectedValue.GetHashCode());
					//int id_prov = Convert.ToInt32(Convert.ToInt32(cboCliProvincia.SelectedValue));
					await CargarLocalidades(id_prov);

				}

			}
			//else
			//{
			//	await CargarLocalidades(oCliente.Provincia.IdProvincia);
			//}

		}

		private async void cboCliLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {	
			if (modo.Equals(Accion.Create))
			{
				int id_loc = Convert.ToInt32(cboCliLocalidad.SelectedValue.GetHashCode());

				await CargarBarrios(id_loc);
			}
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
		private bool ValidarAll()
		{
			if ((txtCliNombre.Text == "") || (!Regex.IsMatch(txtCliNombre.Text, "([a-zA-ZñÑ]{3,30}\\s*)+")))
			{
				if (txtCliNombre.Text == "")
				{
					MessageBox.Show("Debe Ingresar un Nombre.", "Control",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtCliNombre.Focus();
					return false;
				}
				else
				{
					MessageBox.Show("Error, No se admiten numeros ni palabras menos de 3 letras.", "Control", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
					txtCliNombre.Focus();
					return false;
				}
			}
			if (txtCliApellido.Text == "" || (!Regex.IsMatch(txtCliApellido.Text, "([a-zA-ZñÑ]{3,30}\\s*)+")))
			{
				if (txtCliApellido.Text == "")
				{
					MessageBox.Show("Debe Ingresar un Apellido.", "Control",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtCliApellido.Focus();
					return false;
				}
				else
				{
					MessageBox.Show("Error, No se admiten numeros ni palabras menos de 3 letras.", "Control", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
					txtCliApellido.Focus();
					return false;
				}
			}
			if (txtCliDNI.Text == "" || (!Regex.IsMatch(txtCliDNI.Text, "([0-9]{8,10}\\s*)+")))
			{
				if (txtCliDNI.Text == "")
				{
					MessageBox.Show("Debe especificar un DNI.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtCliDNI.Focus();
					return false;
				}
				else
				{
					MessageBox.Show("Error, No se admiten Letras ni menos de 8 Digitos.", "Control", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
					txtCliDNI.Focus();
					return false;
				}

			}
			if (txtCliCuil.Text == "" || (!Regex.IsMatch(txtCliCuil.Text, "([0-9]{11,12}\\s*)+")))
			{
				if (txtCliCuil.Text == "")
				{
					MessageBox.Show("Debe especificar un Cuil.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtCliCuil.Focus();
					return false;
				}
				else
				{
					MessageBox.Show("Error, No se admiten Letras ni menos de 11 Digitos.", "Control", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
					txtCliCuil.Focus();
					return false;
				}
			}
			if (txtCliDire.Text == "" || (!Regex.IsMatch(txtCliDire.Text, "([0-9a-zA-ZñÑ]{5,30}\\s*)+")))
			{
				MessageBox.Show("Debe especificar una Direccion correcta.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCliDire.Focus();
				return false;
			}
			if (txtCliTel.Text == "" || (!Regex.IsMatch(txtCliTel.Text, "([0-9]{9,15}\\s*)+")))
			{
				MessageBox.Show("Debe especificar un Telefono.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCliTel.Focus();
				return false;
			}
			if (txtCliEmail.Text == "")
			{
				MessageBox.Show("Debe especificar un Email.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCliEmail.Focus();
				return false;
			}
			if (!Regex.IsMatch(txtCliEmail.Text, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"))
			{
				MessageBox.Show("Debe Ingresar un Email Valido.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCliEmail.Focus();
				return false;
			}
			//////////////////////////////
			if (txtCbu.Text == "" || (!Regex.IsMatch(txtCliTel.Text, "([0-9]{22,30}\\s*)+")))
			{
				MessageBox.Show("No se ingreso un CBU o el Ingresado es erroneo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCbu.Focus();
				return false;
			}
			if (txtAlias.Text == "")
			{
				MessageBox.Show("Debe especificar un Alias.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtAlias.Focus();
				return false;
			}
			if (cboTipoMoneda.Text.Equals(string.Empty))
			{
				MessageBox.Show("Debe seleccionar un Tipo de Moneda", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cboTipoMoneda.Focus();
				return false;
			}
			if (cboTipoCuenta.Text.Equals(string.Empty))
			{
				MessageBox.Show("Debe seleccionar un Tipo de Cuenta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cboTipoCuenta.Focus();
				return false;
			}
			else
				return true;
		}

	}

}
