using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFOutros : IOutrosRepositorio
    {
        private ApplicationDbContext context;

        public EFOutros(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Outros> Outros => context.Outros;
    }
}
