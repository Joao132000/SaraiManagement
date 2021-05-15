using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models.ViewModels
{
    public class EstoqueListViewModel
    {
        public IEnumerable<Estoque> Estoques { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
