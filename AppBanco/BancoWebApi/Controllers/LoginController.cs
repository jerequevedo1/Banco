using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoServicios.Interfaces;
using BancoServicios;
using BancoWebApi.Dto;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BancoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService service;

        public LoginController()
        {
            service = new ServiceFactory().CrearLoginService();
        }
        /// <summary>
        /// Login para empleados del banco 
        /// </summary>
        /// <remarks>Endpoint para determinar si un usuario tiene permiso al banco APP</remarks>
        /// <response code="200">Usuario Logueado correctamente</response>
        /// <response code="401">Usuario no autorizado</response>
        /// <param name="usuario">Debe incluir nombreUsuario y password</param>
        /// <returns></returns>
        // POST api/<LoginController>
        [HttpPost]
        public IActionResult Post([FromBody] UsuarioDto usuario)
        {
            //devolvemos 400 cuando los parametros enviados son no validos
            if (usuario == null)
                return BadRequest("Usuario es requerido");

            if (usuario.nombreUsuario == null || usuario.password == null)
                return BadRequest("Usuario o contraseña requerido");

            var user = service.GetUsuario(usuario.nombreUsuario, usuario.password);
            if (user == null)
                return Unauthorized();

            return Ok(user);

        }
    }


}

