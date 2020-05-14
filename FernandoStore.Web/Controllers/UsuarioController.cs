using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FernandoStore.Dominio.Contracts;
using FernandoStore.Dominio.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FernandoStore.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController : Controller
    {

        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioRetorno = _usuarioRepositorio.Obter(usuario.Email, usuario.Senha);

                if (usuarioRetorno != null)
                {
                    return Ok(usuarioRetorno);
                }
                return BadRequest("Usuario ou senha invalida");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioCadastrado = _usuarioRepositorio.Obter(usuario.Email);

                if (usuarioCadastrado != null)
                {
                    return BadRequest("Usuário já cadastrado no sistema");
                }
                else
                {
                    _usuarioRepositorio.Adicionar(usuario);
                    return Ok();
                }


            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }
    }
}