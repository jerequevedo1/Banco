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

        //public ClienteService(AbstractDaoFactory factory)
        //{
        //    daoCliente = factory.CrearClienteDao();

        //}
        public ClienteService()
        {
            daoCliente = new DaoFactory().CrearClienteDao();

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

        public List<Barrio> GetBarrios(List<Parametro> parametro)
        {
            return daoCliente.GetBarrios(parametro);
        }

        public List<Localidad> GetLocalidades(List<Parametro> parametro)
        {
           return daoCliente.GetLocalidades(parametro);
        }
        public List<Provincia> GetProvincias()
        {
            return daoCliente.GetProvincias();
        }

        public bool ModificarClienteSQL(List<Parametro> parametros)
        {
            return daoCliente.ModificarClienteSQL(parametros);
        }

        public bool ActualizarSQL(string nombreSP, Parametro p)
        {
            return daoCliente.ActualizarSQL(nombreSP, p);
        }

        public int ProximoID()
        {
            return daoCliente.ProximoID();
        }
    }

}
