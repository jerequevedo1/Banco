using BancoAccesoDatos;
using BancoAccesoDatos.Interfaces;
using BancoPresentacion;
using BancoPresentacion.Entidades;
using BancoServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoServicios.Implementaciones
{
	class TransaccionService : ITransaccionService
	{
		private ITransaccionDao daoTrans;

		public TransaccionService(AbstractDaoFactory factory)
		{
			daoTrans = factory.CrearTransaccionDao();
		}
		public List<Cliente> GetTransacciones(List<Parametro> filtros)
		{
			return daoTrans.GetTransacciones(filtros);
		}
	}
}
