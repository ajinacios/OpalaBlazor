using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Server.Services.Contracts
{
    public interface IInspecaoService
    {
        Task<List<InspecaoDto>> GetListAll();
        Task<InspecaoDto> GetOneId(int id);
        Task<InspecaoDto> GetOneNumero(string numero);
    }
}
