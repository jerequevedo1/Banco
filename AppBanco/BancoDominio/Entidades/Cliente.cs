using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPresentacion.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NomCliente { get; set; }
        public string ApeCliente { get; set; }
        public int Dni { get; set; }
        public long Cuil { get; set; }
        public string Direccion { get; set; }
        public Provincia Provincia { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public List<Cuenta> Cuentas { get; set; }
		public DateTime FechaAlta { get; set; }

		public Cliente(int idCliente, string nomCliente, string apeCliente, int dni, long cuil, string direccion, Provincia provincia, string telefono, string email)
        {
            IdCliente = idCliente;
            NomCliente = nomCliente;
            ApeCliente = apeCliente;
            Dni = dni;
            Cuil = cuil;
            Direccion = direccion;
            Provincia = provincia;
            Telefono = telefono;
            Email = email;
            Cuentas = new List<Cuenta>();
        }


        public Cliente()
        {
            Cuentas = new List<Cuenta>();
            Provincia = new Provincia();
        }

     

		public string NombreCompleto()
		{
			return  ApeCliente+", "+NomCliente;
		}

        public void AgregarCuenta(Cuenta cuenta)
        {
            Cuentas.Add(cuenta);
        }

        public void QuitarCuenta(int indice)
        {
            Cuentas.RemoveAt(indice);
        }


    }
}
