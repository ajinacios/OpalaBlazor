using System.ComponentModel.DataAnnotations;

namespace OpalaBlazor.Api.Entities
{
    public class InspecaoResp
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int InspecaoId { get; set; }
        [Required]
        public int PessoaFisId { get; set; }
        [Required]
        [StringLength(50)]
        public string Cargo { get; }
        [Required]
        [StringLength(50)]
        public string Resp { get; }
    }
}
