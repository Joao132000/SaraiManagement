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

        public IQueryable<Caixa> Caixas => context.Caixas;
        public void Create(Caixa caixa)
        {
            context.Add(caixa);
            context.SaveChanges();
        }

        public Caixa Consultar(int id)
        {
            var caixa = context.Caixas
                .FirstOrDefault(p => p.CaixaID == id);
            return caixa;
        }
        public void Edit(Caixa caixa)
        {
            context.Entry(caixa).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(Caixa caixa)
        {
            context.Remove(caixa);
            context.SaveChanges();
        }
    }
}
