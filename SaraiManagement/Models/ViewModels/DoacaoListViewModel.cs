using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models.ViewModels
{
    public class DoacaoListViewModel
    {
        public IEnumerable<Doacao> Doacaos { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}
