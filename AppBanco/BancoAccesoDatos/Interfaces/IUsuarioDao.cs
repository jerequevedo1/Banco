using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoPresentacion.Entidades;

namespace BancoAccesoDatos.Interfaces
{
    public interface IUsuarioDao
    {
       Usuario GetUsuario(string user, string password);
    }
}
