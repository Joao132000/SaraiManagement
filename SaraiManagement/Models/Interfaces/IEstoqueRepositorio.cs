using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public interface IEstoqueRepositorio
    {
        IQueryable<Estoque> Estoques { get; }
        public void Create(Estoque estoque);
        public Estoque Consulta(int id);
        public void Edit(Estoque estoque);
        public void Delete(Estoque estoque);
    }
}
