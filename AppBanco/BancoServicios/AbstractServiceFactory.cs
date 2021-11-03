using BancoAccesoDatos;
using BancoServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoServicios
{
    public abstract class AbstractServiceFactory
    {
      public abstract IClienteService CrearClienteService(AbstractDaoFactory factory);
      public abstract ILoginService CrearLoginService();
      public abstract ICuentaService CrearCuentaService(AbstractDaoFactory factory);
      public abstract ITransaccionService CrearTransaccionService(AbstractDaoFactory factory);

    }
}
