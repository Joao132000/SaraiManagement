using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraiManagement.Models.ViewModels
{
    public class UsuarioListViewModel
    {
        public IEnumerable<Usuario> Usuarios { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
