using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Migrations;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Extensions
{
    public static class InspecaoDtoConversion
    {
        public static IEnumerable<InspecaoDto> ConvertToDto(this IEnumerable<Inspecao> inspecoes)
        {

            return (from inspecao in inspecoes
                    select new InspecaoDto
                    {
                        InspecaoId = inspecao.InspecaoId,
                        Numero = inspecao.Numero,
                        Ano = inspecao.Ano,
                        Inicio = inspecao.Inicio,
                        Final = inspecao.Final,
                        Portaria = inspecao.Portaria,
                        OrgaoId= inspecao.OrgaoId
                    }).ToList();
        }

        public static InspecaoDto ConvertToDto(this Inspecao inspecao)
        {

            return new InspecaoDto
            {
                InspecaoId = inspecao.InspecaoId,
                Numero = inspecao.Numero,
                Ano = inspecao.Ano,
                Inicio = inspecao.Inicio,
                Final = inspecao.Final,
                Portaria = inspecao.Portaria,
                OrgaoId = inspecao.OrgaoId
            };
        }
    }
}
