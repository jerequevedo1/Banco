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

		[HttpPost("consultaFiltros")]
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

		[HttpPost("getLocalidades")]
		public IActionResult GetLocalidades(List<Parametro> parametro)
		{
			return Ok(service.GetLocalidades(parametro));
		}

		[HttpGet("getProvincias")]
		public IActionResult GetProvincias()
		{
			return Ok(service.GetProvincias());
		}
		[HttpPut("modifyCliente")]
		public IActionResult ModificarClienteSQL(Cliente oCliente)
		{
			if (oCliente != null)
			{
				bool result = service.ModificarClienteSQL(oCliente);
				return Ok(result);
			}
			return BadRequest("Parametro Requerido");
		}
		[HttpDelete("deleteCliente/{id}")]
		public IActionResult EliminarCliente(int id)
		{
			return Ok(service.EliminarCliente(id));
		}

		[HttpGet("proximoId")]
		public IActionResult ProximoID()
		{
			return Ok(service.ProximoID());
		}
	}
}
