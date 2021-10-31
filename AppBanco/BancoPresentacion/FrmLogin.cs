using BancoDominio.Dto;
using BancoDominio.Entidades;
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
            this.txtUser.AutoSize = false;
            this.txtUser.Size = new Size(338, 20);
            this.txtPass.AutoSize = false;
            this.txtPass.Size = new Size(338, 20);
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
                using (var client = new HttpClient())
                {
                    //System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    client.BaseAddress = new Uri("https://localhost:44304/");

                    UsuarioDto usuario = new UsuarioDto { nombreUsuario = txtUser.Text.ToString(), password = txtPass.Text.ToString() };
                    var response = client.PostAsJsonAsync("api/Login", usuario);
                    //var usuarioLogueado = response.Content.ReadAsAsync<UsuarioDto>();


                    var responseContent = response.Result.Content.ReadAsStringAsync();
                    var user = JsonConvert.DeserializeObject<Usuario>(responseContent.Result);

                    if (user.NomUsuario == txtUser.Text.ToString().Trim())
                    {
                        //logueado OK 
                        //Dispose();
                        this.usuario.IdUsuario= user.IdUsuario;
                        this.usuario.NomUsuario = user.NomUsuario;
                        this.usuario.Pass = user.Pass;
                        //var principal = new FrmPrincipal();
                        //principal.Show();
                        this.Close();
                    }
                    else
                    {
                        this.usuario.IdUsuario = -1;
                        MessageBox.Show("Error sesion");
                        //usuario Rechazado, informar al usuario
                    }

                }
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {

            
            if (Convert.ToInt32(e.KeyChar) == 13)//enter
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
