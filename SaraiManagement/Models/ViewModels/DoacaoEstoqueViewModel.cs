using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models.ViewModels
{
    public class DoacaoEstoqueViewModel
    {
        public Doacao Doacao { get; set; }
        public ItemDoado ItemDoados { get; set; }
    }
}
