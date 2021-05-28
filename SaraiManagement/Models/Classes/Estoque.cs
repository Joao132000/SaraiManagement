using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SaraiManagement.Models.Enuns;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaraiManagement.Models
{
    public class Estoque
    {
        public int EstoqueID { get; set; }
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public Categoria Categoria { get; set; }
        
  

    }
}