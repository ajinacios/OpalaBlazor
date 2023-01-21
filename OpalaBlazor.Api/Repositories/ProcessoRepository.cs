using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Repositories.Contracts;

namespace OpalaBlazor.Api.Repositories
{
    public class ProcessoRepository : IProcessoRepository
    {
        private readonly OpalaDbContext opalaDbContext;

        public ProcessoRepository(OpalaDbContext opalaDbContext)
        {
            this.opalaDbContext = opalaDbContext;
        }
        public async Task<Processo> Add(Processo processo)
        {
            if (processo.ProcessoId == 0)
            {
                var result = opalaDbContext.Add(processo);
                await this.opalaDbContext.SaveChangesAsync();
                processo = opalaDbContext.processos.FirstOrDefault(x => x.Numero == processo.Numero);
                //return result.Entity;
            }
            return processo;
        }

        public async Task<Processo> Delete(int id)
        {
            var processo = opalaDbContext.processos.FirstOrDefault(x => x.ProcessoId == id);
            opalaDbContext.Remove(processo);
            await this.opalaDbContext.SaveChangesAsync();
            return processo;
        }

        public async Task<IEnumerable<Processo>> ListAll()
        {
            var processos = opalaDbContext.processos.ToArray();
            return processos;
        }

        public async Task<Processo> OneId(int id)
        {
            // var processo =  opalaDbContext.processos.FirstOrDefault(x => x.ProcessoId == id);
            var processo = await opalaDbContext.processos.FindAsync(id);
            if (processo == null)
            {
                return processo;
            }
            else
            {
                return processo;
            }
        }

        public async Task<Processo> Update(int id, Processo processo)
        {
            opalaDbContext.Update(processo);
            await this.opalaDbContext.SaveChangesAsync();
            return processo;
        }
    }
}
