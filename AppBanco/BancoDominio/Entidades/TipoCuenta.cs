using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPresentacion.Entidades
{
    public class TipoCuenta
    {
        public int IdTipoCuenta { get; set; }
        public string DescTipoCuenta { get; set; }
        public TipoCuenta(int idTipoCuenta, string descTipoCuenta)
        {
            IdTipoCuenta = idTipoCuenta;
            DescTipoCuenta = descTipoCuenta;
        }
        public TipoCuenta()
        {
        }
    }
}
