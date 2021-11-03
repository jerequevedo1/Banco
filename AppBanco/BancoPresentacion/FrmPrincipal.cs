using BancoDominio.Entidades;
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
	public partial class FrmPrincipal : Form
	{
		private Form activeForm;
		private Tipo tipo;
		private Usuario usuario;
		public FrmPrincipal(Usuario id)
		{
			InitializeComponent();
			this.usuario = id;
		}
		//private void AbrirFormulario<MiForm>() where MiForm : Form, new()
		//{
		//	Form formulario;
		//	formulario = panelChild.Controls.OfType<MiForm>.FirstOrDefault();

		//	if (formulario==null)
		//	{
		//		formulario = new MiForm();
		//		formulario.TopLevel = false;
		//		panelChild.Controls.Add(formulario);
		//		panelChild.Tag = formulario;
		//		formulario.Show();
		//	}
		//	else
		//	{
		//		formulario.BringToFront();
		//	}
		//}
		private void ActivateButton(object sender)
		{

		}
		private void DisableButton()
		{

		}
		public void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
			{
				activeForm.Close();
			}
			ActivateButton(btnSender);
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelChild.Controls.Add(childForm);
			this.panelChild.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			//this.lblTitle.Text = childForm.Text;
		}
		private void btnCuenta_Click(object sender, EventArgs e)
		{
			tipo = Tipo.Cuenta;
			OpenChildForm(new FrmConsulta(tipo), sender);
		}

		private void btnCliente_Click(object sender, EventArgs e)
		{
			tipo = Tipo.Cliente;
			OpenChildForm(new FrmConsulta(tipo), sender); ;
		}

		private void btnTransaccion_Click(object sender, EventArgs e)
		{
			tipo = Tipo.Transaccion;
			OpenChildForm(new FrmConsulta(tipo), sender);
		}



		private void btnSalir_Click(object sender, EventArgs e)
		{

		}

		private void FrmPrincipal_Load(object sender, EventArgs e)
		{
			lblBienvenida.Text = "Bienvenido/a " + usuario.NomUsuario;
		}


		private void btnReportes_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FrmReporte(), sender);
		}

		private void btnConocenos_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FrmConocenos(), sender);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro de abandonar la aplicación?",
			   "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
			   MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				this.Close();
		}
		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		int PosY = 0;
		int PosX = 0;

		private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
			if (e.Button != MouseButtons.Left)
			{
				PosX = e.X;
				PosY = e.Y;
			}
			else
			{
				this.Left = Left + (e.X - PosX);
				this.Top = Top + (e.Y - PosY);
			}
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
