using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpalaBlazor.Models.Dtos
{
    public class PessoaFisMinDto
    {
        public int PessoaFisId { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
    }
}
