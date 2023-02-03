using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Extensions;
using OpalaBlazor.Api.Repositories;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasFisController : ControllerBase
    {
        private PessoaFisRepository pfRepository;

        public PessoasFisController(OpalaDbContext opalaDbContext)
        {
            pfRepository = new PessoaFisRepository(opalaDbContext);
        }

        [HttpGet]
        public async Task<ActionResult<List<PessoaFisDto>>> ListAll()
        {
            var pfs = pfRepository.ListAll();
            var pfDtos = pfs.ConvertToDto();

            if (pfs is null)
            {
                return NotFound("Não existem pessoas cadastradas.");
            }
            return Ok(pfDtos);
        }

        [HttpGet]
        [Route("minimo")]
        public async Task<ActionResult<List<PessoaFisMinDto>>> ListAllMin()
        {
            var pfs = pfRepository.ListAll();
            var pfDtos = pfs.ConvertToDtoMin();

            if (pfs is null)
            {
                return NotFound("Não existem pessoas cadastradas.");
            }
            return Ok(pfDtos);
        }
    }
}
