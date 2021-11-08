using BancoPresentacion;
using BancoPresentacion.Entidades;
using BancoServicios;
using BancoServicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClienteController : ControllerBase
	{
		private IClienteService service;
		public ClienteController()
		{
			service = new ServiceFactory().CrearClienteService();
		}

		[HttpPost("getFiltros")]
		public IActionResult GetClienteByFilters(List<Parametro> parametros)
		{
			return Ok(service.GetClienteByFilters(parametros));
		}

		[HttpGet("{nro}")]
		public IActionResult GetClienteId(int nro)
		{
			return Ok(service.GetClienteId(nro));
		}

		[HttpPost("consultaNombre")]
		public IActionResult GetClienteByName(List<Parametro> parametro)
		{
			return Ok(service.GetClienteByName(parametro));
		}

		[HttpPost("getBarrios")]
		public IActionResult GetBarrios(List<Parametro> parametro)
		{
			return Ok(service.GetBarrios(parametro));
		}

		public List<Localidad> GetLocalidades(List<Parametro> parametro)
		{
			return service.GetLocalidades(parametro);
		}
		public List<Provincia> GetProvincias()
		{
			return service.GetProvincias();
		}

		//public bool ModificarClienteSQL(List<Parametro> parametros)
		//{
		//    return daoCliente.ModificarClienteSQL(parametros);
		//}

		//public bool ActualizarSQL(string nombreSP, Parametro p)
		//{
		//    return daoCliente.ActualizarSQL(nombreSP, p);
		//}

		//public int ProximoID()
		//{
		//    return daoCliente.ProximoID();
		//}
	}
}
