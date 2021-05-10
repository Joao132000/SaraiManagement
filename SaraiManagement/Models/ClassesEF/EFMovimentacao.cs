using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFMovimentacao : IMovimentacaoRepositorio
    {
        private ApplicationDbContext context;

        public EFMovimentacao(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        
    }
}
