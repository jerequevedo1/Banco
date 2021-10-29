using BancoAccesoDatos;
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
    class ClienteService: IService
    {
        private IClienteDao daoCliente;

        public ClienteService(AbstractDaoFactory factory)
        {
            daoCliente = factory.CrearClienteDao();

        }

        public List<Cliente> GetByFiltersCliente(List<Parametro> parametros)
        {
            return daoCliente.GetByFiltersCliente(parametros);
        }
    }
}
