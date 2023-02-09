using System.ComponentModel.DataAnnotations;

namespace OpalaBlazor.Api.Entities
{
    public class InspecaoServidor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int InspecaoId { get; set; }
        [Required]
        public int ServidorId { get; set; }
        [Required]
        [StringLength(8)]
        public string Setor { get; set; }
        [Required]
        [StringLength(1)]
        public string Funcao { get; set; }
    }
}
