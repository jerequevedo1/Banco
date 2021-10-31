﻿using BancoAccesoDatos;
using BancoAccesoDatos.Interfaces;
using BancoDominio;
using BancoDominio.Entidades;
using BancoServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoServicios.Implementaciones
{
    class ClienteService: IClienteService
    {
        private IClienteDao daoCliente;

        public ClienteService(AbstractDaoFactory factory)
        {
            daoCliente = factory.CrearClienteDao();

        }

        public List<Cliente> GetClienteByFilters(List<Parametro> parametros)
        {
            return daoCliente.GetClienteByFilters(parametros);
        }

		public List<Cliente> GetClienteByName(List<Parametro> parametro)
		{
            return daoCliente.GetClienteByName(parametro);
		}
	}
}
