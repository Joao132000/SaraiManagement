using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFUsuario : IUsuarioRepositorio
    {
        private ApplicationDbContext context;

        public EFUsuario(ApplicationDbContext ctx)
        {
            context = ctx;
        }
    }
}
