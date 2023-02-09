using OpalaBlazor.Api.Entities;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Extensions
{
    public static class InspServAmpDtoConversion
    {
        public static IEnumerable<InspecaoServAmpDto> ConvertToAmpDto(this IEnumerable<InspecaoServidor> inspservs,
            IEnumerable<Inspecao> inspecoes, IEnumerable<Servidor> servidores)
        {

            return (from inspserv in inspservs
                    join inspecao in inspecoes
                    on inspserv.InspecaoId equals inspecao.InspecaoId
                    join servidor in servidores
                    on inspserv.ServidorId equals servidor.ServidorId
                    select new InspecaoServAmpDto
                    {
                        InspecaoId = inspserv.InspecaoId,
                        Numero = inspecao.Numero,
                        ServidorId = inspserv.ServidorId,
                        Nome = servidor.Nome,
                        Matricula = servidor.Matricula,
                        Setor = inspserv.Setor,
                        Funcao= inspserv.Funcao
                    }).ToList();
        }

        public static InspecaoServAmpDto ConvertToAmpDto(this InspecaoServidor inspserv,
            Inspecao inspecao, Servidor servidor)
        {

            return new InspecaoServAmpDto
            {
                InspecaoId = inspserv.InspecaoId,
                Numero = inspecao.Numero,
                ServidorId = inspserv.ServidorId,
                Nome = servidor.Nome,
                Matricula = servidor.Matricula,
                Setor = inspserv.Setor,
                Funcao = inspserv.Funcao
            };
        }

    }
}
