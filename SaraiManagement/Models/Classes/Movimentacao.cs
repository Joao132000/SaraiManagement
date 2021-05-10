using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public class Movimentacao
    {
        public int MovimentacaoID { get; set; }
        public double Valor { get; set; }
        public Enum TipoMovimentacao { get; set; }
        public DateTime DiaMovimentacao { get; set; }
        public string Descricao { get; set; }

        public Usuario Usuario { get; set; }
        public Caixa Caixa { get; set; }
    }
}
