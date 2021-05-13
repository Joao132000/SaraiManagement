using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //

namespace SaraiManagement.Models
{
    public class Movimentacao
    {
        [Required] //CAMPO 'Valor' OBRIGATÓRIO
        public int MovimentacaoID { get; set; }


        [Required] //CAMPO 'Valor' OBRIGATÓRIO
        public int UsuarioID { get; set; }


        [Required] //CAMPO 'Valor' OBRIGATÓRIO
        public int CaixaID { get; set; }



        [Required] //CAMPO 'Valor' OBRIGATÓRIO
        public double Valor { get; set; }


        [Required] //CAMPO 'TipoMovimentacao' OBRIGATÓRIO
        public Enum TipoMovimentacao { get; set; }


        [Display(Name = "Data da movimentação")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DiaMovimentacao { get; set; }


        [Required] //CAMPO 'Descricao' OBRIGATÓRIO
        public string Descricao { get; set; }

        public Usuario Usuario { get; set; }
        public Caixa Caixa { get; set; }
    }
}
