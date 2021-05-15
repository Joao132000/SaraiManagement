using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models.ViewModels
{
    public class MovimentacaoListViewModel
    {
        public IEnumerable<Movimentacao> Movimentacaos { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
