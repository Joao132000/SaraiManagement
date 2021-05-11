using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public interface IAlimentoRepositorio
    {
        IQueryable<Alimento> Alimentos { get; }
    }
}
