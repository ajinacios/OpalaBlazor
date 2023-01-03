using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IInspecao
    {
        Task<IEnumerable<Inspecao>> GetAll();
        Task<Inspecao> GetOne(int id);
        Task<Inspecao> Add(Inspecao inspecao);
        Task<Inspecao> Delete(int id);
        Task<Inspecao> Update(int id, Inspecao inspecao);
    }
}
