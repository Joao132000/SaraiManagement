using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public class ItemDoado
    {
        public int ItemID { get; set; }
        public string Nome { get; set; }
        public Enum Categoria { get; set; }
        public int Quantidade { get; set; }

        public Doacao Doacao { get; set; }
    }
}
