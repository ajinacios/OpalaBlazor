using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Repositories;
using System;

namespace OpalaBlazor.Api.Controllers
{
    [ApiController]
    [Route("[controller]/{action}")]
    public class UsuariosController : ControllerBase
    {
        private UsuarioRepository usuarioRepository;

        public UsuariosController(OpalaDbContext opalaDbContext)
        {
            usuarioRepository = new UsuarioRepository(opalaDbContext);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> ListAll()
        {
            var usuarios = usuarioRepository.ListAll();
            if (usuarios is null)
            {
                return NotFound("Não existem usuários cadastrados.");
            }
            return Ok(usuarios);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Usuario>> Porid(int id)
        {
            var usuario = usuarioRepository.OneId(id);
            if (usuario is null)
            {
                return NotFound("Usuários não cadastrados.");
            }
            return Ok(usuario);
        }

        [HttpGet("{login}")]
        public async Task<ActionResult<Usuario>> PorLogin(string login)
        {
            var usuario = usuarioRepository.OneLogin(login);
            if (usuario is null)
            {
                return NotFound("Usuários não cadastrados.");
            }
            return Ok(usuario);
        }

        [HttpPost]
        public ActionResult Post(Usuario usuario)
        {
            if (usuario is null)
                return BadRequest();

            usuarioRepository.Add(usuario);
            return Ok(Post(usuario));
        }

        [HttpPut]
        public ActionResult Put(Usuario usuario)
        {
            if (usuario is null)
                return BadRequest();

            usuarioRepository.Update(usuario);

            return Ok(usuario);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            usuarioRepository.Delete(id);

            return Ok();
        }
    }
}

