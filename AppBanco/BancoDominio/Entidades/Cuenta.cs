using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDominio.Entidades
{
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public int Cbu { get; set; }
        public string Alias { get; set; }
        public double Saldo { get; set; }
        public List<Transaccion> Ltransaccion { get; set; }
        public int SaldoDescubierto { get; set; }
        public Cliente Cliente { get; set; }
        public TipoCuenta TipoCuenta { get; set; }
        public string TipoMoneda { get; set; }
        public Cuenta(int idCuenta, int cbu, string alias, double saldo, int saldoDescubierto, Cliente cliente,
                        TipoCuenta tipoCuenta, string tipoMoneda)
        {
            IdCuenta = idCuenta;
            Cbu = cbu;
            Alias = alias;
            Saldo = saldo;
            Ltransaccion = new List<Transaccion>();
            SaldoDescubierto = saldoDescubierto;
            Cliente = cliente;
            TipoCuenta = tipoCuenta;
            TipoMoneda = tipoMoneda;
        }
    }
}
