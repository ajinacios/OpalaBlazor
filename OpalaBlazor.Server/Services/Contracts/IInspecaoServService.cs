using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Server.Services.Contracts
{
    public interface IInspecaoServService
    {
        Task<List<InspecaoServAmpDto>> GetListAll();
        Task<List<InspecaoServidorDto>> GetListInspecao(int insp);
        Task<List<InspecaoServAmpDto>> GetListInspAmp(int insp);
        Task<List<InspecaoServidorDto>> GetListServidor(int serv);
        Task<List<InspecaoServAmpDto>> GetListServAmp(int serv);
    }
}
