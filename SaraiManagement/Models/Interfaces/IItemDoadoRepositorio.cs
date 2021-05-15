using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public interface IItemDoadoRepositorio
    {
        IQueryable<ItemDoado> ItemDoados { get; }
        public void Create(ItemDoado itemDoado);
        public ItemDoado PesquisarItemDoado(int id);
        public void Edit(ItemDoado itemDoado);
        public void Delete(ItemDoado itemDoado);
    }
}
