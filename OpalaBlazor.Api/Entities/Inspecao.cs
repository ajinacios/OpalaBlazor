using System.ComponentModel.DataAnnotations;

namespace OpalaBlazor.Api.Entities
{

    public class Inspecao
    {
        [Key]
        public int InspecaoId { get; set; }
        [Required]
        [StringLength(4)]
        public string? Ano { get; set; }
        public DateTime Inicio { get; set;}
        public DateTime Final { get; set; }
        [StringLength(50)]
        public string? Portaria { get; set; }
        public int OrgaoId { get; set; }
    }
}
