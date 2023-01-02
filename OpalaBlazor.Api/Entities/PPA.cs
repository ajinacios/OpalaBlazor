using System.ComponentModel.DataAnnotations;

namespace OpalaBlazor.Api.Entities
{
    public class PPA
    {
        [Key]
        public int PPAId { get; set; }
        public int AnoInicial { get; set; }
        public int AnoFinal { get; set; }
        [StringLength(50)]
        public string? Lei { get; set; }
    }
}
