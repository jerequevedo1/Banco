using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDominio.Entidades
{
    public class Localidad
    {
        public int IdLocalidad { get; set; }
        public string NomLocalidad { get; set; }
        public List<Barrio> lBarrio { get; set; }
        public Localidad(int idLocalidad, string nomLocalidad)
        {
            this.IdLocalidad = idLocalidad;
            this.NomLocalidad = nomLocalidad;
            lBarrio = new List<Barrio>();

        }

        public Localidad()
        {
        }
    }
}
