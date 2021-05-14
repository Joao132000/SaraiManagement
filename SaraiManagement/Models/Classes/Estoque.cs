using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //

namespace SaraiManagement.Models
{
    public class Estoque
    {
        public int EstoqueID { get; set; }
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public ItemDoado ItemDoado { get; set; }

    }
}