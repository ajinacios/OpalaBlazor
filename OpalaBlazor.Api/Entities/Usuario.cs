using System.ComponentModel.DataAnnotations;

namespace OpalaBlazor.Api.Entities
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [StringLength(100)]
        public string? Nome { get; set; }

        [StringLength(50)]
        public string? Login { get; set; }

        [StringLength(30)]
        public string? Senha { get; set; }

        [StringLength(100)]
        public string? Cargo { get; set; }

        [StringLength(1)]
        public string? Ativo { get; set; }
    }
}

