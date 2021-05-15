using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models.ViewModels
{
    public class DonatarioListViewModel
    {
        public IEnumerable<Donatario> Donatarios { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
