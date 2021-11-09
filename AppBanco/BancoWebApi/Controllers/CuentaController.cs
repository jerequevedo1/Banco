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
	public class CuentaController : ControllerBase
	{
		private ICuentaService service;
		public CuentaController()
		{
			service = new ServiceFactory().CrearCuentaService();
		}

		[HttpPost("consultaFiltros")]
		public IActionResult GetCuentaByFilters(List<Parametro> parametros)
		{
			if (parametros==null || parametros.Count==0)
			{
				return BadRequest("Parametros requeridos");
			}
			return Ok(service.GetCuentaByFilters(parametros));
		}

		[HttpGet("tipoCuenta")]
		public IActionResult GetTipoCuenta()
		{
			return Ok(service.GetTipoCuenta());
		}

		[HttpPost("newCuenta")]
		public IActionResult NuevaCuenta(Cliente oCliente)
		{
			return Ok(service.NuevaCuenta(oCliente));
		}
		[HttpPost("newCuentaOnly")]
		public IActionResult NuevaCuentaClienteExist(Cliente oCliente)
		{
			if (oCliente!=null)
			{
				bool result = service.NuevaCuentaClienteExist(oCliente);
				return Ok(result);
			}
			return BadRequest("Parametro Requerido");
		}
		[HttpPut("modifyCuenta")]
		public IActionResult ModificarCuenta(Cliente oCliente)
		{
			return Ok(service.ModificarCuenta(oCliente));
		}
		[HttpGet("{nro}")]
		public IActionResult GetCuentaById(int nro)
		{
			return Ok(service.GetCuentaById(nro));
		}
		[HttpGet("proximoId")]
		public IActionResult ProximoID()
		{
			return Ok(service.ProximoID());
		}
		[HttpDelete("deleteCuenta/{id}")]
		public IActionResult EliminarCuenta(int id)
		{
			return Ok(service.EliminarCuenta(id));
		}

	}
}
