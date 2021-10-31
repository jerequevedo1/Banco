using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDominio
{
	public class Enumeraciones
	{
		public enum Tipo
		{
			Cuenta,
			Cliente,
			Transaccion,
			Configuracion
		}

		public enum Accion
        {
			Create,
			Read,
			Update,
			Delete
        }
	}
}
