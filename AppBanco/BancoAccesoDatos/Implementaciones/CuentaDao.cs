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
using static BancoPresentacion.Enumeraciones;

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

		public bool CreateCuentaClienteExist(Cliente oCliente)
		{
            List<Parametro> lst = new List<Parametro>();

			foreach (Cuenta item in oCliente.Cuentas)
			{
                int i = 0;
                lst.Add(new Parametro("@cbu", oCliente.Cuentas[i].Cbu));
                lst.Add(new Parametro("@alias", oCliente.Cuentas[i].Alias));
                lst.Add(new Parametro("@saldo_actual", oCliente.Cuentas[i].Saldo));
                lst.Add(new Parametro("@limite_descubierto", oCliente.Cuentas[i].LimiteDescubierto));
                lst.Add(new Parametro("@id_cliente", oCliente.IdCliente));
                lst.Add(new Parametro("@id_tipo_cuenta", oCliente.Cuentas[i].TipoCuenta.IdTipoCuenta));
                lst.Add(new Parametro("@tipo_moneda", oCliente.Cuentas[i].TipoMoneda));
                i++;
            }
           
            bool resultado = true;

            resultado = HelperDao.ObtenerInstancia().ModificarSQL("PA_INSERTAR_CUENTA",lst);

            return resultado;
		}

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
                    oTipoCta.IdTipoCuenta = Convert.ToInt32(row["id_tipo_cuenta"].ToString());
                    oTipoCta.DescTipoCuenta = row["descripcion"].ToString();


                    oCuenta.TipoCuenta = oTipoCta;

                    Cliente oCliente = new Cliente();
                    oCliente.IdCliente= Convert.ToInt32(row["id_cliente"].ToString());
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

		public bool ModifyCuenta(Cliente oCliente)
		{
            bool resultado = true;
            
            List<Parametro> lst = new List<Parametro>();

            foreach (Cuenta item in oCliente.Cuentas)
            {
                int i = 0;
                lst.Add(new Parametro("@id_cuenta", oCliente.Cuentas[i].IdCuenta));
                lst.Add(new Parametro("@cbu", oCliente.Cuentas[i].Cbu));
                lst.Add(new Parametro("@alias", oCliente.Cuentas[i].Alias));
                lst.Add(new Parametro("@saldo_actual", oCliente.Cuentas[i].Saldo));
                lst.Add(new Parametro("@limite_descubierto", oCliente.Cuentas[i].LimiteDescubierto));
                lst.Add(new Parametro("@id_cliente", oCliente.IdCliente));
                lst.Add(new Parametro("@id_tipo_cuenta", oCliente.Cuentas[i].TipoCuenta.IdTipoCuenta));
                lst.Add(new Parametro("@tipo_moneda", oCliente.Cuentas[i].TipoMoneda));
                //i++;
            }

            resultado = HelperDao.ObtenerInstancia().ModificarSQL("PA_EDITAR_CUENTA", lst);

            
            return resultado;
        }
	}
}
