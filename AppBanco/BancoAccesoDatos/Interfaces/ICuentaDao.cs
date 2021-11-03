using BancoPresentacion;
using BancoPresentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAccesoDatos.Interfaces
{
	public interface ICuentaDao
	{
		List<Cliente> GetCuentaByFilters(List<Parametro> parametros);
		List<TipoCuenta> GetTipoCuenta();
		bool CreateCuenta(Cliente oCliente);
		bool CreateCuentaClienteExist(Cliente oCliente);

		bool ModifyCuenta(Cliente oCliente);
	}
}
