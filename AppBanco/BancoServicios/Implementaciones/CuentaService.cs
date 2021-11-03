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
	class CuentaService : ICuentaService
	{
		private ICuentaDao daoCuenta;

		public CuentaService(AbstractDaoFactory factory)
		{
			daoCuenta = factory.CrearCuentaDao();

		}
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

		public bool NuevaCuentaClienteExist(Cliente oCliente)
		{
			return daoCuenta.CreateCuentaClienteExist(oCliente);
		}
		public bool ModificarCuenta(Cliente oCliente)
		{
			return daoCuenta.ModifyCuenta(oCliente);
		}
		public Cliente GetCuentaById(int nro)
		{
			return daoCuenta.GetCuentaById(nro);
		}

        public int ProximoID(string nombreSP)
        {
			return daoCuenta.ProximoID(nombreSP);
		}
    }
}
