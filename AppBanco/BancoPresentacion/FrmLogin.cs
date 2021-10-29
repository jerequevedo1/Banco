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
        public FrmLogin()
        {
            InitializeComponent();
            this.txtUser.AutoSize = false;
            this.txtUser.Size = new Size(338, 20);
            this.txtPass.AutoSize = false;
            this.txtPass.Size = new Size(338, 20);
            this.txtPass.UseSystemPasswordChar = true;
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
                        var principal = new FrmPrincipal();
                        principal.Show();
                    }
                    else
                    { 
                        //usuario Rechazado, informar al usuario
                    }

                }
            }
        }
    }
}
