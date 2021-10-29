﻿using BancoAccesoDatos.Interfaces;
using BancoDominio;
using BancoDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAccesoDatos.Implementaciones
{
	class CuentaDao : ICuentaDao
	{
		public List<Cuenta> GetCuentaByFilters(List<Parametro> parametros)
		{
            List<Cuenta> lst = new List<Cuenta>();

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

                    Cliente oCliente = new Cliente();
                    oCliente.ApeCliente = row["Apellido"].ToString();
                    oCliente.NomCliente = row["Nombre"].ToString();
                    oCliente.Dni =Convert.ToInt32(row["DNI"].ToString());

                    oCuenta.Cliente = oCliente;
                    oCuenta.TipoCuenta = oTipoCta;                

                    lst.Add(oCuenta);
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