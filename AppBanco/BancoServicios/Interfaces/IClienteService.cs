using BancoDominio;
using BancoDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoServicios.Interfaces
{
    public interface IClienteService
    {
        public List<Cliente> GetClienteByFilters(List<Parametro> parametros);
        public Cliente GetClienteId(int nro);
       
        
    }
}
