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
		
		public FrmConsulta()
		{
			InitializeComponent();
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			//	while (FrmPrincipal.ActiveForm.Controls.Count>0)
			//	{

			//	}
			//new FrmPrincipal().OpenChildForm(new FrmNuevo(), sender);
			new FrmNuevo().ShowDialog();
		}
	}
}
