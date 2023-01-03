using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IProcesso
    {
        Task<IEnumerable<Processo>> GetAll();
        Task<Processo> GetOne(int id);
        Task<Processo> Add(Processo processo);
        Task<Processo> Delete(int id);
        Task<Processo> Update(int id, Processo processo);
    }
}
