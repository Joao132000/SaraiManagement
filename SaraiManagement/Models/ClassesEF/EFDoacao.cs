using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaraiManagement.Models.ClassesEF;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFDoacao :IDoacaoRepositorio
    {
        public ApplicationDbContext context;

        public EFDoacao(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Doacao> Doacoes => context.Doacaos
            .Include(c => c.Caixa)
            .Include(u => u.Usuario)
            .Include(d => d.Donatario);

        public void Create(Doacao doacao)
        {
            doacao.CaixaID = 1;
            context.Add(doacao);
            context.SaveChanges();
        }
        public Doacao Consultar(int id)
        {
            var doacao = context.Doacaos
                .Include(c => c.Caixa)
                .Include(u => u.Usuario)
                .Include(d => d.Donatario)
                .FirstOrDefault(p => p.DoacaoID == id);
            return doacao;
        }
        public void Edit(Doacao doacao)
        {
            context.Entry(doacao).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(Doacao doacao)
        {
            context.Remove(doacao);
            context.SaveChanges();
        }
    }
}
