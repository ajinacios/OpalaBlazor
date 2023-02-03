using OpalaBlazor.Api.Entities;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Extensions
{
    public static class ServidorMinDtoConversion
    {
        public static IEnumerable<ServidorMinDto> ConvertToDtoMin(this IEnumerable<Servidor> servidores)
        {

            return (from servidor in servidores
                    select new ServidorMinDto
                    {
                        ServidorId = servidor.ServidorId,
                        Nome = servidor.Nome,
                        Matricula = servidor.Matricula,
                        CPF = servidor.CPF
                    }).ToList();
        }

        public static ServidorMinDto ConvertToDtoMin(this Servidor servidor)
        {

            return new ServidorMinDto
            {
                ServidorId = servidor.ServidorId,
                Nome = servidor.Nome,
                Matricula = servidor.Matricula,
                CPF = servidor.CPF,
            };
        }

    }
}
