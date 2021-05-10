using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFDoador : IDoadorRepositorio
    {
        private ApplicationDbContext context;

        public EFDoador(ApplicationDbContext ctx)
        {
            context = ctx;
        }
    }
}
