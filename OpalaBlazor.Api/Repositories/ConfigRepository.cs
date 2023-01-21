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
                var result = opalaDbContext.Add(config);
                await this.opalaDbContext.SaveChangesAsync();
                //return result.Entity;
            }
            return config;
        }

        public async Task<Config> Delete(int id)
        {
            var config = opalaDbContext.config.FirstOrDefault(x => x.ConfigId == id);
            opalaDbContext.Remove(config);
            await this.opalaDbContext.SaveChangesAsync();
            return config;
        }

        public async Task<IEnumerable<Config>> ListAll()
        {
            var config = opalaDbContext.config.ToArray();
            return config;
        }

        public async Task<Config> OneId(int id)
        {
            // var config =  opalaDbContext.config.FirstOrDefault(x => x.ConfigId == id);
            var config = await opalaDbContext.config.FindAsync(id);
            if (config == null)
            {
                return config;
            }
            else
            {
                return config;
            }
        }

        public async Task<Config> Update(int id, Config config)
        {
            opalaDbContext.Update(config);
            await this.opalaDbContext.SaveChangesAsync();
            return config;
        }
    }
}
