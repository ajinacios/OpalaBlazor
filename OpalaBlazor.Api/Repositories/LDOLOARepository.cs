using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Repositories.Contracts;

namespace OpalaBlazor.Api.Repositories
{
    public class LDOLOARepository : ILDOLOARepository
    {
        private readonly OpalaDbContext opalaDbContext;

        public LDOLOARepository(OpalaDbContext opalaDbContext)
        {
            this.opalaDbContext = opalaDbContext;
        }

        public async Task<LDOLOA> Add(LDOLOA ldoloa)
        {
            if (ldoloa.LDOLOAId == 0)
            {
                var result = opalaDbContext.Add(ldoloa);
                await this.opalaDbContext.SaveChangesAsync();
                ldoloa = opalaDbContext.ldoloas.FirstOrDefault(x => x.Lei == ldoloa.Lei);
                //return result.Entity;
            }
            return ldoloa;
        }

        public async Task<LDOLOA> Delete(int id)
        {
            var ldoloa = opalaDbContext.ldoloas.FirstOrDefault(x => x.LDOLOAId == id);
            opalaDbContext.Remove(ldoloa);
            await this.opalaDbContext.SaveChangesAsync();
            return ldoloa;
        }

        public async Task<IEnumerable<LDOLOA>> ListAll()
        {
            var ldoloas = opalaDbContext.ldoloas.ToArray();
            return ldoloas;
        }

        public async Task<LDOLOA> OneId(int id)
        {
            // var ldoloa =  opalaDbContext.ldoloas.FirstOrDefault(x => x.LDOLOAId == id);
            var ldoloa = await opalaDbContext.ldoloas.FindAsync(id);
            if (ldoloa == null)
            {
                return ldoloa;
            }
            else
            {
                return ldoloa;
            }
        }

        public async Task<LDOLOA> Update(int id, LDOLOA ldoloa)
        {
            opalaDbContext.Update(ldoloa);
            await this.opalaDbContext.SaveChangesAsync();
            return ldoloa;
        }
    }
}
