using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Repositories.Contracts;

namespace OpalaBlazor.Api.Repositories
{
    public class PessoaFisRepository : IPessoaFisRepository
    {
        private readonly OpalaDbContext opalaDbContext;

        public PessoaFisRepository(OpalaDbContext opalaDbContext)
        {
            this.opalaDbContext = opalaDbContext;
        }

        public async Task<PessoaFis> Add(PessoaFis pessoaFis)
        {
            if (pessoaFis.PessoaFisId == 0)
            {
                var result = opalaDbContext.Add(pessoaFis);
                await this.opalaDbContext.SaveChangesAsync();
                pessoaFis = opalaDbContext.pessoasfis.FirstOrDefault(x => x.Nome == pessoaFis.Nome);
                //return result.Entity;
            }
            return pessoaFis;
        }

        public async Task<PessoaFis> Delete(int id)
        {
            var pessoaFis = opalaDbContext.pessoasfis.FirstOrDefault(x => x.PessoaFisId == id);
            opalaDbContext.Remove(pessoaFis);
            await this.opalaDbContext.SaveChangesAsync();
            return pessoaFis;
        }

        public IEnumerable<PessoaFis> ListAll()
        {
            var pessoasfis = opalaDbContext.pessoasfis.ToArray();
            return pessoasfis;
        }

        public async Task<PessoaFis> OneId(int id)
        {
            // var pessoaFis =  opalaDbContext.pessoasfis.FirstOrDefault(x => x.PessoaFisId == id);
            var pessoaFis = await opalaDbContext.pessoasfis.FindAsync(id);
            if (pessoaFis == null)
            {
                return pessoaFis;
            }
            else
            {
                return pessoaFis;
            }
        }

        public async Task<PessoaFis> Update(int id, PessoaFis pessoaFis)
        {
            opalaDbContext.Update(pessoaFis);
            await this.opalaDbContext.SaveChangesAsync();
            return pessoaFis;
        }
    }
}
