using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IRelatorRepository
    {
        Task<IEnumerable<Relator>> ListAll();
        Task<Relator> OneId(int id);
        Task<Relator> Add(Relator relator);
        Task<Relator> Delete(int id);
        Task<Relator> Update(int id, Relator relator);
    }
}
