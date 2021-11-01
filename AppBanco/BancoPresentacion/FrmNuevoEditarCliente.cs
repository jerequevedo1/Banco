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

	public partial class FrmNuevoEditarCliente : Form
	{
		public Accion modo;
		public IClienteService gestorCliente;
		Cliente oCliente;

		public FrmNuevoEditarCliente(Accion modo, int nro)
		{   
			InitializeComponent();
			oCliente = new Cliente();
			gestorCliente = new ServiceFactory().CrearClienteService(new DaoFactory());
			this.modo = modo;

            if(modo.Equals(Accion.Update))
            {
				this.Text = "Editar Cliente";
				this.CargarCliente(nro);
			}
		}

        private void CargarCliente(int nro)
        {
			this.oCliente = gestorCliente. GetClienteId(nro);


			txtCliNombre.Text = oCliente.NomCliente;
			txtCliApellido.Text = oCliente.ApeCliente;
			txtCliDNI.Text = oCliente.Dni.ToString();
			txtCliCuil.Text = oCliente.Cuil.ToString();
			cboClienteBarrio.ValueMember= oCliente.Barrio.IdBarrio.ToString();
			txtCliDire.Text = oCliente.Direccion;
			txtCliTel.Text = oCliente.Telefono;
			txtCliEmail.Text = oCliente.Email;

		}

        private void FrmNuevoEditarCliente_Load(object sender, EventArgs e)
        {

			CargarBarrios();
			CargarLocalidades();
			CargarProvincias();

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



		private void btnAceptar_Click(object sender, EventArgs e)
		{
			List<Parametro> parametro = new List<Parametro>();
			parametro.Add(new Parametro("@id_cliente", oCliente.IdCliente));
			parametro.Add(new Parametro("@nom_cliente", txtCliNombre.Text.ToString()));
			parametro.Add(new Parametro("@ape_cliente", txtCliApellido.Text.ToString()));
			parametro.Add(new Parametro("@dni", int.Parse(txtCliDNI.Text)));
			parametro.Add(new Parametro("@cuil", long.Parse(txtCliCuil.Text)));
			parametro.Add(new Parametro("@direccion" , txtCliDire.Text.ToString()));
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

			private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

        
    }
}
