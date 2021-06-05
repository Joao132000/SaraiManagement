using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using SaraiManagement.Models.ViewModels;
using SaraiManagement.Infraestrutura;

namespace SaraiManagement.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioRepositorio repositorio;
        private ApplicationDbContext context;
        public int pageSize = 5;

        public UsuarioController(IUsuarioRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }

        public IActionResult Index()
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
                return View();
            else
                return View("Login");
        }
        [HttpGet]
        public ViewResult List(int pagina = 1) =>
            View(new UsuarioListViewModel
            {
                 Usuarios = repositorio.Usuarios
                .OrderBy(d => d.UsuarioID)
                .Skip((pagina - 1) * pageSize)
                .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = pageSize,
                    TotalItens = repositorio.Usuarios.Count()
                }
            });


        [HttpGet]
        public IActionResult Create()
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            repositorio.Create(usuario);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Consultar(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if ( acesso != null)
            {
                var usuario = repositorio.Consultar(id);
                return View(usuario);
            }
            else 
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var usuario = context.Usuarios.Find(id);
                return View(usuario);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpPost]
        public IActionResult Edit(Usuario usuario)
        {
            repositorio.Edit(usuario);
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var usuario = repositorio.Consultar(id);
                return View(usuario);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        [HttpPost]
        public IActionResult Delete(Usuario usuario)
        {
            repositorio.Delete(usuario);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(string nome, string senha)
        {
            var confirma = repositorio.Validar(nome, senha);
            if (confirma != null)
            {
                HttpContext.Session.SetString("usuario_session", confirma.Nome);
                HttpContext.Session.SetString("usuario_session1", confirma.UsuarioID.ToString());
                HttpContext.Session.SetString("tipo_session",confirma.Tipo.ToString());
                return RedirectToAction("Index", "TelaInicial");
            }
            else
            {
                return RedirectToAction("Errado");
            }
        }
        [HttpGet]
        public IActionResult Correto()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Errado()
        {
            return View();
        }

        public IActionResult Logout() 
        {
            HttpContext.Session.Remove("usuario_session");
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
