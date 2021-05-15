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
        public IQueryable<Doador> Doadores => context.Doadors;

        public void Create(Doador doador)
        {
            context.Add(doador);
            context.SaveChanges();
        }
        public Doador Consultar(int id)
        {
            var doador = context.Doadors.FirstOrDefault(p => p.DoadorID == id);
            return doador;
        }
        public void Edit(Doador doador)
        {
            context.Entry(doador).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(Doador doador)
        {
            context.Remove(doador);
            context.SaveChanges();
        }
    }
}
