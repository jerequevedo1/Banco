using BancoPresentacion;
using BancoPresentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoServicios.Interfaces
{
	public interface ITransaccionService
	{
		List<Cliente> GetTransacciones(List<Parametro> filtros);
	}
}
