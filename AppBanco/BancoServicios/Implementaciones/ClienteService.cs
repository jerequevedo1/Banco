using BancoAccesoDatos;
using BancoAccesoDatos.Interfaces;
using BancoDominio;
using BancoDominio.Entidades;
using BancoServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable CargarCombo()
        {
            return daoCliente.CargarCombo();
        }

        public List<Cliente> GetClienteByFilters(List<Parametro> parametros)
        {
            return daoCliente.GetClienteByFilters(parametros);
        }

        public Cliente GetClienteId(int nro)
        {
            return daoCliente.GetClienteId(nro);
        }
    }
}
