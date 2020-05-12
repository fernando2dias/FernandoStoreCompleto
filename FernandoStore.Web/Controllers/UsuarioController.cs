using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoStore.Dominio.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FernandoStore.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController : Controller
    {
        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario.Email == "fernando@teste.com" && usuario.Senha == "abc123")
                {
                    return Ok(usuario);
                }
                return BadRequest("Usuario ou senha invalida");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }
    }
}