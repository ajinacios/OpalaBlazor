using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IConfig
    {
        Task<IEnumerable<Config>> GetAll();
        Task<Config> GetOne(int id);
    }
}
