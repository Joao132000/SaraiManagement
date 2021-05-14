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


        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Digite um texto com 3 a 60 caracteres")]
        public string Nome { get; set; }


         //CAMPO 'Categoria' OBRIGATÓRIO
        public Categoria Categoria { get; set; }



        public int Quantidade { get; set; }

        public Doacao Doacao { get; set; }
    }
}
