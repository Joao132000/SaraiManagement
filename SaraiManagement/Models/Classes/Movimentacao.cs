using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //
using SaraiManagement.Models.Enuns;

namespace SaraiManagement.Models
{
    public class Movimentacao
    {
        [Required] //CAMPO 'Valor' OBRIGATÓRIO
        public int MovimentacaoID { get; set; }

        [Required] //CAMPO 'Valor' OBRIGATÓRIO
        public double Valor { get; set; }


        [Required] //CAMPO 'TipoMovimentacao' OBRIGATÓRIO
        public tipoMovimentacao TipoMovimentacao { get; set; }


        [Display(Name = "Data da movimentação")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DataMovimentacao { get; set; }


        [Required] //CAMPO 'Descricao' OBRIGATÓRIO
        public string Descricao { get; set; }

        public int? DoadorID { get; set; }
        public Doador Doador { get; set; }
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
        public int CaixaID { get; set; }
        public Caixa Caixa { get; set; }
    }
}
