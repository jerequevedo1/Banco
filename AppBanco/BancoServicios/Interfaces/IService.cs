using BancoDominio;
using BancoDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoServicios.Interfaces
{
    public interface IService
    {

        public List<Cliente> GetByFiltersCliente(List<Parametro> parametros);
    }
}
