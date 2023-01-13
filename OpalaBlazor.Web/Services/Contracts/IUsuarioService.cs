using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Web.Services.Contracts
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioDto>> GetListAll();
        Task<UsuarioDto> GetOneId(int id);
        Task<UsuarioDto> GetOneLogin(string login);
    }
}
