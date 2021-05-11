using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFItemDoado : IItemDoadoRepositorio
    {
        private ApplicationDbContext context;

        public EFItemDoado(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<ItemDoado> ItemDoados => context.ItemDoados;
    }
}
