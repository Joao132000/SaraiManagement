using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFDonatario : IDonatarioRepositorio
    {
        private ApplicationDbContext context;

        public EFDonatario(ApplicationDbContext ctx)
        {
            context = ctx;
        }
    }
}
