using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //


namespace SaraiManagement.Models
{
    public class Outros: ItemDoado
    {
        [Required] //CAMPO 'Descrição' OBRIGATÓRIO
        public string Descricao { get; set; }
    }
}
