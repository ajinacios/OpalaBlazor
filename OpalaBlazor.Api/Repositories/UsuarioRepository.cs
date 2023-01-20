using Microsoft.EntityFrameworkCore;
using OpalaBlazor.Api.Data;
using OpalaBlazor.Api.Entities;
using OpalaBlazor.Api.Repositories.Contracts;
using System.Collections;

namespace OpalaBlazor.Api.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly OpalaDbContext opalaDbContext;

        public UsuarioRepository(OpalaDbContext opalaDbContext)
        {
            this.opalaDbContext = opalaDbContext;
        }
        public async Task<Usuario> Add(Usuario usuario)
        {
            if (usuario.UsuarioId == 0)
            {
                var result = opalaDbContext.Add(usuario);
                await this.opalaDbContext.SaveChangesAsync();
                usuario = opalaDbContext.usuarios.FirstOrDefault(x => x.Nome == usuario.Nome);
                //return result.Entity;
            }
            return usuario;
        }

        public async Task<Usuario> Delete(int id)
        {
            var usuario = opalaDbContext.usuarios.FirstOrDefault(x => x.UsuarioId == id);
            opalaDbContext.Remove(usuario);
            await this.opalaDbContext.SaveChangesAsync();
            return usuario;
        }

        public IEnumerable<Usuario> ListAll()
        {
            var usuarios = opalaDbContext.usuarios.ToArray();
            return usuarios;
        }

        public async Task<Usuario> OneId(int id)
        {
           // var usuario =  opalaDbContext.usuarios.FirstOrDefault(x => x.UsuarioId == id);
            var usuario = await opalaDbContext.usuarios.FindAsync(id); 
            if (usuario == null)
            {
                return usuario;
            }
            else
            {
                return usuario;
            }

        }

        public async Task<Usuario> OneLogin(string login)
        {
            //var usuario = await opalaDbContext.usuarios.FindAsync(login);
            var usuario = opalaDbContext.usuarios.FirstOrDefault(x => x.Login == login);
            if (usuario == null)
            {
                return new Usuario();
            }
            else
            {
                return usuario;
            }
        }

        public async Task<Usuario> OneNome(string nome)
        {
            var usuario = opalaDbContext.usuarios.FirstOrDefault(x => x.Nome == nome);
            if (usuario == null)
            {
                return new Usuario();
            }
            else
            {
                return usuario;
            }
        }

        public async Task<Usuario> Update(Usuario usuario)
        {
            opalaDbContext.Update(usuario);
            await this.opalaDbContext.SaveChangesAsync();
            return usuario;
        }
    }
}

