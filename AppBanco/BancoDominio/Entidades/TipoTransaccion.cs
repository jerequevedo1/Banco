using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDominio.Entidades
{
    public class TipoTransaccion
    {
        public int IdTipoTransac { get; set; }
        public string Descripcion { get; set; }
        public TipoTransaccion(int idTipoTransac, string descripcion)
        {
            IdTipoTransac = idTipoTransac;
            Descripcion = descripcion;
        }
        public TipoTransaccion()
		{

		}
    }
}
