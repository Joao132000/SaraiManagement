using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //

namespace SaraiManagement.Models
{
    public class Doador
    {
        public int DoadorID { get; set; }


        [Required]
        [StringLength(60, MinimumLength = 4, ErrorMessage = "Digite um texto com 4 a 60 caracteres")]
        public string Nome { get; set; }


        [ScaffoldColumn(false)]
        public string Endereco { get; set; }


        [Required] //CAMPO 'Cidade' OBRIGATÓRIO
        public string Cidade { get; set; }

        [Required] //CAMPO 'Regularidade' OBRIGATÓRIO
        public Enum regularidadeDoador { get; set; }


        [Display(Name = "Data de Inicio da doacao")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime inicioDaDoacao { get; set; }
    }
}
