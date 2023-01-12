using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IRelatorRepository
    {
        Task<IEnumerable<Relator>> GetAll();
        Task<Relator> GetOne(int id);
        Task<Relator> Add(Relator relator);
        Task<Relator> Delete(int id);
        Task<Relator> Update(int id, Relator relator);
    }
}
