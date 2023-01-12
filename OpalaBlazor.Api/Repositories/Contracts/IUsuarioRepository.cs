using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> ListAll();
        Task<Usuario> OneId(int id);
        Task<Usuario> OneNome(string nome);
        Task<Usuario> OneLogin(string login);
        Task<Usuario> Add(Usuario usuario);
        Task<Usuario> Delete(int id);
        Task<Usuario> Update(Usuario usuario);
    }
}
