using BancoAccesoDatos;
using BancoServicios.Implementaciones;
using BancoServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoServicios
{
    class ServiceFactory : AbstractServiceFactory
    {
        public override IService CrearService(AbstractDaoFactory factory)
        {
            return new ClienteService(factory);
        }
    }
}
