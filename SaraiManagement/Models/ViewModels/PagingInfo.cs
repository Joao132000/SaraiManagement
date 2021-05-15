using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalItens { get; set; }
        public int ItensPorPagina { get; set; }
        public int PaginaAtual { get; set; }
        public int TotalDePaginas => (int)Math.Ceiling((decimal)TotalItens / ItensPorPagina);
    }
}
