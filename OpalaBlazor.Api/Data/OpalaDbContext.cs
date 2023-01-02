using Microsoft.EntityFrameworkCore;
using OpalaBlazor.Api.Entities;
using System.Diagnostics;

namespace OpalaBlazor.Api.Data
{
    public class OpalaDbContext : DbContext
    {
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
    }
}
