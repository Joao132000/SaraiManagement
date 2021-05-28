using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models;

namespace SaraiManagement.Models.ViewModels
{
    public class ItemEstoqueListViewModel
    {
        public IEnumerable<ItemDoado> ItemDoados { get; set; }

        public Estoque Estoque { get; set; }

    }
}
