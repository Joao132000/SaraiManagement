using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    public interface IUsuarioRepositorio
    {
        IQueryable<Usuario> Usuarios { get; }
        public void Create(Usuario usuario);
        public Usuario Consultar(int id);
        public void Edit(Usuario usuario);
        public void Delete(Usuario usuario);
    }
}
