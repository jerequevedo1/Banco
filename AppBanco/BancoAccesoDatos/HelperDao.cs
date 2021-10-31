using BancoDominio;
using BancoDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAccesoDatos
{
    class HelperDao
    {
		public static HelperDao instancia;
		public string ConnectionString { get; set; }

		public SqlConnection cnn { get; }
		public SqlCommand cmd { get; set; }


		private HelperDao()
		{

			//ConnectionString = @"Data Source=LAPTOP-JULI\SQLEXPRESS;Initial Catalog=BancoJJRG;Integrated Security=True";


			//ConnectionString = @"Data Source=HOME\SQLEXPRESS;Initial Catalog=BancoJJRG;Integrated Security=True";
			//ConnectionString = @"Data Source=NOTEBOOK-JERE\SQLEXPRESS;Initial Catalog=BancoJJRG;Integrated Security=True";

			//ConnectionString = @"Data Source=HOME\SQLEXPRESS;Initial Catalog=BancoJJRG;Integrated Security=True";
			ConnectionString = @"Data Source=NOTEBOOK-JERE\SQLEXPRESS;Initial Catalog=BancoJJRG;Integrated Security=True";


			cnn = new SqlConnection(ConnectionString);

		}
		public static HelperDao ObtenerInstancia()
		{
			if (instancia == null)
			{
				instancia = new HelperDao();
			}
			return instancia;
		}

		public DataTable ConsultaSQLParametros(string nombreSp, List<Parametro> parametros)
		{
			DataTable tabla = new DataTable();
			try
			{
				cnn.Open();
				cmd = new SqlCommand(nombreSp, cnn);
				cmd.Parameters.Clear();
				cmd.CommandType = CommandType.StoredProcedure;

				foreach (Parametro p in parametros)
				{
					cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
				}

				tabla.Load(cmd.ExecuteReader());


			}
            catch (Exception)
            {
                tabla = null;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open) cnn.Close();
			}

			return tabla;
		}



        public Cliente GetClienteId(int nro)
        {
            Cliente oCliente = new Cliente();
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CONSULTAR_CLIENTE_POR_ID";
                cmd.Parameters.AddWithValue("@nro", nro);
                SqlDataReader reader = cmd.ExecuteReader();
                bool esPrimerRegistro = true;

                while (reader.Read())
                {
                    if (esPrimerRegistro)
                    {

                        oCliente.NomCliente = reader["nom_cliente"].ToString();
                        oCliente.ApeCliente = reader["ape_cliente"].ToString();
                        oCliente.Dni = Convert.ToInt32(reader["dni"].ToString());
                        oCliente.Cuil = long.Parse(reader["cuil"].ToString());
                        oCliente.Direccion = reader["direccion"].ToString();
                        oCliente.Telefono = reader["telefono"].ToString();
                        oCliente.Email = reader["email"].ToString();

                        Barrio obarrio = new Barrio();
                        obarrio.IdBarrio = Convert.ToInt32(reader["id_barrio"].ToString());
                        obarrio.NomBarrio = reader["nom_barrio"].ToString();

                        oCliente.Barrio = obarrio;

                        esPrimerRegistro = false;
                    }

                   

                    esPrimerRegistro = false;
                   
                }

            }
            catch (Exception)
            {

            }

            finally
            {
                if (cnn.State == ConnectionState.Open) cnn.Close();
            }

            return oCliente;

        }

		public DataTable ConsultaSQL(string nombreSP)
		{
			DataTable tabla = new DataTable();
			try
			{
				cmd.Parameters.Clear();
				cnn.Open();
				cmd.Connection = cnn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = nombreSP;
				tabla.Load(cmd.ExecuteReader());
			}
			catch (Exception)
			{
				tabla = null;
			}
			finally
			{
				if (cnn.State == ConnectionState.Open)
					cnn.Close();
			}
			return tabla;
		}
	}


}
