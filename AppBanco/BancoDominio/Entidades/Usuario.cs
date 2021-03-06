using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPresentacion.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string Pass { get; set; }
        public Usuario(int idUsuario, string nomUsuario, string pass)
        {
            IdUsuario = idUsuario;
            NomUsuario = nomUsuario;
            Pass = pass;
        }
        public Usuario()
        {
            IdUsuario = -1;
            NomUsuario = string.Empty;
            Pass = string.Empty;
        }
    }
}
