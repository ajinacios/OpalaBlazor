using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IProcessoRepository
    {
        Task<IEnumerable<Processo>> ListAll();
        Task<Processo> OneId(int id);
        Task<Processo> Add(Processo processo);
        Task<Processo> Delete(int id);
        Task<Processo> Update(int id, Processo processo);
    }
}
