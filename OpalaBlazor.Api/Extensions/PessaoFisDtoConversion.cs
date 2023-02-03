using OpalaBlazor.Api.Entities;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Extensions
{
    public static class PessaoFisDtoConversion
    {
        public static IEnumerable<PessoaFisDto> ConvertToDto(this IEnumerable<PessoaFis> pfs)
        {

            return (from pf in pfs
                    select new PessoaFisDto
                    {
                        PessoaFisId = pf.PessoaFisId,
                        Nome = pf.Nome,
                        Titulo= pf.Titulo,
                        Genero= pf.Genero,
                        CPF = pf.CPF,
                        Logradouro = pf.Logradouro,
                        Complemento = pf.Complemento,
                        Bairro = pf.Bairro,
                        CEP = pf.CEP,
                        Numero = pf.Numero,
                        Cidade = pf.Cidade,
                        UF = pf.UF,
                        Telefone1 = pf.Telefone1,
                        Telefone2 = pf.Telefone2,
                        Email = pf.Email
                    }).ToList();
        }

        public static PessoaFisDto ConvertToDto(this PessoaFis pf)
        {

            return new PessoaFisDto
            {
                PessoaFisId = pf.PessoaFisId,
                Nome = pf.Nome,
                Titulo = pf.Titulo,
                Genero = pf.Genero,
                CPF = pf.CPF,
                Logradouro = pf.Logradouro,
                Complemento = pf.Complemento,
                Bairro = pf.Bairro,
                CEP = pf.CEP,
                Numero = pf.Numero,
                Cidade = pf.Cidade,
                UF = pf.UF,
                Telefone1 = pf.Telefone1,
                Telefone2 = pf.Telefone2,
                Email = pf.Email
            };
        }

        public static PessoaFis UnConvertFromDto(this PessoaFisDto pfdto)
        {

            return new PessoaFis
            {
                PessoaFisId = pfdto.PessoaFisId,
                Nome = pfdto.Nome,
                Titulo= pfdto.Titulo,
                Genero = pfdto.Genero,
                CPF = pfdto.CPF,
                Logradouro = pfdto.Logradouro,
                Complemento = pfdto.Complemento,
                Bairro = pfdto.Bairro,
                CEP = pfdto.CEP,
                Numero = pfdto.Numero,
                Cidade = pfdto.Cidade,
                UF = pfdto.UF,
                Telefone1 = pfdto.Telefone1,
                Telefone2 = pfdto.Telefone2,
                Email = pfdto.Email
            };
        }
    }
}
