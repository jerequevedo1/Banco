using BancoDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoPresentacion
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		/// 
		[STAThread]
		static void Main()
		{
			Usuario usuario = new Usuario();

			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new FrmLogin(usuario));
			Application.Run(new FrmPrincipal(usuario));

			if (usuario.IdUsuario != -1)
			{
				Application.Run(new FrmPrincipal(usuario));
			}
			
		}
	}
}
