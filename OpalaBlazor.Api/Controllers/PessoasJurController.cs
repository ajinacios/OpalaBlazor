using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Extensions;
using OpalaBlazor.Api.Repositories;
using OpalaBlazor.Api.Repositories.Contracts;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasJurController : ControllerBase
    {
        private PessoaJurRepository pjRepository;

        public PessoasJurController(OpalaDbContext opalaDbContext)
        {
            pjRepository = new PessoaJurRepository(opalaDbContext);
        }

        [HttpGet]
        public async Task<ActionResult<List<PessoaJurDto>>> ListAll()
        {
            var pjs = pjRepository.ListAll();
            var pjDtos = pjs.ConvertToDto();

            if (pjs is null)
            {
                return NotFound("Não existem entidades cadastradas.");
            }
            return Ok(pjDtos);
        }

        [HttpGet]
        [Route("minimo")]
        public async Task<ActionResult<List<PessoaJurMinDto>>> ListAllMin()
        {
            var pjs = pjRepository.ListAll();
            var pjDtos = pjs.ConvertToDtoMin();

            if (pjs is null)
            {
                return NotFound("Não existem entidades cadastradas.");
            }
            return Ok(pjDtos);
        }

    }
}
