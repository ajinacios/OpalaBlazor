using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IInspecaoServidor
    {
        IEnumerable<InspecaoServidor> ListPorInspecao(int idinspecao);
        IEnumerable<InspecaoServidor> ListPorServidor(int idservidor);
    }
}
