using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public class Doador
    {
        public int DoadorID { get; set; }
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public Enum regularidadeDoador { get; set; }
        public DateTime inicioDaDoacao { get; set; }
    }
}
