using Microsoft.AspNetCore.Mvc;
using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Extensions;
using OpalaBlazor.Api.Repositories;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServidoresController : ControllerBase
    {
        private ServidorRepository servidorRepository;

        public ServidoresController(OpalaDbContext opalaDbContext)
        {
            servidorRepository = new ServidorRepository(opalaDbContext);
        }

        [HttpGet]
        public async Task<ActionResult<List<ServidorDto>>> ListAll()
        {
            var servidores = servidorRepository.ListAll();
            var servidorDtos = servidores.ConvertToDto();

            if (servidores is null)
            {
                return NotFound("Não existem servidores cadastrados.");
            }
            return Ok(servidorDtos);
        }

        [HttpGet]
        [Route("minimo")]
        public async Task<ActionResult<List<ServidorMinDto>>> ListAllMin()
        {
            var servidores = servidorRepository.ListAll();
            var servidorDtos = servidores.ConvertToDtoMin();

            if (servidores is null)
            {
                return NotFound("Não existem servidores cadastrados.");
            }
            return Ok(servidorDtos);
        }

    }
}
