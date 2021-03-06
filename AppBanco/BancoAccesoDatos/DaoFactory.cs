using BancoAccesoDatos.Implementaciones;
using BancoAccesoDatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAccesoDatos
{
    public class DaoFactory : AbstractDaoFactory
    {

        public override IClienteDao CrearClienteDao()
        {
            return new ClienteDao();
        }
        public override ICuentaDao CrearCuentaDao()
		{
            return new CuentaDao();
		}

		public override ITransaccionDao CrearTransaccionDao()
		{
			return new TransaccionDao();
		}
	}
}
