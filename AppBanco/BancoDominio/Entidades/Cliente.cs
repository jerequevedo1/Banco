using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDominio.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NomCliente { get; set; }
        public string ApeCliente { get; set; }
        public int Dni { get; set; }
        public int Cuil { get; set; }
        public string Direccion { get; set; }
        public Barrio Barrio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Cliente(int idCliente, string nomCliente, string apeCliente, int dni, int cuil, string direccion, Barrio barrio, string telefono, string email)
        {
            IdCliente = idCliente;
            NomCliente = nomCliente;
            ApeCliente = apeCliente;
            Dni = dni;
            Cuil = cuil;
            Direccion = direccion;
            Barrio = barrio;
            Telefono = telefono;
            Email = email;
        }

        public Cliente()
        {
        }
		public string NombreCompleto()
		{
			return  ApeCliente+", "+NomCliente;
		}
	}
}
