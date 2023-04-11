using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IInspecaoServRepository
    {
        IEnumerable<InspecaoServidor> ListAll();
        IEnumerable<InspecaoServidor> ListPorInspecao(int idinspecao);
        IEnumerable<InspecaoServidor> ListPorServidor(int idservidor);
    }
}
