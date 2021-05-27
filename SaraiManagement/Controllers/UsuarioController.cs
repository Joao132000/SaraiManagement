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

namespace SaraiManagement.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioRepositorio repositorio;
        private ApplicationDbContext context;
        public UsuarioController(IUsuarioRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }

        public IActionResult Index()
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
                return View("Correto");
            else
                return View("Login");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            repositorio.Create(usuario);
            return View();
        }

        [HttpGet]
        public IActionResult Consultar(int id)
        {
            var usuario = repositorio.Consultar(id);
            return View(usuario);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var usuario = context.Usuarios.Find(id);
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Edit(Usuario usuario)
        {
            repositorio.Edit(usuario);
            return RedirectToAction("HomeController");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var usuario = repositorio.Consultar(id);
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Delete(Usuario usuario)
        {
            repositorio.Delete(usuario);
            return RedirectToAction("HomeController");
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
                return RedirectToAction("Correto");
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

    }
}
