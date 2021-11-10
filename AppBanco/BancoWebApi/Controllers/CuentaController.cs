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

		/// <summary>
		/// Obtiene cuentas de clientes según filtros.
		/// </summary>
		/// <remarks>Endpoint para obtener cuentas de los clientes del banco</remarks>
		/// <response code="400">Verificar parámetros</response>
		/// <param name="parametros">Lista de parámetros para filtrar.</param>
		/// <returns></returns>
		[HttpPost("consultaFiltros")]
		public IActionResult GetCuentaByFilters(List<Parametro> parametros)
		{
			if (parametros==null || parametros.Count==0)
			{
				return BadRequest("Parametros requeridos");
			}
			return Ok(service.GetCuentaByFilters(parametros));
		}
	
		/// <summary>
		/// Creación de un nuevo cliente y su nueva cuenta bancaria.
		/// </summary>
		/// <remarks>Endpoint para la creación de una nueva cuenta de un cliente del banco.</remarks>
		/// <param name="oCliente">Informacion del cliente y de su cuenta</param>
		/// <returns></returns>
		[HttpPost("newCuenta")]
		public IActionResult NuevaCuenta(Cliente oCliente)
		{
			return Ok(service.NuevaCuenta(oCliente));
		}

		/// <summary>
		/// Creación de una nueva cuenta bancaria de un cliente.
		/// </summary>
		/// <remarks> Endpoint para la creación de una nueva cuenta de un cliente existente del banco.</remarks>
		/// <param name="oCliente"></param>
		/// <response code="400">Verificar parámetros</response>
		/// <returns></returns>
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

		/// <summary>
		/// Modificación de cuentas de un cliente del banco.
		/// </summary>
		/// <remarks> Endpoint para la modificación de las cuentas de un cliente del banco.</remarks>
		/// <param name="oCliente">Cliente y sus cuentas</param>
		/// <returns></returns>
		[HttpPut("modifyCuenta")]
		public IActionResult ModificarCuenta(Cliente oCliente)
		{
			return Ok(service.ModificarCuenta(oCliente));
		}

		/// <summary>
		/// Eliminación de cuenta bancaria de cliente.
		/// </summary>
		/// <remarks> Endpoint para la eliminación de una cuenta de cliente del banco.</remarks>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpDelete("deleteCuenta/{id}")]
		public IActionResult EliminarCuenta(int id)
		{
			return Ok(service.EliminarCuenta(id));
		}

		/// <summary>
		/// Obtiene una cuenta bancaria por su número.
		/// </summary>
		/// <remarks> Endpoint para obtener una cuenta por su número.</remarks>
		/// <param name="nro">Número de cuenta</param>
		/// <returns>Un cliente y sus cuentas</returns>
		[HttpGet("{nro}")]
		public IActionResult GetCuentaById(int nro)
		{
			return Ok(service.GetCuentaById(nro));
		}

		/// <summary>
		/// Obtiene próximo ID de cuenta bancaria.
		/// </summary>
		/// <remarks> Endpoint para obtener el próximo ID de cuenta bancaria.</remarks>
		/// <returns>Valor de el proximo ID cuenta</returns>
		[HttpGet("proximoId")]
		public IActionResult ProximoID()
		{
			return Ok(service.ProximoID());
		}

		/// <summary>
		/// Selecciona tipo de cuenta bancaria.
		/// </summary>
		/// <remarks>Endpoint para obtener tipo de cuenta de los clientes del banco.</remarks>
		/// <returns></returns>
		[HttpGet("tipoCuenta")]
		public IActionResult GetTipoCuenta()
		{
			return Ok(service.GetTipoCuenta());
		}

	}
}
