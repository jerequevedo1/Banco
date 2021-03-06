using BancoAccesoDatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAccesoDatos
{
    public abstract class AbstractDaoFactory
    {
        public abstract IClienteDao CrearClienteDao();
        public abstract ICuentaDao CrearCuentaDao();
        public abstract ITransaccionDao CrearTransaccionDao();

    }
}
