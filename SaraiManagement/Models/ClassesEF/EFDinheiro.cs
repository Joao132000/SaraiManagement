using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFDinheiro:IDinheiroRepositorio
    {
        private ApplicationDbContext context;

        public EFDinheiro(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Dinheiro> Dinheiros => context.Dinheiros;
    }
}
