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

	public partial class FrmConsultaCliente : Form
	{
		//public Accion modo;
		private IClienteService gestorCliente;
		private List<Parametro> parametro;
		private List<Cliente> lst;
		private int nro;
		public FrmConsultaCliente(List<Parametro> parametro)
		{   
			InitializeComponent();
			this.parametro = parametro;
			lst = new List<Cliente>();
			gestorCliente = new ServiceFactory().CrearClienteService(new DaoFactory());
			
		}


        private void FrmNuevoEditarCliente_Load(object sender, EventArgs e)
        {

			CargarClientes();

		}

		private void CargarClientes()
		{
			lst = gestorCliente.GetClienteByName(parametro);

			dgvClientes.Rows.Clear();
			foreach (Cliente item in lst)
			{
				dgvClientes.Rows.Add(new object[] { item.IdCliente.ToString(), item.NombreCompleto(), item.Dni, item.Email });
			}
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvClientes.CurrentCell.ColumnIndex == 4)
			{
				nro = int.Parse(dgvClientes.CurrentRow.Cells["cId"].Value.ToString());
				Close();
			}
		}
		public int GetNroCliente()
		{
			return nro;
		}
		private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			nro = int.Parse(dgvClientes.CurrentRow.Cells["cId"].Value.ToString());
			this.Close();
		}

		private void btnAceptar_Click_1(object sender, EventArgs e)
		{
			if (dgvClientes.Rows.Count>0)
			{
				nro = int.Parse(dgvClientes.CurrentRow.Cells["cId"].Value.ToString());
			}
			else
			{
				MessageBox.Show("No se encontraron resultados.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			this.Close();
		}

		private void btnCancelar_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
