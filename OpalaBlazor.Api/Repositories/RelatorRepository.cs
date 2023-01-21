using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Repositories.Contracts;

namespace OpalaBlazor.Api.Repositories
{
    public class RelatorRepository : IRelatorRepository
    {
        private readonly OpalaDbContext opalaDbContext;

        public RelatorRepository(OpalaDbContext opalaDbContext)
        {
            this.opalaDbContext = opalaDbContext;
        }

        public async Task<Relator> Add(Relator relator)
        {
            if (relator.RelatorId == 0)
            {
                var result = opalaDbContext.Add(relator);
                await this.opalaDbContext.SaveChangesAsync();
                relator = opalaDbContext.relatores.FirstOrDefault(x => x.Nome == relator.Nome);
                //return result.Entity;
            }
            return relator;
        }

        public async Task<Relator> Delete(int id)
        {
            var relator = opalaDbContext.relatores.FirstOrDefault(x => x.RelatorId == id);
            opalaDbContext.Remove(relator);
            await this.opalaDbContext.SaveChangesAsync();
            return relator;
        }

        public async Task<IEnumerable<Relator>> ListAll()
        {
            var relatores = opalaDbContext.relatores.ToArray();
            return relatores;
        }

        public async Task<Relator> OneId(int id)
        {
            // var relator =  opalaDbContext.relatores.FirstOrDefault(x => x.RelatorId == id);
            var relator = await opalaDbContext.relatores.FindAsync(id);
            if (relator == null)
            {
                return relator;
            }
            else
            {
                return relator;
            }
        }

        public async Task<Relator> Update(int id, Relator relator)
        {
            opalaDbContext.Update(relator);
            await this.opalaDbContext.SaveChangesAsync();
            return relator;
        }
    }
}
