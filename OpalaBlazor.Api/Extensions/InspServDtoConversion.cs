using OpalaBlazor.Api.Entities;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Extensions
{
    public static class InspServDtoConversion
    {
        public static IEnumerable<InspecaoServidorDto> ConvertToDto(this IEnumerable<InspecaoServidor> inspservs)
        {

            return (from inspserv in inspservs
                    select new InspecaoServidorDto
                    {
                        ServidorId = inspserv.ServidorId,
                        InspecaoId = inspserv.InspecaoId,
                        Setor = inspserv.Setor,
                        Funcao = inspserv.Funcao
                    }).ToList();
        }

        public static InspecaoServidorDto ConvertToDto(this InspecaoServidor inspserv)
        {

            return new InspecaoServidorDto
            {
                ServidorId = inspserv.ServidorId,
                InspecaoId = inspserv.InspecaoId,
                Setor = inspserv.Setor,
                Funcao = inspserv.Funcao
            };
        }

        public static InspecaoServidor UnConvertFromDto(this InspecaoServidorDto inspservdto)
        {

            return new InspecaoServidor
            {
                ServidorId = inspservdto.ServidorId,
                InspecaoId = inspservdto.InspecaoId,
                Setor = inspservdto.Setor,
                Funcao = inspservdto.Funcao
            };
        }
    }
}
