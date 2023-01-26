using Microsoft.AspNetCore.Mvc;
using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Extensions;
using OpalaBlazor.Api.Repositories;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private UsuarioRepository usuarioRepository;

        public UsuariosController(OpalaDbContext opalaDbContext)
        {
            usuarioRepository = new UsuarioRepository(opalaDbContext);
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioDto>>> ListAll()
        {
            var usuarios = usuarioRepository.ListAll();
            var usuarioDtos = usuarios.ConvertToDto();
            if (usuarios is null)
            {
                return NotFound("Não existem usuários cadastrados.");
            }
            return Ok(usuarioDtos);
        }

        [HttpGet]
        [Route("porid/{id:int}")]
        public async Task<ActionResult<UsuarioDto>> Porid(int id)
        {
            var usuario = await usuarioRepository.OneId(id);
            var usuarioDto = usuario.ConvertToDto();
            if (usuario is null)
            {
                return NotFound("Usuário não cadastrado.");
            }
            return Ok(usuarioDto);
        }

        [HttpGet]
        [Route("porlogin/{login}")]
        public async Task<ActionResult<UsuarioDto>> PorLogin(string login)
        {
            var usuario = await usuarioRepository.OneLogin(login);
            var usuarioDto = usuario.ConvertToDto();
            if (usuario is null)
            {
                return NotFound("Usuário não cadastrado.");
            }
            return Ok(usuarioDto);
        }

        [HttpGet]
        [Route("porNome/{nome}")]
        public async Task<ActionResult<UsuarioDto>> PorNome(string nome)
        {
            var usuario = await usuarioRepository.OneLogin(nome);
            var usuarioDto = usuario.ConvertToDto();
            if (usuario is null)
            {
                return NotFound("Usuário não cadastrado.");
            }
            return Ok(usuarioDto);
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

