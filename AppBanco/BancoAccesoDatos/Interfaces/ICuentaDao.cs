using BancoDominio;
using BancoDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAccesoDatos.Interfaces
{
	public interface ICuentaDao
	{
		//List<Cuenta> GetCuentaByFilters(List<Parametro> parametros);
		List<Cliente> GetCuentaByFilters(List<Parametro> parametros);
		List<TipoCuenta> GetTipoCuenta();
		bool CreateCuenta(Cliente oCliente);
	}
}
