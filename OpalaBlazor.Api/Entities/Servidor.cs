using System.ComponentModel.DataAnnotations;

namespace OpalaBlazor.Api.Entities
{
    public class Servidor
    {
        [Key]
        public int ServidorId { get; set; }
        [StringLength(100)]
        public string? Nome { get; set; }
        [StringLength(50)]
        public string? Cargo { get; set; }
        [StringLength(10)]
        public string? Matricula { get; set; }
        [StringLength(1)]
        public string? Genero { get; set; }
        [StringLength(11)]
        public string? CPF { get; set; }
        [StringLength(150)]
        public string? Logradouro { get; set; }
        [StringLength(100)]
        public string? Complemento { get; set; }
        [StringLength(50)]
        public string? Bairro { get; set; }
        [StringLength(9)]
        public string? CEP { get; set; }
        [StringLength(10)]
        public string? Numero { get; set; }
        [StringLength(50)]
        public string? Cidade { get; set; }
        [StringLength(2)]
        public string? UF { get; set; }
        [StringLength(20)]
        public string? Telefone1 { get; set; }
        [StringLength(20)]
        public string? Telefone2 { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
    }
}
