using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public class Doacao
    {
        public int DoacaoID { get; set; }
        public int DonatarioID { get; set; }
        public DateTime dataDoacao { get; set; }
       
        public Movimentacao Movimentacao { get; set; }
        public Donatario Donatario { get; set; }

    }
}
