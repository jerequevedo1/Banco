using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDominio.Entidades
{
    public class Transaccion
    {
        public int IdTransac { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public TipoTransaccion TipoTransac { get; set; }


        public Transaccion(int idTransac, DateTime fecha, double monto, TipoTransaccion tipoTransac)
        {
            this.IdTransac = IdTransac;
            Fecha = fecha;
            Monto = monto;
            TipoTransac = tipoTransac;

        }

    }
}
