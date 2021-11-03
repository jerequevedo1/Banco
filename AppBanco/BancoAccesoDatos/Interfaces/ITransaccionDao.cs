using BancoDominio;
using BancoDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAccesoDatos.Interfaces
{
	public interface ITransaccionDao
	{
		List<Cliente> GetTransacciones(List<Parametro> filtros);
	}
}
