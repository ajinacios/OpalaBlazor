using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpalaBlazor.Models.Dtos
{
    public class PPADto
    {
        public int PPAId { get; set; }

        public string? Nome { get; set; }

        public string? Login { get; set; }

        public string? Senha { get; set; }

        public string? Cargo { get; set; }

        public string? Ativo { get; set; }
    }
}
