using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models
{
    public class EFAluno : IAlunoRepositorio
    {
        private ApplicationDbContext context;

        public EFAluno(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Aluno> Alunos => context.Alunos;

        public void Create(Aluno aluno)
        {
            context.Add(aluno);
            context.SaveChanges();
        }

        public Aluno Consultar(int id)
        {
            var aluno = context.Alunos
                .Include(d => d.Donatario) //Associação 
                .FirstOrDefault(p => p.AlunoID == id);
            return aluno;
        }
        public void Edit(Aluno aluno)
        {
            context.Entry(aluno).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(Aluno aluno)
        {
            context.Remove(aluno);
            context.SaveChanges();
        }

    }
}
