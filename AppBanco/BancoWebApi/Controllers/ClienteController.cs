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
		/// <summary>
		/// Obtiene clientes del banco según filtros.
		/// </summary>
		/// <remarks>Endpoint para obtener clientes del banco.</remarks>
		/// <param name="parametros"></param>
		/// <returns>Lista de Clientes y sus cuentas</returns>
		[HttpPost("consultaFiltros")]
		public IActionResult GetClienteByFilters(List<Parametro> parametros)
		{
			return Ok(service.GetClienteByFilters(parametros));
		}
		
		/// <summary>
		/// Obtiene clientes por nombre
		/// </summary>
		/// <param name="parametro">Nombre del cliente</param>
		/// <returns>Lista de clientes</returns>
		[HttpPost("consultaNombre")]
		public IActionResult GetClienteByName(List<Parametro> parametro)
		{
			return Ok(service.GetClienteByName(parametro));
		}
		/// <summary>
		/// Obtiene los barrios por ID localidad
		/// </summary>
		/// <remarks> Endpoint para la obtención de barrios por ID localidad.</remarks>
		/// <param name="parametro">id_loc: id localidad de la tabla localidades.</param>
		/// <returns>Lista de barrios</returns>
		[HttpPost("getBarrios")]
		public IActionResult GetBarrios(List<Parametro> parametro)
		{
			return Ok(service.GetBarrios(parametro));
		}
		/// <summary>
		/// Obtiene localidades por id provincia.
		/// </summary>
		/// <remarks> Endpoint para la obtención de localidades por id_provincia.</remarks>
		/// <param name="parametro">@id_prov: id de la tabla Provincias</param>
		/// <returns>Lista de localidades</returns>
		[HttpPost("getLocalidades")]
		public IActionResult GetLocalidades(List<Parametro> parametro)
		{
			return Ok(service.GetLocalidades(parametro));
        }
		
		/// <summary>
		/// Modifica la información de un cliente del banco 
		/// </summary>
		/// <remarks> Endpoint para la modificación de un cliente del banco.</remarks>
		/// <param name="oCliente">Información de un Cliente</param>
		/// <returns></returns>
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
		/// <summary>
		/// Elimina un cliente del banco por ID
		/// </summary>
		/// <remarks> Endpoint para la eliminación de un cliente del banco.</remarks>
		/// <param name="id">ID de la tabla Clientes</param>
		/// <returns></returns>
		[HttpDelete("deleteCliente/{id}")]
		public IActionResult EliminarCliente(int id)
		{
			return Ok(service.EliminarCliente(id));
		}
	
		/// <summary>
		/// Obtiene próximo ID de cliente del banco.
		/// </summary>
		/// <remarks> Endpoint para obtener el próximo ID de cliente del banco.</remarks>
		/// <returns>Próximo ID cliente</returns>
		[HttpGet("proximoId")]
		public IActionResult ProximoID()
		{
			return Ok(service.ProximoID());
		}
	
		/// <summary>
		/// Obtiene un cliente por su número.
		/// </summary>
		/// <remarks> Endpoint para obtener un cliente por su número.</remarks>
		/// <param name="nro">Número de cliente</param>
		/// <returns>Información de un cliente</returns>
		[HttpGet("{nro}")]
		public IActionResult GetClienteId(int nro)
		{
			return Ok(service.GetClienteId(nro));
		}

		/// <summary>
		/// Obtiene todas las provincias
		/// </summary>
		/// /// <remarks> Endpoint para obtención de todas las provincias.</remarks>
		/// <returns>Lista de Provincias</returns>
		[HttpGet("getProvincias")]
		public IActionResult GetProvincias()
		{
			return Ok(service.GetProvincias());
		}
	}
}
