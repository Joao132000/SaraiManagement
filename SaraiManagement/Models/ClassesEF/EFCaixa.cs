using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFCaixa : ICaixaRepositorio
    {
        private ApplicationDbContext context;

        public EFCaixa(ApplicationDbContext ctx)
        {
            context = ctx;
        }
    }
}
