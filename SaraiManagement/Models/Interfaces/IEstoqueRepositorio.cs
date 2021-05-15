using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public interface IEstoqueRepositorio
    {
        IQueryable<Estoque> Estoques { get; }
    }
}
