using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IServidorRepository
    {
        Task<IEnumerable<Servidor>> GetAll();
        Task<Servidor> GetOne(int id);
        Task<Servidor> Add(Servidor servidor);
        Task<Servidor> Delete(int id);
        Task<Servidor> Update(int id, Servidor servidor);
    }
}
