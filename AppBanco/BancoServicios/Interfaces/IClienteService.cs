using BancoPresentacion;
using BancoPresentacion.Entidades;
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
        List<Barrio> GetBarrios(List<Parametro> parametro);
        List<Localidad> GetLocalidades(List<Parametro> parametro);
        List<Provincia> GetProvincias();
        bool ModificarClienteSQL(List<Parametro> parametros);
        bool ActualizarSQL(string nombreSP, Parametro p);
    }
}
