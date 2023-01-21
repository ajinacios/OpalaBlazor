using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Repositories.Contracts;

namespace OpalaBlazor.Api.Repositories
{
    public class PessoaJurRepository : IPessoaJurRepository
    {
        private readonly OpalaDbContext opalaDbContext;

        public PessoaJurRepository(OpalaDbContext opalaDbContext)
        {
            this.opalaDbContext = opalaDbContext;
        }

        public async Task<PessoaJur> Add(PessoaJur pessoaJur)
        {
            if (pessoaJur.PessoaJurId == 0)
            {
                var result = opalaDbContext.Add(pessoaJur);
                await this.opalaDbContext.SaveChangesAsync();
                pessoaJur = opalaDbContext.pessoasJur.FirstOrDefault(x => x.Nome == pessoaJur.Nome);
                //return result.Entity;
            }
            return pessoaJur;
        }

        public async Task<PessoaJur> Delete(int id)
        {
            var pessoaJur = opalaDbContext.pessoasJur.FirstOrDefault(x => x.PessoaJurId == id);
            opalaDbContext.Remove(pessoaJur);
            await this.opalaDbContext.SaveChangesAsync();
            return pessoaJur;
        }

        public async Task<IEnumerable<PessoaJur>> ListAll()
        {
            var pessoasJur = opalaDbContext.pessoasJur.ToArray();
            return pessoasJur;
        }

        public async Task<PessoaJur> OneId(int id)
        {
            // var usuario =  opalaDbContext.pessoasJur.FirstOrDefault(x => x.PessoaJurId == id);
            var pessoaJur = await opalaDbContext.pessoasJur.FindAsync(id);
            if (pessoaJur == null)
            {
                return pessoaJur;
            }
            else
            {
                return pessoaJur;
            }
        }

        public async Task<PessoaJur> Update(int id, PessoaJur pessoaJur)
        {
            opalaDbContext.Update(pessoaJur);
            await this.opalaDbContext.SaveChangesAsync();
            return pessoaJur;
        }
    }
}
