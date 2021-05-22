using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SaraiManagement.Models.ClassesEF
{
    public class EFUsuario : IUsuarioRepositorio
    {
        private ApplicationDbContext context;

        public EFUsuario(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Usuario> Usuarios => context.Usuarios;
        public void Create(Usuario usuario)
        {
            context.Add(usuario);
            context.SaveChanges();
        }
        public Usuario Consultar(int id)
        {
            var usuario = context.Usuarios.FirstOrDefault(p => p.UsuarioID == id);
            return usuario;
        }
        public void Edit(Usuario usuario)
        {
            context.Entry(usuario).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(Usuario usuario)
        {
            context.Remove(usuario);
            context.SaveChanges();
        }
        public Usuario Validar(string nome, string senha)
        {
            var usuario = context.Usuarios.FirstOrDefault(p => p.Nome == nome && p.Senha == senha);
            return usuario;
        }
    }
}

