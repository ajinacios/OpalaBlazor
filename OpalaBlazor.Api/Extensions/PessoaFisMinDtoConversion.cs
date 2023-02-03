using OpalaBlazor.Api.Entities;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Extensions
{
    public static class PessoaFisMinDtoConversion
    {
        public static IEnumerable<PessoaFisMinDto> ConvertToDtoMin(this IEnumerable<PessoaFis> pfs)
        {

            return (from pf in pfs
                    select new PessoaFisMinDto
                    {
                        PessoaFisId = pf.PessoaFisId,
                        Nome = pf.Nome,
                        CPF = pf.CPF
                    }).ToList();
        }

        public static PessoaFisMinDto ConvertToDtoMin(this PessoaFis pf)
        {

            return new PessoaFisMinDto
            {
                PessoaFisId = pf.PessoaFisId,
                Nome = pf.Nome,
                CPF = pf.CPF
            };
        }

    }
}
