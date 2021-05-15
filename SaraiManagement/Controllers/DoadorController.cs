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
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.regularidadeDoador = r; 
            return View();
        }

        [HttpPost]
        public IActionResult Create(Doador doador)
        {
            repositorio.Create(doador);
            return View();
        }

        [HttpGet]
        public IActionResult Consultar(int id)
        {
            var doador = repositorio.Consultar(id);
            return View(doador);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var doador = context.Doadors.Find(id);
            return View(doador);
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
            var doador = repositorio.Consultar(id);
            return View(doador);
        }
        [HttpPost]
        public IActionResult Delete(Doador doador)
        {
            repositorio.Delete(doador);
            return RedirectToAction("HomeController");
        }
    }
}
