using BancoAccesoDatos.Interfaces;
using BancoDominio;
using BancoDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BancoDominio.Enumeraciones;

namespace BancoAccesoDatos.Implementaciones
{
	class CuentaDao : ICuentaDao
	{
		public bool CreateCuenta(Cliente oCliente)
		{
            bool resultado = true;
            int filasAfectadas = 0;

            filasAfectadas = HelperDao.ObtenerInstancia().EjecutarSQLMaestroDetalle("PA_INSERTAR_CLIENTE", "PA_INSERTAR_CUENTA", oCliente, Accion.Create);

            if (filasAfectadas == 0) resultado = false;

            return resultado;
        }

		//public List<Cuenta> GetCuentaByFilters(List<Parametro> parametros)
		//{
  //          List<Cuenta> lst = new List<Cuenta>();

  //          try
  //          {
  //              DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametros("PA_CONSULTA_CUENTA_FILTRO", parametros);

  //              foreach (DataRow row in tabla.Rows)
  //              {
  //                  Cuenta oCuenta = new Cuenta();

  //                  oCuenta.IdCuenta = Convert.ToInt32(row["ID Cuenta"].ToString());
  //                  oCuenta.Cbu = row["Cbu"].ToString();
  //                  oCuenta.Alias = row["Alias"].ToString();
  //                  oCuenta.Saldo = Convert.ToDouble(row["saldo"].ToString());
  //                  oCuenta.TipoMoneda = row["Tipo Moneda"].ToString();
  //                  if (!row["fechaBaja"].Equals(DBNull.Value))
  //                  {
  //                      oCuenta.FechaBaja = Convert.ToDateTime(row["fechaBaja"]);
  //                  }
  //                  oCuenta.FechaAlta = Convert.ToDateTime(row["fechaAlta"].ToString());

  //                  TipoCuenta oTipoCta = new TipoCuenta();
  //                  oTipoCta.DescTipoCuenta = row["descripcion"].ToString();

  //                  Cliente oCliente = new Cliente();
  //                  oCliente.ApeCliente = row["Apellido"].ToString();
  //                  oCliente.NomCliente = row["Nombre"].ToString();
  //                  oCliente.Dni =Convert.ToInt32(row["DNI"].ToString());

  //                  oCuenta.Cliente = oCliente;
  //                  oCuenta.TipoCuenta = oTipoCta;                

  //                  lst.Add(oCuenta);
  //              }
  //          }
  //          catch (SqlException)
  //          {
  //              lst = null;
  //          }
  //          return lst;
  //      }
        public List<Cliente> GetCuentaByFilters(List<Parametro> parametros)
        {
            List<Cliente> lst = new List<Cliente>();

            try
            {
                DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametros("PA_CONSULTA_CUENTA_FILTRO", parametros);

                foreach (DataRow row in tabla.Rows)
                {
                    Cuenta oCuenta = new Cuenta();

                    oCuenta.IdCuenta = Convert.ToInt32(row["ID Cuenta"].ToString());
                    oCuenta.Cbu = row["Cbu"].ToString();
                    oCuenta.Alias = row["Alias"].ToString();
                    oCuenta.Saldo = Convert.ToDouble(row["saldo"].ToString());
                    oCuenta.TipoMoneda = row["Tipo Moneda"].ToString();
                    if (!row["fechaBaja"].Equals(DBNull.Value))
                    {
                        oCuenta.FechaBaja = Convert.ToDateTime(row["fechaBaja"]);
                    }
                    oCuenta.FechaAlta = Convert.ToDateTime(row["fechaAlta"].ToString());

                    TipoCuenta oTipoCta = new TipoCuenta();
                    oTipoCta.DescTipoCuenta = row["descripcion"].ToString();


                    oCuenta.TipoCuenta = oTipoCta;

                    Cliente oCliente = new Cliente();
                    oCliente.ApeCliente = row["Apellido"].ToString();
                    oCliente.NomCliente = row["Nombre"].ToString();
                    oCliente.Dni = Convert.ToInt32(row["DNI"].ToString());

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
        public List<TipoCuenta> GetTipoCuenta()
		{
            List<TipoCuenta> lst = new List<TipoCuenta>();
            DataTable table = HelperDao.ObtenerInstancia().ConsultaSQL("PA_CONSULTA_TIPO_CUENTA");

			foreach (DataRow row in table.Rows)
			{
                TipoCuenta oTipoCuenta = new TipoCuenta();
                oTipoCuenta.IdTipoCuenta= Convert.ToInt32(row["id_tipo_cuenta"].ToString());
                oTipoCuenta.DescTipoCuenta = row["descripcion"].ToString();
                lst.Add(oTipoCuenta);
            }

            return lst;
		}
	}
}
