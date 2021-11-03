using BancoAccesoDatos.Interfaces;
using BancoPresentacion;
using BancoPresentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAccesoDatos.Implementaciones
{
	class TransaccionDao : ITransaccionDao
	{
		public List<Cliente> GetTransacciones(List<Parametro> parametros)
		{
            List<Cliente> lst = new List<Cliente>();

            try
            {
                //cuando tenga parametros usamos ese metodo
                DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametros("PA_CONSULTA_TRANSACCIONES", parametros);
                //DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQL("PA_CONSULTA_TRANSACCIONES");

                foreach (DataRow row in tabla.Rows)
                {
                    Transaccion oTransaccion = new Transaccion();
                    Cuenta oCuenta = new Cuenta();
                    Cliente oCliente = new Cliente();

                    oTransaccion.IdTransac = Convert.ToInt32(row["id_transaccion"].ToString());
                    oTransaccion.Fecha = Convert.ToDateTime(row["fecha"].ToString());
                    oCuenta.IdCuenta = Convert.ToInt32(row["id_cuenta"].ToString());
                    oCliente.ApeCliente = row["ape_cliente"].ToString();
                    oCliente.NomCliente = row["nom_cliente"].ToString();
                    oTransaccion.Monto = Convert.ToDouble(row["monto"].ToString());
                    oTransaccion.TipoTransac.Descripcion = row["descripcion"].ToString();

                    oCuenta.CrearTransaccion(oTransaccion);
                    oCliente.AgregarCuenta(oCuenta);
                   

                    lst.Add(oCliente);
                }
            }
            catch (SqlException)
            {
                lst = null;
            }
            return lst;

        }
	}
}
