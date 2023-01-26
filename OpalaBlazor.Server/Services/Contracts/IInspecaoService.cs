using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Server.Services.Contracts
{
    public interface IInspecaoService
    {
        Task<IEnumerable<InspecaoDto>> GetListAll();
        Task<InspecaoDto> GetOneId(int id);
        Task<InspecaoDto> GetOneNumero(string numero);
    }
}
