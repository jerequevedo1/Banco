using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPresentacion.Entidades
{
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public string Cbu { get; set; }
        public string Alias { get; set; }
        public double Saldo { get; set; }
        public List<Transaccion> Ltransaccion { get; set; }
        public string UltiMovi { get; set; }
        public double SaldoDescubierto { get; set; }
        public TipoCuenta TipoCuenta { get; set; }
        public string TipoMoneda { get; set; }
		public DateTime FechaBaja { get; set; }
		public DateTime FechaAlta { get; set; }
        public double LimiteDescubierto { get; set; }

		public Cuenta(int idCuenta, string cbu, string alias, double saldo, string ultiMovi, int saldoDescubierto, 
                        TipoCuenta tipoCuenta, string tipoMoneda,double limiteDescubierto,DateTime fechaBaja, DateTime fechaAlta)
        {
            IdCuenta = idCuenta;
            Cbu = cbu;
            Alias = alias;
            Saldo = saldo;
            UltiMovi = ultiMovi;
            Ltransaccion = new List<Transaccion>();
            SaldoDescubierto = saldoDescubierto;
            TipoCuenta = tipoCuenta;
            TipoMoneda = tipoMoneda;
            LimiteDescubierto = limiteDescubierto;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
        }

        public Cuenta()
        {
            TipoCuenta = new TipoCuenta();
            Ltransaccion = new List<Transaccion>();
        }
        public void CrearTransaccion(Transaccion transaccion)
		{
            Ltransaccion.Add(transaccion);
		}
        public string GetFechaBajaFormato()
        {
            string aux = FechaBaja.ToString("dd/MM/yyyy");
            //return aux.Equals("01/01/0001") ? "" : aux;
            return aux.Equals("01/01/0001") ? "Activo" : "Inactivo";
        }
    }
}
