using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Repositories.Contracts;

namespace OpalaBlazor.Api.Repositories
{
    public class PPARepository : IPPARepository
    {
        private readonly OpalaDbContext opalaDbContext;

        public PPARepository(OpalaDbContext opalaDbContext)
        {
            this.opalaDbContext = opalaDbContext;
        }
        public async Task<PPA> Add(PPA ppa)
        {
            if (ppa.PPAId == 0)
            {
                var result = opalaDbContext.Add(ppa);
                await this.opalaDbContext.SaveChangesAsync();
                ppa = opalaDbContext.ppas.FirstOrDefault(x => x.Lei == ppa.Lei);
                //return result.Entity;
            }
            return ppa;
        }

        public async Task<PPA> Delete(int id)
        {
            var ppa = opalaDbContext.ppas.FirstOrDefault(x => x.PPAId == id);
            opalaDbContext.Remove(ppa);
            await this.opalaDbContext.SaveChangesAsync();
            return ppa;
        }

        public async Task<IEnumerable<PPA>> ListAll()
        {
            var ppas = opalaDbContext.ppas.ToArray();
            return ppas;
        }

        public async Task<PPA> OneId(int id)
        {
            // var ppa =  opalaDbContext.ppas.FirstOrDefault(x => x.PPAId == id);
            var ppa = await opalaDbContext.ppas.FindAsync(id);
            if (ppa == null)
            {
                return ppa;
            }
            else
            {
                return ppa;
            }
        }

        public async Task<PPA> Update(int id, PPA ppa)
        {
            opalaDbContext.Update(ppa);
            await this.opalaDbContext.SaveChangesAsync();
            return ppa;
        }
    }
}
