using OpalaBlazor.Api.Entities;
using OpalaBlazor.Models.Dtos;

namespace OpalaBlazor.Api.Extensions
{
    public static class UsuarioDtoConversion
    {

        public static IEnumerable<UsuarioDto> ConvertToDto(this IEnumerable<Usuario> usuarios)
        {

            return (from usuario in usuarios
                    select new UsuarioDto
                    {
                        UsuarioId = usuario.UsuarioId,
                        Nome = usuario.Nome,
                        Login = usuario.Login,
                        Senha = usuario.Senha,
                        Ativo = usuario.Ativo,
                        Cargo = usuario.Cargo
                    }).ToList();
        }

        public static UsuarioDto ConvertToDto(this Usuario usuario)
        {

            return new UsuarioDto
            {
                UsuarioId = usuario.UsuarioId,
                Nome = usuario.Nome,
                Login = usuario.Login,
                Senha = usuario.Senha,
                Ativo = usuario.Ativo,
                Cargo = usuario.Cargo
            };
        }
    }
}
