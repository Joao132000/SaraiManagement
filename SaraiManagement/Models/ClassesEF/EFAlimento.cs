using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFAlimento : IAlimentoRepositorio
    {
        private ApplicationDbContext context;

        public EFAlimento(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Alimento> Alimentos => context.Alimentos;
    }
}
