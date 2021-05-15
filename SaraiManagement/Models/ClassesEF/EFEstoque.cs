using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFEstoque : IEstoqueRepositorio
    {
        public ApplicationDbContext context;

        public EFEstoque(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Estoque> Estoques => context.Estoques;

        public void Create(Estoque estoque)
        {
            context.Add(estoque);
            context.SaveChanges();
        }
        public Estoque Consulta(int id)
        {
            var estoque = context.Estoques
           .FirstOrDefault(e => e.EstoqueID == id);
            return estoque;
        }
        public void Edit(Estoque estoque)
        {
            context.Entry(estoque).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(Estoque estoque)
        {
            context.Remove(estoque);
            context.SaveChanges();
        }
    }
}
