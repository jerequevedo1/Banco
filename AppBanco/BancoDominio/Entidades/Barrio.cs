using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDominio.Entidades
{
    public class Barrio
    {
        public int IdBarrio { get; set; }
        public string NomBarrio { get; set; }
        public Barrio(int idBarrio, string nomBarrio)
        {
            IdBarrio = idBarrio;
            NomBarrio = nomBarrio;
        }
    }
}
