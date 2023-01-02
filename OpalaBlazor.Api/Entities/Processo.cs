using System.ComponentModel.DataAnnotations;

namespace OpalaBlazor.Api.Entities
{
    public class Processo
    {
        [Key]
        public int ProcessoId { get; set; }
        [StringLength(12)]
        public string? Numero { get; set; }
        [StringLength(50)]
        public string? Natureza { get; set; }
        public string? Objeto { get; set; }
        public int? Relator { get; set; }
        public int? PessoaJur { get; set; }

    }
}
