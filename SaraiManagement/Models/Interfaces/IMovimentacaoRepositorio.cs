using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public interface IMovimentacaoRepositorio
    {
        IQueryable<Movimentacao> Movimentacoes { get; }
        public void Create(Movimentacao movimentacao);
        public Movimentacao PesquisarMovimentacao(int id);
        public void Edit(Movimentacao movimentacao);
        public void Delete(Movimentacao movimentacao);
    }
}
