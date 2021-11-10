using BancoPresentacion;
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
    public class TransaccionController : ControllerBase
    {
        private ITransaccionService service;
        public TransaccionController()
        {
            service = new ServiceFactory().CrearTransaccionService();
        }
        /// <summary>
        /// Obtiene información de las transacciones del banco por parametros
        /// </summary>
        /// <param name="parametros">nroTransaccion, nom_cliente, fechaDesde, FechaHasta</param>
        /// <returns>Lista de clientes</returns>
        [HttpPost("consultaTransaccion")]
        public IActionResult GetTransaccion(List<Parametro> parametros)
        {
            return Ok(service.GetTransacciones(parametros));
        }



    }
}
