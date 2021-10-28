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
		private Form activeForm;

		public FrmConsulta()
		{
			InitializeComponent();
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			panelConsulta.Visible=false;
			OpenChildForm(new FrmNuevo(), sender);
			panelConsulta.Visible = true;
		}
		public void OpenChildForm(Form childForm, object btnSender)
		{

			if (activeForm != null)
			{
				activeForm.Close();
			}
			//ActivateButton(btnSender);
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelConsulta.Controls.Add(childForm);
			this.panelConsulta.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
		private void btnConsultar_Click(object sender, EventArgs e)
		{

		}
	}
}
