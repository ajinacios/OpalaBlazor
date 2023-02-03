using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Repositories.Contracts;

namespace OpalaBlazor.Api.Repositories
{
    public class ServidorRepository : IServidorRepository
    {
        private readonly OpalaDbContext opalaDbContext;

        public ServidorRepository(OpalaDbContext opalaDbContext)
        {
            this.opalaDbContext = opalaDbContext;
        }

        public async Task<Servidor> Add(Servidor servidor)
        {
            if (servidor.ServidorId == 0)
            {
                var result = opalaDbContext.Add(servidor);
                await this.opalaDbContext.SaveChangesAsync();
                servidor = opalaDbContext.servidores.FirstOrDefault(x => x.Nome == servidor.Nome);
                //return result.Entity;
            }
            return servidor;
        }

        public async Task<Servidor> Delete(int id)
        {
            var servidor = opalaDbContext.servidores.FirstOrDefault(x => x.ServidorId == id);
            opalaDbContext.Remove(servidor);
            await this.opalaDbContext.SaveChangesAsync();
            return servidor;
        }

        public IEnumerable<Servidor> ListAll()
        {
            var servidores = opalaDbContext.servidores.ToArray();
            return servidores;
        }

        public async Task<Servidor> OneId(int id)
        {
            // var servidor =  opalaDbContext.servidores.FirstOrDefault(x => x.ServidorId == id);
            var servidor = await opalaDbContext.servidores.FindAsync(id);
            if (servidor == null)
            {
                return servidor;
            }
            else
            {
                return servidor;
            }
        }

        public async Task<Servidor> Update(int id, Servidor servidor)
        {
            opalaDbContext.Update(servidor);
            await this.opalaDbContext.SaveChangesAsync();
            return servidor;
        }
    }
}
