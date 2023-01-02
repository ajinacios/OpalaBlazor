using System.ComponentModel.DataAnnotations;

namespace OpalaBlazor.Api.Entities
{
    public class Config
    {
        [Key]
        public int ConfigId { get; set; }
        [StringLength(100)]
        public string? Entidade { get; set; }
        [StringLength(20)]
        public string? Sigla { get; set; }
        [StringLength(50)]
        public string? Setor { get; set; }
        [StringLength(20)]
        public string? SiglaSetor { get; set; }
        [StringLength(50)]
        public string? TitularSetor { get; set; }
        [StringLength(50)]
        public string? Secretaria { get; set; }
        [StringLength(20)]
        public string? SiglaSecretaria { get; set; }
        [StringLength(20)]
        public string? TitularSecretaria { get; set; }
    }
}
