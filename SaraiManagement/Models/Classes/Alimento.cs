using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public class Alimento: ItemDoado
    {
        public DateTime dataValidade { get; set; }
    }
}
