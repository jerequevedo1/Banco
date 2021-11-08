using BancoPresentacion;
using BancoPresentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoServicios.Interfaces
{
	public interface ICuentaService
	{
		List<Cliente> GetCuentaByFilters(List<Parametro> parametros);
		List<TipoCuenta> GetTipoCuenta();
		bool NuevaCuenta(Cliente oCliente);
		bool NuevaCuentaClienteExist(Cliente oCliente);
		bool ModificarCuenta(Cliente oCliente);
		public Cliente GetCuentaById(int nro);
        int ProximoID();
		bool EliminarCuenta(int id);
    }
}
