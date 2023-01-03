using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IUsuario
    {
        Task<IEnumerable<Usuario>> GetAll();
        Task<Usuario> GetOne(int id);
        Task<Usuario> Add(Usuario usuario);
        Task<Usuario> Delete(int id);
        Task<Usuario> Update(int id, Usuario usuario);
    }
}
