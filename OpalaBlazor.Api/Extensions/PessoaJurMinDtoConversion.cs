using OpalaBlazor.Api.Entities;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Extensions
{
    public static class PessoaJurMinDtoConversion
    {
        public static IEnumerable<PessoaJurMinDto> ConvertToDtoMin(this IEnumerable<PessoaJur> pjs)
        {

            return (from pj in pjs
                    select new PessoaJurMinDto
                    {
                        PessoaJurId = pj.PessoaJurId,
                        Nome = pj.Nome,
                        CNPJ = pj.CNPJ
                    }).ToList();
        }

        public static PessoaJurMinDto ConvertToDtoMin(this PessoaJur pj)
        {

            return new PessoaJurMinDto
            {
                PessoaJurId = pj.PessoaJurId,
                Nome = pj.Nome,
                CNPJ = pj.CNPJ
            };
        }

    }
}
