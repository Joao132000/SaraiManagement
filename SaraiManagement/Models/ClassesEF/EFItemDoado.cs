using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFItemDoado : IItemDoadoRepositorio
    {
        public ApplicationDbContext context;

        public EFItemDoado(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<ItemDoado> ItemDoados => context.ItemDoados
            .Include(d => d.Doacao)
            .Include(e => e.Estoque);

        public void Create(ItemDoado itemDoado)
        {
            context.Add(itemDoado);
            context.SaveChanges();
        }

        public ItemDoado PesquisarItemDoado(int id)
        {
            var item = context.ItemDoados
                .Include(e => e.Estoque)
                .Include(d => d.Doacao)
                .FirstOrDefault(i => i.ItemDoadoID == id);
            return item;
        }

        public void Edit(ItemDoado itemDoado)
        {
            context.Entry(itemDoado).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(ItemDoado itemDoado)
        {
            context.Remove(itemDoado);
            context.SaveChanges();
        }
    }
}
