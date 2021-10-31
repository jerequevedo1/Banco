using BancoDominio;
using BancoDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAccesoDatos.Interfaces
{
    public interface IClienteDao
    {
        List<Cliente> GetClienteByFilters(List<Parametro> parametros);
        List<Cliente> GetClienteByName(List<Parametro> parametro);

    }
}
