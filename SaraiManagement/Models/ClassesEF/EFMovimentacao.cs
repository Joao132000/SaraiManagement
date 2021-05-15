using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFMovimentacao : IMovimentacaoRepositorio
    {
        private ApplicationDbContext context;

        public EFMovimentacao(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Movimentacao> Movimentacoes => context.Movimentacaos;

        public void Create(Movimentacao movimentacao)
        {
            context.Add(movimentacao);
            context.SaveChanges();
        }

        public Movimentacao PesquisarMovimentacao(int id)
        {
            var movi = context.Movimentacaos
                .Include(c => c.Caixa)
                .Include(d => d.Doador)
                .Include(u => u.Usuario)
                .FirstOrDefault(m => m.MovimentacaoID == id);
            return movi;
        }

        public void Edit(Movimentacao movimentacao)
        {
            context.Entry(movimentacao).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Movimentacao movimentacao)
        {
            context.Remove(movimentacao);
            context.SaveChanges();
        }
    }
}
