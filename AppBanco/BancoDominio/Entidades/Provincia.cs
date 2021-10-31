using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDominio.Entidades
{
    public class Provincia
    {
        public int IdProvincia { get; set; }
        public string NomProvincia { get; set; }
        public List<Localidad> lLocalidad { get; set; }
        public Provincia(int idProv, string nomProv)
        {
            this.IdProvincia = idProv;
            this.NomProvincia = nomProv;
            this.lLocalidad = new List<Localidad>();
        }



    }
}
