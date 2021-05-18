using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public interface IAlunoRepositorio
    {
        IQueryable<Aluno> Alunos { get; }

        public void Create(Aluno aluno);
        public Aluno Consultar(int id);
        public void Edit(Aluno aluno);
        public void Delete(Aluno aluno);

    }
}
