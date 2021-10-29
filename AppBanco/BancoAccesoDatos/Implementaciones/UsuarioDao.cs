using BancoAccesoDatos.Interfaces;
using BancoDominio;
using BancoDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAccesoDatos.Implementaciones
{
    public class UsuarioDao : IUsuarioDao
    {
        public Usuario GetUsuario(string user, string password)
        {
            var usuario = new Usuario();
            var parametros = new List<Parametro>();
            //añadimos los parametros para el SP 
            parametros.Add(new Parametro() { Nombre = "usuario", Valor = user });
            parametros.Add(new Parametro() { Nombre = "password", Valor = password });

            //controlar si el usuario existe en la base}
            DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametros("[SP_CONSULTAR_USUARIO]", parametros);
            if (tabla != null && tabla.Rows.Count > 0)
            {
                //existe el usuario
                return new Usuario() { IdUsuario = (int)tabla.Rows[0]["id_usuario"], NomUsuario = tabla.Rows[0]["usuario"].ToString(), Pass = tabla.Rows[0]["contrasenia"].ToString() };
            }
            return null; // no existe el usuario
        }
    }
}
