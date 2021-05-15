using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models.ViewModels
{
    public class AlunoListViewModel
    {
        public IEnumerable<Aluno> Alunos { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
