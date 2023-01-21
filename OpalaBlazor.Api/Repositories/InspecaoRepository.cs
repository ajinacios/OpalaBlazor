using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Repositories.Contracts;

namespace OpalaBlazor.Api.Repositories
{
    public class InspecaoRepository : IInspecaoRepository
    {
        private readonly OpalaDbContext opalaDbContext;

        public InspecaoRepository(OpalaDbContext opalaDbContext)
        {
            this.opalaDbContext = opalaDbContext;
        }
        public async Task<Inspecao> Add(Inspecao inspecao)
        {
            if (inspecao.InspecaoId == 0)
            {
                var result = opalaDbContext.Add(inspecao);
                await this.opalaDbContext.SaveChangesAsync();
                inspecao = opalaDbContext.inspecoes.FirstOrDefault(x => x.Portaria == inspecao.Portaria);
            }
            return inspecao;
        }

        public async Task<Inspecao> Delete(int id)
        {
            var inspecao = opalaDbContext.inspecoes.FirstOrDefault(x => x.InspecaoId == id);
            opalaDbContext.Remove(inspecao);
            await this.opalaDbContext.SaveChangesAsync();
            return inspecao;
        }

        public Task<IEnumerable<Inspecao>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Inspecao> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Inspecao>> ListAll()
        {
            var inspecoes = opalaDbContext.inspecoes.ToArray();
            return inspecoes;
        }

        public async Task<Inspecao> OneId(int id)
        {
            // var inspecao =  opalaDbContext.inspecoes.FirstOrDefault(x => x.InspecaoId == id);
            var inspecao = await opalaDbContext.inspecoes.FindAsync(id);
            if (inspecao == null)
            {
                return inspecao;
            }
            else
            {
                return inspecao;
            }
        }

        public async Task<Inspecao> Update(int id, Inspecao inspecao)
        {
            opalaDbContext.Update(inspecao);
            await this.opalaDbContext.SaveChangesAsync();
            return inspecao;
        }
    }
}
