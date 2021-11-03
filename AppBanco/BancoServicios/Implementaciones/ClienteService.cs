using BancoAccesoDatos;
using BancoAccesoDatos.Interfaces;
using BancoPresentacion;
using BancoPresentacion.Entidades;
using BancoServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoServicios.Implementaciones
{
    class ClienteService : IClienteService
    {
        private IClienteDao daoCliente;

        public ClienteService(AbstractDaoFactory factory)
        {
            daoCliente = factory.CrearClienteDao();

        }

        public List<Cliente> GetClienteByFilters(List<Parametro> parametros)
        {
            return daoCliente.GetClienteByFilters(parametros);
        }

        public Cliente GetClienteId(int nro)
        {
            return daoCliente.GetClienteId(nro);
        }
        public List<Cliente> GetClienteByName(List<Parametro> parametro)
        {
            return daoCliente.GetClienteByName(parametro);
        }

        public List<Barrio> GetBarrios()
        {
            return daoCliente.GetBarrios();
        }

        public List<Localidad> GetLocalidades()
        {
           return daoCliente.GetLocalidades();
        }
        public List<Provincia> GetProvincias()
        {
            return daoCliente.GetProvincias();
        }

        public bool ModificarClienteSQL(List<Parametro> parametros)
        {
            return daoCliente.ModificarClienteSQL(parametros);
        }
    }

}
