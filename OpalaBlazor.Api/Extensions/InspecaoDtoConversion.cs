using OpalaBlazor.Api.Entities;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Extensions
{
    public static class InspecaoDtoConversion
    {
        public static IEnumerable<InspecaoDto> ConvertToDto(this IEnumerable<Inspecao> inspecoes,
            IEnumerable<PessoaJur> pjs)
        {

            return (from inspecao in inspecoes
                    join pj in pjs
                    on inspecao.OrgaoId equals pj.PessoaJurId
                    select new InspecaoDto
                    {
                        InspecaoId = inspecao.InspecaoId,
                        Numero = inspecao.Numero,
                        Ano = inspecao.Ano,
                        Inicio = inspecao.Inicio,
                        Final = inspecao.Final,
                        Portaria = inspecao.Portaria,
                        OrgaoId = inspecao.OrgaoId,
                        OrgaoNome = pj.Nome
                    }).ToList();
        }

        public static InspecaoDto ConvertToDto(this Inspecao inspecao,
            PessoaJur pj)
        {

            return new InspecaoDto
            {
                InspecaoId = inspecao.InspecaoId,
                Numero = inspecao.Numero,
                Ano = inspecao.Ano,
                Inicio = inspecao.Inicio,
                Final = inspecao.Final,
                Portaria = inspecao.Portaria,
                OrgaoId = inspecao.OrgaoId,
                OrgaoNome = pj.Nome
            };
        }

        public static Inspecao UnConvertFromDto(this InspecaoDto inspecaodto)
        {

            return new Inspecao
            {
                InspecaoId = inspecaodto.InspecaoId,
                Numero = inspecaodto.Numero,
                Ano = inspecaodto.Ano,
                Inicio = inspecaodto.Inicio,
                Final = inspecaodto.Final,
                Portaria = inspecaodto.Portaria,
                OrgaoId = inspecaodto.OrgaoId,
            };
        }
    }
}
