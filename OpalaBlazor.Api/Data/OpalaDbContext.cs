using Microsoft.EntityFrameworkCore;
using OpalaBlazor.Api.Entities;

namespace OpalaBlazor.Api.Data
{
    public class OpalaDbContext : DbContext
    {
        //internal object pessoasFis;

        public OpalaDbContext(DbContextOptions<OpalaDbContext> options) : base(options) { }
        public DbSet<Config>? config { get; set; }
        public DbSet<Inspecao>? inspecoes { get; set; }
        public DbSet<LDOLOA>? ldoloas { get; set; }
        public DbSet<PessoaFis>? pessoasfis { get; set; }
        public DbSet<PessoaJur>? pessoasjur { get; set; }
        public DbSet<PPA>? ppas { get; set; }
        public DbSet<Processo>? processos { get; set; }
        public DbSet<Relator>? relatores { get; set; }
        public DbSet<Servidor>? servidores { get; set; }
        public DbSet<Usuario>? usuarios { get; set; }
        public DbSet<InspecaoServidor>? inspecaoservidor { get; set; }
        public DbSet<InspecaoResp>? inspecaoresps { get; set; }
    }
}

// Add-Migration InitialCreate
// Update-Database

// Toda tabela tem que ter Id, mesmo as de ligação
