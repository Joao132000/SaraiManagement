using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //
using SaraiManagement.Models.Enuns;

namespace SaraiManagement.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public int? DonatarioID { get; set; }



        [Required] //CAMPO 'Nome' OBRIGATÓRIO
        [StringLength(60, MinimumLength = 4, ErrorMessage = "Digite um texto com 4 a 60 caracteres")]
        public string Nome { get; set; }


        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }


        [Required] //CAMPO 'Escola' OBRIGATÓRIO
        public string Escola { get; set; }


        [Required] //CAMPO 'Ano' OBRIGATÓRIO
        public Ano Ano { get; set; }


        [Required] //CAMPO 'Bairro' OBRIGATÓRIO
        public string Endereco { get; set; }


        [Required] //CAMPO 'Cidade' OBRIGATÓRIO
        public string Cidade { get; set; }


        [Required] //CAMPO 'NomeResponsavel' OBRIGATÓRIO
        [StringLength(60, MinimumLength = 4, ErrorMessage = "Digite um texto com 4 a 60 caracteres")]
        public string NomeResponsavel { get; set; }

        [Required] //CAMPO 'Periodo' OBRIGATÓRIO
        public string Período { get; set; }



        [Display(Name = "Data de Admissao")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Admissao { get; set; }


        public Donatario Donatario { get; set; }
    }
}
