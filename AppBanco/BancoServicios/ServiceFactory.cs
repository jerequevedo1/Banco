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
    public class ServiceFactory : AbstractServiceFactory

    {
        public override ILoginService CrearLoginService()
        {
            return new LoginService();
        }

  //      public override IClienteService CrearClienteService(AbstractDaoFactory factory)
  //      {
  //          return new ClienteService(factory);
  //      }
  //      public override ICuentaService CrearCuentaService(AbstractDaoFactory factory)
  //      {
  //          return new CuentaService(factory);
  //      }

		//public override ITransaccionService CrearTransaccionService(AbstractDaoFactory factory)
		//{
  //          return new TransaccionService(factory);

  //      }
        public override IClienteService CrearClienteService()
        {
            return new ClienteService();
        }
        public override ICuentaService CrearCuentaService()
        {
            return new CuentaService();
        }

        public override ITransaccionService CrearTransaccionService()
        {
            return new TransaccionService();

        }
    }
}
