using BancoDominio;
using BancoDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoServicios.Interfaces
{
    public interface IClienteService
    {
        List<Cliente> GetClienteByFilters(List<Parametro> parametros);
        List<Cliente> GetClienteByName(List<Parametro> parametro);
    }
}
