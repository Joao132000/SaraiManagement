using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFDonatario : IDonatarioRepositorio
    {
        public ApplicationDbContext context;

        public EFDonatario(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Donatario> Donatarios => context.Donatarios;
        public void Create(Donatario donatario)
        {
            context.Add(donatario);
            context.SaveChanges();
        }
        public Donatario Consulta(int id)
        {
            var donatario = context.Donatarios
           .FirstOrDefault(p => p.DonatarioID == id);
            return donatario;
        }
        public void Edit(Donatario donatario)
        {
            context.Entry(donatario).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(Donatario donatario)
        {
            context.Remove(donatario);
            context.SaveChanges();
        }
    }
}
