using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //

namespace SaraiManagement.Models
{
    public class Donatario
    {
        public int DonatarioID { get; set; }

        public int? AlunoID { get; set; }


        [Required]
        [StringLength(60, MinimumLength = 4, ErrorMessage = "Digite um texto com 4 a 60 caracteres")]
        public string Nome { get; set; }


        [ScaffoldColumn(false)]
        public string Endereco { get; set; }


        [Display(Name = "Telefone")]
        [RegularExpression(@"^\(?\d{2}\)?[\s9]?\d{4}-?\d{4}$", ErrorMessage = "Digite o telefone no formato (xx) 9xxxx-xxxx")]
        public string Telefone { get; set; }


        [DataType(DataType.EmailAddress, ErrorMessage = "Digite um endereço válido com @")]
        public string Email { get; set; }
        
        public virtual ICollection<Doacao> Doacao { get; set; }

        public Aluno Aluno { get; set; }
    }
}
