using BancoAccesoDatos.Interfaces;
using BancoPresentacion;
using BancoPresentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAccesoDatos.Implementaciones
{
	class ClienteDao:IClienteDao
	{

        public List<Cliente> GetClienteByFilters(List<Parametro> parametros)
        {

            List<Cliente> lst = new List<Cliente>();

            try
            {
                DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametros("PA_CONSULTA_CLIENTE_FILTRO", parametros);

                foreach (DataRow row in tabla.Rows)
                {
                    Cliente oCliente = new Cliente();

                    oCliente.IdCliente = Convert.ToInt32(row["ID Cliente"].ToString());
                    oCliente.NomCliente = row["Nombre"].ToString();
                    oCliente.ApeCliente = row["Apellido"].ToString();
                    oCliente.Direccion = row["Direccion"].ToString();
                    oCliente.Dni = Convert.ToInt32(row["DNI"].ToString());
                    oCliente.Telefono = row["Telefono"].ToString();
                    oCliente.Email = row["Email"].ToString();

                   // oCliente.FechaAlta=Convert.ToDateTime( row["Email"].ToString());
                    if (!row["fechaBaja"].Equals(DBNull.Value))
                    {
                        //aca se agrega el campo si existe fecha de baja, dejo a modo ejemplo hasta que agreguemos esto en bd
                        //oPedido.FechaBaja = Convert.ToDateTime(row["fecha_baja"].ToString());
                    }

                    lst.Add(oCliente);
                }
            }
            catch (SqlException)
            {
                lst = null;
            }
            return lst;
        }

        public Cliente GetClienteId(int nro)
        {
            //HelperDao helper = HelperDao.ObtenerInstancia();
            //return helper.GetClienteId(nro);
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@nro", nro));
            Cliente oCliente = new Cliente();
            Provincia p = new Provincia();
            Localidad l = new Localidad();
            Barrio b = new Barrio();

            try
            {
                DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametros("SP_CONSULTAR_CLIENTE_POR_ID", parametros);

                foreach (DataRow row in tabla.Rows)
                {


                    oCliente.IdCliente = Convert.ToInt32(row["id_cliente"].ToString());
                    oCliente.NomCliente = row["nom_cliente"].ToString();
                    oCliente.ApeCliente = row["ape_cliente"].ToString();
                    oCliente.Direccion = row["direccion"].ToString();
                    oCliente.Cuil = long.Parse(row["cuil"].ToString());
                    oCliente.Dni = Convert.ToInt32(row["dni"].ToString());
                    oCliente.Telefono = row["telefono"].ToString();
                    oCliente.Email = row["email"].ToString();

                    
                    b.IdBarrio = Convert.ToInt32(row["id_barrio"].ToString());
                    l.AgregarBarrio(b);
                    
                    l.IdLocalidad= Convert.ToInt32(row["id_localidad"].ToString());
                    p.AgregarLocalidad(l);

                    p.IdProvincia = Convert.ToInt32(row["id_provincia"].ToString());
                    oCliente.Provincia = p;
                }

            }
            catch (SqlException)
            {
                oCliente = null;
            }
            return oCliente;
        }

        public List<Cliente> GetClienteByName(List<Parametro> parametro)
        {
            List<Cliente> lst = new List<Cliente>();
            Provincia p = new Provincia();
            Localidad l = new Localidad();
            Barrio b = new Barrio();

            try
            {
                DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametros("PA_CONSULTA_CLIENTE_SIMPLE", parametro);

                foreach (DataRow row in tabla.Rows)
                {
                    Cliente oCliente = new Cliente();

                    oCliente.IdCliente = Convert.ToInt32(row["id_cliente"].ToString());
                    oCliente.NomCliente = row["nom_cliente"].ToString();
                    oCliente.ApeCliente = row["ape_cliente"].ToString();
                    oCliente.Dni = Convert.ToInt32(row["dni"].ToString());
                    oCliente.Cuil = long.Parse(row["cuil"].ToString());
                    oCliente.Direccion = row["direccion"].ToString();
                    oCliente.Telefono = row["telefono"].ToString();
                    oCliente.Email = row["email"].ToString();

                    b.IdBarrio = Convert.ToInt32(row["id_barrio"].ToString());
                    l.AgregarBarrio(b);

                    l.IdLocalidad = Convert.ToInt32(row["id_localidad"].ToString());
                    p.AgregarLocalidad(l);

                    p.IdProvincia = Convert.ToInt32(row["id_provincia"].ToString());

                    oCliente.Provincia = p;

                    lst.Add(oCliente);
                }
            }
            catch (SqlException)
            {
                lst = null;
            }
            return lst;
        }

        public List<Barrio> GetBarrios(List<Parametro> parametro)
        {
            List<Barrio> lst = new List<Barrio>();

            DataTable table = HelperDao.ObtenerInstancia().ConsultaSQLParametros("SP_CONSULTAR_BARRIOS", parametro);

            foreach (DataRow row in table.Rows)
            {
                Barrio oBarrio = new Barrio();
                oBarrio.IdBarrio = Convert.ToInt32(row["id_barrio"].ToString());
                oBarrio.NomBarrio = row["nom_barrio"].ToString();
                lst.Add(oBarrio);
            }

            return lst;


        }

        public List<Localidad> GetLocalidades(List<Parametro> parametro)
        {
            List<Localidad> lst = new List<Localidad>();

            DataTable table = HelperDao.ObtenerInstancia().ConsultaSQLParametros("SP_CONSULTAR_LOCALIDADES", parametro);


            foreach (DataRow row in table.Rows)
            {
                Localidad oLocalidad = new Localidad();
                oLocalidad.IdLocalidad = Convert.ToInt32(row["id_localidad"].ToString());
                oLocalidad.NomLocalidad = row["nom_localidad"].ToString();
                lst.Add(oLocalidad);
            }

            return lst;

        }
        
        public List<Provincia> GetProvincias()
        {
            List<Provincia> lst = new List<Provincia>();

            DataTable table = HelperDao.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_PROVINCIAS");
            
            //DataRow fila = table.NewRow();
            //fila["nom_provincia"] = "Selecciona provincia";
            //table.Rows.InsertAt(fila, 0);

            foreach (DataRow row in table.Rows)
            {
                Provincia oProv = new Provincia();
                oProv.IdProvincia = Convert.ToInt32(row["id_provincia"].ToString());
                oProv.NomProvincia = row["nom_provincia"].ToString();
                lst.Add(oProv);
            }

            return lst;
        }

        public bool ModificarClienteSQL(Cliente oCliente)
        {
           bool resultado = true;

            List<Parametro> lst = new List<Parametro>();

            
            lst.Add(new Parametro("@id_cliente", oCliente.IdCliente));
            lst.Add(new Parametro("@nom_cliente", oCliente.NomCliente));
            lst.Add(new Parametro("@ape_cliente", oCliente.ApeCliente));
            lst.Add(new Parametro("@dni", oCliente.Dni));
            lst.Add(new Parametro("@cuil", oCliente.Cuil));
            lst.Add(new Parametro("@direccion", oCliente.Direccion));
            lst.Add(new Parametro("@telefono", oCliente.Telefono));
            lst.Add(new Parametro("@email", oCliente.Email));
            lst.Add(new Parametro("@id_barrio", oCliente.Provincia.lLocalidad[0].lBarrio[0].IdBarrio));

			resultado = HelperDao.ObtenerInstancia().ModificarSQL("PA_EDITAR_CLIENTE", lst);

            return resultado;

        }

        public bool EliminarCliente(int id)
        {
            bool estado = true;

            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro() { Nombre = "@nro_cli", Valor = id });

            try
            {
                estado = HelperDao.ObtenerInstancia().ModificarSQL("PA_DELETE_CLIENTE", lst);
            }
            catch (Exception)
            {
                estado = false;
            }

            return estado;
        }

        public int ProximoID()
        {
            int nro = 0;

            nro = HelperDao.ObtenerInstancia().ProximoID("PA_PROXIMO_CLIENTE");

            return nro;
        }
    }
}
