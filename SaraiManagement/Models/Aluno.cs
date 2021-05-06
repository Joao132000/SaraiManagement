using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Escola { get; set; }
        public Enum Ano { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string NomeResponsavel { get; set; }
        public int DonatarioID { get; set; }
        public string Período { get; set; }
        public DateTime Admissao { get; set; }
    }
}
