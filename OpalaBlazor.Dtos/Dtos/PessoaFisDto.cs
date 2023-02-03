using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpalaBlazor.Models.Dtos
{
    public class PessoaFisDto
    {
        public int PessoaFisId { get; set; }
        public string? Nome { get; set; }
        public string? Titulo { get; set; }
        public string? Genero { get; set; }
        public string? CPF { get; set; }
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? CEP { get; set; }
        public string? Numero { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public string? Telefone1 { get; set; }
        public string? Telefone2 { get; set; }
        public string? Email { get; set; }
    }
}
