﻿using BancoDominio;
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
	}

}
