using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models;
using Microsoft.EntityFrameworkCore;

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
            return View();
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
    }
}
