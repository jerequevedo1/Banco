using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BancoPresentacion.Client
{
	class ClientSingleton
	{
		public static ClientSingleton instancia;
		private HttpClient client;

		private ClientSingleton()
		{
			client = new HttpClient();

		}
		public static ClientSingleton ObtenerInstancia()
		{
			if (instancia == null)
			{
				instancia = new ClientSingleton();
			}
			return instancia;
		}
	}
}
