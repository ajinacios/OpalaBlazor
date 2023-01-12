using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Repositories.Contracts
{
    public interface IConfigRepository
    {
        Task<IEnumerable<Config>> GetAll();
        Task<Config> GetOne(int id);
        Task<Config> Add(Config config);
        Task<Config> Delete(int id);
        Task<Config> Update(int id, Config config);
    }
}
