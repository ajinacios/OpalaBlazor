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

        public static PessoaJur UnConvertFromDto(this PessoaJurDto pjdto)
        {

            return new PessoaJur
            {
                PessoaJurId = pjdto.PessoaJurId,
                Nome = pjdto.Nome,
                Tipo = pjdto.Tipo,
                CNPJ = pjdto.CNPJ,
                Logradouro = pjdto.Logradouro,
                Complemento = pjdto.Complemento,
                Bairro = pjdto.Bairro,
                CEP = pjdto.CEP,
                Numero = pjdto.Numero,
                Cidade = pjdto.Cidade,
                UF = pjdto.UF,
                Telefone1 = pjdto.Telefone1,
                Telefone2 = pjdto.Telefone2,
                Site = pjdto.Site,
                Email = pjdto.Email
            };
        }
    }
}
