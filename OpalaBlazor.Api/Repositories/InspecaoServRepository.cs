using Microsoft.EntityFrameworkCore;
using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Migrations;
using OpalaBlazor.Api.Repositories.Contracts;

namespace OpalaBlazor.Api.Repositories
{
    public class InspecaoServRepository : IInspecaoServidor
    {
        private readonly OpalaDbContext opalaDbContext;

        public InspecaoServRepository(OpalaDbContext opalaDbContext)
        {
            this.opalaDbContext = opalaDbContext;
        }
        public IEnumerable<InspecaoServidor> ListPorInspecao(int idinspecao)
        {
            return opalaDbContext.inspecaoservidor.Include(x => x.InspecaoId == idinspecao);
        }

        public IEnumerable<InspecaoServidor> ListPorServidor(int idservidor)
        {
            return opalaDbContext.inspecaoservidor.Include(x => x.ServidorId == idservidor);
        }
    }
}
