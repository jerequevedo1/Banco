using BancoAccesoDatos;
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
			txtCliCalle.Text = oCliente.Direccion;
			txtCliTel.Text = oCliente.Telefono;
			txtCliEmail.Text = oCliente.Email;

		}

        private void FrmNuevoEditarCliente_Load(object sender, EventArgs e)
        {

			CargarBarrios();
			
        }

        private void CargarBarrios()
        {
			//DataTable tabla = gestorCliente.CargarCombo();

			//cboClienteBarrio.DataSource = tabla;
			//cboClienteBarrio.ValueMember = tabla.Columns[0].ColumnName;
			//cboClienteBarrio.DisplayMember = tabla.Columns[1].ColumnName;
			
		}








        private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

	}
}
