using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFDoacao : IDoacaoRepositorio
    {
        private ApplicationDbContext context;

        public EFDoacao(ApplicationDbContext ctx)
        {
            context = ctx;
        }
    }
}
