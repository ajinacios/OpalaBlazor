using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Extensions;
using OpalaBlazor.Api.Repositories;
using OpalaBlazor.Api.Repositories.Contracts;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspecoesController : ControllerBase
    {
        private InspecaoRepository inspecaoRepository;

        public InspecoesController(OpalaDbContext opalaDbContext)
        {
            inspecaoRepository = new InspecaoRepository(opalaDbContext);
        }

        [HttpGet]
        public async Task<ActionResult<List<InspecaoDto>>> ListAll()
        {
            var inspecoes = inspecaoRepository.ListAll();
            var inspecaoDtos = inspecoes.ConvertToDto();

            if (inspecoes is null)
            {
                return NotFound("Não existem inspeções cadastradas.");
            }
            return Ok(inspecaoDtos);
        }

        [HttpGet]
        [Route("porid/{id:int}")]
        public async Task<ActionResult<InspecaoDto>> Porid(int id)
        {
            var inspecao = await inspecaoRepository.OneId(id);
            var inspecaoDto = inspecao.ConvertToDto();
            if (inspecao is null)
            {
                return NotFound("Inspecao não cadastrada.");
            }
            return Ok(inspecaoDto);
        }

        [HttpGet]
        [Route("porNumero/{numero}")]
        public async Task<ActionResult<InspecaoDto>> PorNumero(string numero)
        {
            InspecaoDto inspecaoDto;
            numero = numero.Substring(0, numero.Length - 4) + @"/" + numero.Substring(numero.Length - 4);
            var inspecao = await inspecaoRepository.OneNumero(numero); 

            if (inspecao is null)
                inspecaoDto = new InspecaoDto();
            else
                inspecaoDto = inspecao.ConvertToDto();

            return Ok(inspecaoDto);

        }
    }
}
