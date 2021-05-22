using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models.Classes;
using SaraiManagement.Models;
using SaraiManagement.Models.ClassesEF;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SaraiManagement.Models.Enuns;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using System.Data;

namespace SaraiManagement.Controllers
{
    public class DoadorController : Controller
    {
        private IDoadorRepositorio repositorio;
        private ApplicationDbContext context;
        public DoadorController(IDoadorRepositorio repo,ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }

        public IActionResult Index()
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
                return View("Create");
            else
                return RedirectToAction("Login","Usuario");
        }
        [HttpGet]
        public IActionResult Create()
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                return View("Create");
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        [HttpPost]
        public IActionResult Create(Doador doador)
        {
            ViewBag.AppRoleList = new SelectList(Ano.GetValues​​(typeof(string)));
            repositorio.Create(doador);
            return View();
        }

        [HttpGet]
        public IActionResult Consultar(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var doador = repositorio.Consultar(id);
                return View(doador);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var doador = context.Doadors.Find(id);
                return View(doador);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
        [HttpPost]
        public IActionResult Edit(Doador doador)
        {
            repositorio.Edit(doador);
            return RedirectToAction("HomeController");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var doador = repositorio.Consultar(id);
                return View(doador);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
        [HttpPost]
        public IActionResult Delete(Doador doador)
        {
            repositorio.Delete(doador);
            return RedirectToAction("HomeController");
        }
    }
}
