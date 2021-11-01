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

        Cliente GetClienteId(int nro);
       
        List<Cliente> GetClienteByFilters(List<Parametro> parametros);
        List<Cliente> GetClienteByName(List<Parametro> parametro);
        List<Barrio> GetBarrios();
        List<Localidad> GetLocalidades();
        List<Provincia> GetProvincias();
        bool ModificarClienteSQL(List<Parametro> parametros);
    }
}
