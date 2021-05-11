using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //

namespace SaraiManagement.Models
{
    public class ItemDoado
    {
        public int ItemID { get; set; }


        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Digite um texto com 3 a 60 caracteres")]
        public string Nome { get; set; }


        [Required] //CAMPO 'Categoria' OBRIGATÓRIO
        public Enum Categoria { get; set; }



        public int Quantidade { get; set; }

        public Doacao Doacao { get; set; }
    }
}
