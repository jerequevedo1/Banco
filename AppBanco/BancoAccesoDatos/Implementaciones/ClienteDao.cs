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
    class ClienteDao :IDao
    {
        public List<Cliente> GetByFiltersCliente(List<Parametro> parametros)
        {

            List<Cliente> lst = new List<Cliente>();

            try
            {
                DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametros("PA_CONSULTA_CLIENTE_FILTRO", parametros);

                foreach (DataRow row in tabla.Rows)
                {
                    Cliente oCliente = new Cliente();

                    oCliente.IdCliente= Convert.ToInt32(row["ID Cliente"].ToString());
                    oCliente.NomCliente = row["Nombre"].ToString();
                    oCliente.ApeCliente = row["Apellido"].ToString();
                    oCliente.Direccion = row["Direccion"].ToString();
                    oCliente.Dni = Convert.ToInt32(row["DNI"].ToString());
                    oCliente.Telefono = row["Telefono"].ToString(); 
                    oCliente.Email = row["Email"].ToString();

                    if (!row["fechaB"].Equals(DBNull.Value))
                    {
                        //aca se agrega el campo si existe fecha de baja, dejo a modo ejemplo hasta que agreguemos esto en bd
                        //oPedido.FechaBaja = Convert.ToDateTime(row["fecha_baja"].ToString());
                    }

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
