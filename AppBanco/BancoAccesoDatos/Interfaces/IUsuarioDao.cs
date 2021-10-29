using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDominio.Entidades;

namespace BancoAccesoDatos.Interfaces
{
    public interface IUsuarioDao
    {
       Usuario GetUsuario(string user, string password);
    }
}
