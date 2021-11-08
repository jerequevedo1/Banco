using BancoPresentacion;
using BancoPresentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BancoPresentacion.Enumeraciones;

namespace BancoAccesoDatos
{
	public class HelperDao
	{
		public static HelperDao instancia;
		public string ConnectionString { get; set; }

		public SqlConnection cnn { get; }
		public SqlCommand cmd { get; set; }


		private HelperDao()
		{

			//ConnectionString = @"Data Source=LAPTOP-JULI\SQLEXPRESS;Initial Catalog=BancoJJRG;Integrated Security=True";


			//ConnectionString = @"Data Source=DESKTOP-DUIDE87\SQLEXPRESS;Initial Catalog=BancoJJRG;Integrated Security=True";

			ConnectionString = @"Data Source=NOTEBOOK-JERE\SQLEXPRESS;Initial Catalog=BancoJJRG;Integrated Security=True";

			//ConnectionString = @"Data Source=HOME\SQLEXPRESS;Initial Catalog=BancoJJRG;Integrated Security=True";
			//ConnectionString = @"Data Source=NOTEBOOK-JERE\SQLEXPRESS;Initial Catalog=BancoJJRG;Integrated Security=True";
			//ConnectionString = @"Data Source=DESKTOP-CBSH5U3\SQLEXPRESS;Initial Catalog=BancoJJRG;Integrated Security=True";

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
					if (p.Valor!=null)
					{
						cmd.Parameters.AddWithValue(p.Nombre, p.Valor.ToString());
					}
					else
					{
						cmd.Parameters.AddWithValue(p.Nombre, DBNull.Value);
					}
					
				}

				tabla.Load(cmd.ExecuteReader());


			}
			catch (Exception ex)
			{
				tabla = null;
			}
			finally
			{
				if (cnn.State == ConnectionState.Open) cnn.Close();
			}

			return tabla;
		}

		
		public DataTable ConsultaSQL(string nombreSP)
		{
			DataTable tabla = new DataTable();
			try
			{
				cmd = new SqlCommand(nombreSP, cnn);
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
		public int EjecutarSQLMaestroDetalle(string spMaestro, string spDetalle, Cliente oCliente, Accion modo)
		{
			int filasAfectadas = 0;
			SqlTransaction trans = null;

			try
			{
				cnn.Open();
				trans = cnn.BeginTransaction();


				if (modo == Accion.Create)
				{
					cmd = new SqlCommand(spMaestro, cnn, trans);
					cmd.Parameters.Clear();
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@nom_cliente", oCliente.NomCliente);
					cmd.Parameters.AddWithValue("@ape_cliente", oCliente.ApeCliente);
					cmd.Parameters.AddWithValue("@dni", oCliente.Dni);
					cmd.Parameters.AddWithValue("@cuil", oCliente.Cuil);
					cmd.Parameters.AddWithValue("@direccion", oCliente.Direccion);
					cmd.Parameters.AddWithValue("@telefono", oCliente.Telefono);
					cmd.Parameters.AddWithValue("@email", oCliente.Email);
					cmd.Parameters.AddWithValue("@id_barrio", oCliente.Provincia.lLocalidad[0].lBarrio[0].IdBarrio);
					SqlParameter parameter = new SqlParameter("@id_cliente", SqlDbType.Int);
					parameter.Direction = ParameterDirection.Output;
					cmd.Parameters.Add(parameter);

					cmd.ExecuteNonQuery();
					int nroCliente = Convert.ToInt32(parameter.Value);

					SqlCommand cmdDet = new SqlCommand(spDetalle, cnn, trans);

					//cmdDet.CommandText = spDetalle;
					cmdDet.CommandType = CommandType.StoredProcedure;

					foreach (Cuenta item in oCliente.Cuentas)
					{
						cmdDet.Parameters.AddWithValue("@cbu", item.Cbu);
						cmdDet.Parameters.AddWithValue("@alias", item.Alias);
						cmdDet.Parameters.AddWithValue("@saldo_actual", item.Saldo);
						cmdDet.Parameters.AddWithValue("@id_cliente", nroCliente);
						cmdDet.Parameters.AddWithValue("@id_tipo_cuenta", item.TipoCuenta.IdTipoCuenta);
						cmdDet.Parameters.AddWithValue("@tipo_moneda", item.TipoMoneda);
						cmdDet.Parameters.AddWithValue("@limite_descubierto", item.LimiteDescubierto);
					}

					filasAfectadas = cmdDet.ExecuteNonQuery();
				}
				//if (modo == Accion.Update)
				//{
				//	
				//}

				trans.Commit();
			}
			catch (Exception)
			{
				trans.Rollback();
			}
			finally
			{
				if (cnn != null && cnn.State == ConnectionState.Open) cnn.Close();
			}

			return filasAfectadas;
		}

		public bool ModificarSQL(string nombreSP, List<Parametro> parametros)
		{
			int filasdevueltas = 0;
			bool estado = true;
			try
			{
				cnn.Open();
				cmd = new SqlCommand(nombreSP, cnn);
				cmd.Parameters.Clear();
				cmd.CommandType = CommandType.StoredProcedure;

				foreach (Parametro p in parametros)
				{
					cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
				}

				filasdevueltas = cmd.ExecuteNonQuery();


			}
			catch (Exception)
			{
				throw;
				estado = false;
			}
			finally
			{
				if (cnn.State == ConnectionState.Open) cnn.Close();
			}

			return estado;

		}

		public bool ActualizarSQL(string nombreSP, Parametro p)
		{
			int filasdevueltas = 0;
			bool estado = true;
			try
			{
				cnn.Open();
				cmd = new SqlCommand(nombreSP, cnn);
				cmd.Parameters.Clear();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
				filasdevueltas = cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				throw;
				estado = false;
			}
			finally
			{
				if (cnn.State == ConnectionState.Open) cnn.Close();
			}

			return estado;
		}

		public int ProximoID(string nombreSp) 
		{
			
			SqlCommand cmd = new SqlCommand();	
			try
			{
				
				cnn.Open();
				cmd.Connection = cnn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = nombreSp;
				SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
				param.Direction = ParameterDirection.Output;
				cmd.Parameters.Add(param);
				cmd.ExecuteNonQuery();
				return (int)param.Value;


			}
			catch (SqlException ex)
			{
				throw (ex);
			}
			finally
			{
				if (cnn != null && cnn.State == ConnectionState.Open) cnn.Close();
			}

		}


	}


}
