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

        [HttpPost("consultaTransaccion")]
        public IActionResult GetTransaccion(List<Parametro> parametros)
        {
            return Ok(service.GetTransacciones(parametros));
        }



    }
}
