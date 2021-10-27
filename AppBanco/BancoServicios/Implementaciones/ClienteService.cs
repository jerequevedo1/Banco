using BancoAccesoDatos;
using BancoAccesoDatos.Interfaces;
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
        private IDao daoCliente;

        public ClienteService(AbstractDaoFactory factory)
        {
            daoCliente = factory.CrearClienteDao();

        }

    }
}
