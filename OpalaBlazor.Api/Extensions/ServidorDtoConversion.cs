using OpalaBlazor.Api.Entities;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Extensions
{
    public static class ServidorDtoConversion
    {
        public static IEnumerable<ServidorDto> ConvertToDto(this IEnumerable<Servidor> servidores)
        {

            return (from servidor in servidores
                    select new ServidorDto
                    {
                        ServidorId = servidor.ServidorId,
                        Nome = servidor.Nome,
                        Cargo= servidor.Cargo,
                        Matricula= servidor.Matricula,
                        Genero= servidor.Genero,
                        CPF= servidor.CPF,
                        Logradouro = servidor.Logradouro,
                        Complemento = servidor.Complemento,
                        Bairro = servidor.Bairro,
                        CEP = servidor.CEP,
                        Numero = servidor.Numero,
                        Cidade = servidor.Cidade,
                        UF = servidor.UF,
                        Telefone1 = servidor.Telefone1,
                        Telefone2 = servidor.Telefone2,
                        Email = servidor.Email
                    }).ToList();
        }

        public static ServidorDto ConvertToDto(this Servidor servidor)
        {

            return new ServidorDto
            {
                ServidorId = servidor.ServidorId,
                Nome = servidor.Nome,
                Cargo = servidor.Cargo,
                Matricula = servidor.Matricula,
                Genero = servidor.Genero,
                CPF = servidor.CPF,
                Logradouro = servidor.Logradouro,
                Complemento = servidor.Complemento,
                Bairro = servidor.Bairro,
                CEP = servidor.CEP,
                Numero = servidor.Numero,
                Cidade = servidor.Cidade,
                UF = servidor.UF,
                Telefone1 = servidor.Telefone1,
                Telefone2 = servidor.Telefone2,
                Email = servidor.Email
            };
        }

        public static Servidor UnConvertFromDto(this ServidorDto servidordto)
        {

            return new Servidor
            {
                ServidorId = servidordto.ServidorId,
                Nome = servidordto.Nome,
                Cargo = servidordto.Cargo,
                Matricula = servidordto.Matricula,
                Genero = servidordto.Genero,
                CPF = servidordto.CPF,
                Logradouro = servidordto.Logradouro,
                Complemento = servidordto.Complemento,
                Bairro = servidordto.Bairro,
                CEP = servidordto.CEP,
                Numero = servidordto.Numero,
                Cidade = servidordto.Cidade,
                UF = servidordto.UF,
                Telefone1 = servidordto.Telefone1,
                Telefone2 = servidordto.Telefone2,
                Email = servidordto.Email
            };
        }
    }
}
