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
	class CuentaService : ICuentaService
	{
		private ICuentaDao daoCuenta;

		public CuentaService(AbstractDaoFactory factory)
		{
			daoCuenta = factory.CrearCuentaDao();

		}
		//public List<Cuenta> GetCuentaByFilters(List<Parametro> parametros)
		//{
		//	return daoCuenta.GetCuentaByFilters(parametros);
		//}
		public List<Cliente> GetCuentaByFilters(List<Parametro> parametros)
		{
			return daoCuenta.GetCuentaByFilters(parametros);
		}

		public List<TipoCuenta> GetTipoCuenta()
		{
			return daoCuenta.GetTipoCuenta();
		}

		public bool NuevaCuenta(Cliente oCliente)
		{
			return daoCuenta.CreateCuenta(oCliente);
		}
	}
}
