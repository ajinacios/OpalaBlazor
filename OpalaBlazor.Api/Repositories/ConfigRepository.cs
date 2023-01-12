using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Repositories.Contracts;

namespace OpalaBlazor.Api.Repositories
{
    public class ConfigRepository : IConfigRepository
    {
        private readonly OpalaDbContext opalaDbContext;

        public ConfigRepository(OpalaDbContext opalaDbContext)
        {
            this.opalaDbContext = opalaDbContext;
        }

        public async Task<Config> Add(Config config)
        {
            if (config.ConfigId == 0)
            {
                opalaDbContext.Add(config);
                await this.opalaDbContext.SaveChangesAsync();
                return result.Entity;
            }
            else
            {
                return config;
            }
        }

        public Task<Config> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Config>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Config> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Config> Update(int id, Config config)
        {
            throw new NotImplementedException();
        }
    }
}
