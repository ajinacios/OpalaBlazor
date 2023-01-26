using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IInspecaoRepository
    {
        IEnumerable<Inspecao> ListAll();
        Task<Inspecao> OneId(int id);
        Task<Inspecao> OneNumero(string numero);
        Task<Inspecao> Add(Inspecao inspecao);
        Task<Inspecao> Delete(int id);
        Task<Inspecao> Update(int id, Inspecao inspecao);
    }
}
