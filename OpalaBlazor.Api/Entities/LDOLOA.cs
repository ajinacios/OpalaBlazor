using System.ComponentModel.DataAnnotations;

namespace OpalaBlazor.Api.Entities
{
    public class LDOLOA
    {
        [Key]
        public int LDOLOAId { get; set; }
        [StringLength(20)]
        public string? Tipo { get; set; }
        public int Ano  { get; set; }
        [StringLength(50)]
        public string? Lei { get; set; }

    }
}
