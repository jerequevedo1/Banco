using BancoAccesoDatos;
using BancoAccesoDatos.Implementaciones;
using BancoAccesoDatos.Interfaces;
using BancoDominio.Entidades;
using BancoServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoServicios.Implementaciones
{
    public class LoginService : ILoginService
    {
        private IUsuarioDao usuarioDao;

        public LoginService()
        {
            usuarioDao = new UsuarioDao();

        }

        public Usuario GetUsuario(string user, string password)
        {
            
            return  usuarioDao.GetUsuario(user, password);
            
        }
    }
}
