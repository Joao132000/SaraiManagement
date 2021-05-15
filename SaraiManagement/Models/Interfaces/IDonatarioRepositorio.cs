using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public interface IDonatarioRepositorio
    {
        IQueryable<Donatario> Donatarios { get; }
        public void Create(Donatario donatario);
        public Donatario Consulta(int id);
        public void Edit(Donatario donatario);
        public void Delete(Donatario donatario);
    }
}
