using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.CassesEF
{
    public class EFAluno : IAlunoRepositorio
    {
        private ApplicationDbContext context;

        public EFAluno(ApplicationDbContext ctx)
        {
            context = ctx;
        }
    }
}
