using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //

namespace SaraiManagement.Models
{
    public class Caixa
    {
        public int CaixaID { get; set; }



        [Required] //CAMPO 'Saldo' OBRIGATÓRIO
        public double Saldo { get; set; }

        public string Descricao { get; set; }
    }
}
