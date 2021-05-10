using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //

namespace SaraiManagement.Models
{
    public class Dinheiro: ItemDoado
    {
        [Required] //CAMPO 'Valor' OBRIGATÓRIO
        public double Valor { get; set; }
    }
}
