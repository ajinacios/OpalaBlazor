using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Server.Services.Contracts
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioDto>> GetListAll();
        Task<UsuarioDto> GetOneId(int id);
        Task<UsuarioDto> GetOneLogin(string login);
    }
}
