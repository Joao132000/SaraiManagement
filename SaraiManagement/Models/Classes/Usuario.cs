using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //
using SaraiManagement.Models.Enuns;

namespace SaraiManagement.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }



        [Required]
        [StringLength(60, MinimumLength = 4, ErrorMessage = "Digite um texto com 4 a 60 caracteres")]
        public string Nome { get; set; }



        [DataType(DataType.Password)]
        public string Senha { get; set; }


        [Required] //CAMPO 'TIPO' OBRIGATÓRIO
        public tipoUsuario Tipo { get; set; }

        public virtual ICollection<Doacao> Doacao { get; set; }
        public virtual ICollection<Movimentacao> Movimentacao { get; set; }
    }
}
