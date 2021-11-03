using BancoPresentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoServicios.Interfaces
{
    public interface ILoginService
    {
        Usuario GetUsuario(string user, string password);
    }
}
