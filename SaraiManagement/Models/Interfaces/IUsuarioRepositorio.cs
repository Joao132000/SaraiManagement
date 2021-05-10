using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models
{
    interface IUsuarioRepositorio
    {
        IQueryable<Usuario> Usuarios { get; }
    }
}
