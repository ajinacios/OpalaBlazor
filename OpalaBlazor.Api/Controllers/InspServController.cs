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
    public class InspServController : ControllerBase
    {
        private InspecaoServRepository inspecaoServRepository;
        private InspecaoRepository inspecaoRepository;
        private ServidorRepository servidorRepository;

        public InspServController(OpalaDbContext opalaDbContext)
        {
            inspecaoServRepository = new InspecaoServRepository(opalaDbContext);
            inspecaoRepository = new InspecaoRepository(opalaDbContext);
            servidorRepository = new ServidorRepository(opalaDbContext);
        }

        [HttpGet]
        [Route("insp/{insp: int}")]
        public async Task<ActionResult<List<InspecaoServidorDto>>> ListPorInspecao(int insp)
        {
            var inspservs = inspecaoServRepository.ListPorInspecao(insp);
            var inspservsDtos = inspservs.ConvertToDto();

            if (inspservs is null)
            {
                return NotFound("Não existem servidores para essa inspeção.");
            }
            return Ok(inspservsDtos);
        }

        [HttpGet]
        [Route("insp/amp/{insp: int}")]
        public async Task<ActionResult<List<InspecaoServAmpDto>>> ListPorInspecaoAmp(int insp)
        {
            var inspservs = inspecaoServRepository.ListPorInspecao(insp);
            var inspecoes = inspecaoRepository.ListAll();
            var servidores = servidorRepository.ListAll();
            var inspservsDtos = inspservs.ConvertToAmpDto(inspecoes, servidores);

            if (inspservs is null)
            {
                return NotFound("Não existem servidores para essa inspeção.");
            }
            return Ok(inspservsDtos);
        }

        [HttpGet]
        [Route("serv/{serv: int}")]
        public async Task<ActionResult<List<InspecaoServidorDto>>> ListPorServidor(int serv)
        {
            var inspservs = inspecaoServRepository.ListPorServidor(serv);
            var inspservsDtos = inspservs.ConvertToDto();

            if (inspservs is null)
            {
                return NotFound("Não existem servidores para essa inspeção.");
            }
            return Ok(inspservsDtos);
        }

        [HttpGet]
        [Route("serv/amp/{serv: int}")]
        public async Task<ActionResult<List<InspecaoServAmpDto>>> ListPorServidorAmp(int serv)
        {
            var inspservs = inspecaoServRepository.ListPorServidor(serv);
            var inspecoes = inspecaoRepository.ListAll();
            var servidores = servidorRepository.ListAll();
            var inspservsDtos = inspservs.ConvertToAmpDto(inspecoes, servidores);

            if (inspservs is null)
            {
                return NotFound("Não existem servidores para essa inspeção.");
            }
            return Ok(inspservsDtos);
        }
    }
}
