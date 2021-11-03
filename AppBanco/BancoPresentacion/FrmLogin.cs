using BancoPresentacion.Dto;
using BancoPresentacion.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoPresentacion
{
    public partial class FrmLogin : Form
    {
        Usuario usuario;
        public FrmLogin(Usuario id)
        {
            InitializeComponent();
            //Se cambia tamaño de txt por defecto
            this.txtUser.AutoSize = false;
            this.txtUser.Size = new Size(338, 20);
            this.txtPass.AutoSize = false;
            this.txtPass.Size = new Size(338, 20);
            //Se muestra encriptada contraseña de login al colocarla en el txt
            this.txtPass.UseSystemPasswordChar = true;
            this.usuario = id;

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

     
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.ToString().Trim() != "" && txtPass.Text.ToString().Trim() != "")
            {
                //Peticion HTTP
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44304/");

                    UsuarioDto usuario = new UsuarioDto { nombreUsuario = txtUser.Text.ToString(), password = txtPass.Text.ToString() };
                    var response = client.PostAsJsonAsync("api/Login", usuario);
                   
                    var responseContent = response.Result.Content.ReadAsStringAsync();
                    var user = JsonConvert.DeserializeObject<Usuario>(responseContent.Result);

                    if (user.NomUsuario == txtUser.Text.ToString().Trim())
                    {
                        //Usuario logueado OK 
                        this.usuario.IdUsuario= user.IdUsuario;
                        this.usuario.NomUsuario = user.NomUsuario;
                        this.usuario.Pass = user.Pass;
                        this.Close();
                    }
                    else
                    {
                        //Usuario Rechazado, informar al usuario
                        this.usuario.IdUsuario = -1;
                        MessageBox.Show("Usuario o Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
			else
			{
                MessageBox.Show("Ingrese Usuario y Contraseña por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita enter para confirmar inicio de sesión
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

        int PosY = 0;
        int PosX = 0;
        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                PosX = e.X;
                PosY = e.Y;
            }
            else
            {
                Left = Left + (e.X - PosX);
                Top = Top + (e.Y - PosY);
            }

        }
       
    }
}
