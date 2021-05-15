using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //
using SaraiManagement.Models.Enuns;

namespace SaraiManagement.Models
{
    public class ItemDoado
    {
        [Required]
        public int ItemDoadoID { get; set; }

       
        public int DoacaoID { get; set; }

         //CAMPO 'Categoria' OBRIGATÓRIO
        public int EstoqueID { get; set; }


        public int Quantidade { get; set; }
        

        public Estoque Estoque { get; set; }

        public Doacao Doacao { get; set; }
    }
}
