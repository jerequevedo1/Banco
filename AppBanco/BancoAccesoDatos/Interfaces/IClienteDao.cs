using BancoDominio;
using BancoDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAccesoDatos.Interfaces
{
    public interface IClienteDao
    {
        List<Cliente> GetClienteByFilters(List<Parametro> parametros);

        Cliente GetClienteId(int nro);

        List<Cliente> GetClienteByName(List<Parametro> parametros);
        List<Barrio> GetBarrios();
        List<Localidad> GetLocalidades();
        List<Provincia> GetProvincias();
        bool ModificarClienteSQL(List<Parametro> parametros);
    }
}
