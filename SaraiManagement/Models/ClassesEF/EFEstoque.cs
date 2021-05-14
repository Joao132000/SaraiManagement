using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFEstoque : IEstoqueRepositorio
    {
        private ApplicationDbContext context;

        public EFEstoque(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Estoque> Estoques => context.Estoques;
    }
}
