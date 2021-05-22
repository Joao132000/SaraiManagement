using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public interface ICaixaRepositorio
    {
        IQueryable<Caixa> Caixas { get; }

        public void Create(Caixa caixa);
        public Caixa Consultar(int id);
        public void Edit(Caixa caixa);
        public void Delete(Caixa caixa);
    }
}
