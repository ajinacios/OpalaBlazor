using OpalaBlazor.Api.Entities;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Extensions
{
    public static class PessoaJurDtoConversion
    {
        public static IEnumerable<PessoaJurDto> ConvertToDto(this IEnumerable<PessoaJur> pjs)
        {

            return (from pj in pjs
                    select new PessoaJurDto
                    {
                        PessoaJurId = pj.PessoaJurId,
                        Nome = pj.Nome,
                        Tipo = pj.Tipo,
                        CNPJ = pj.CNPJ,
                        Logradouro= pj.Logradouro,
                        Complemento=pj.Complemento,
                        Bairro=pj.Bairro,
                        CEP=pj.CEP,
                        Numero=pj.Numero,
                        Cidade=pj.Cidade,
                        UF=pj.UF,
                        Telefone1 = pj.Telefone1,
                        Telefone2 = pj.Telefone2,
                        Site = pj.Site,
                        Email =pj.Email
                    }).ToList();
        }

        public static PessoaJurDto ConvertToDto(this PessoaJur pj)
        {

            return new PessoaJurDto
            {
                PessoaJurId = pj.PessoaJurId,
                Nome = pj.Nome,
                Tipo = pj.Tipo,
                CNPJ = pj.CNPJ,
                Logradouro = pj.Logradouro,
                Complemento = pj.Complemento,
                Bairro = pj.Bairro,
                CEP = pj.CEP,
                Numero = pj.Numero,
                Cidade = pj.Cidade,
                UF = pj.UF,
                Telefone1 = pj.Telefone1,
                Telefone2 = pj.Telefone2,
                Site = pj.Site,
                Email = pj.Email
            };
        }
    }
}
