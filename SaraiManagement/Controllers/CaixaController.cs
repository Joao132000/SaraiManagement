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
    public class CaixaController : Controller
    {
        private ICaixaRepositorio repositorio;
        private ApplicationDbContext context;

        public CaixaController(ICaixaRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Caixa caixa)
        {
            repositorio.Create(caixa);
            return RedirectToAction("List");
        }
        public IActionResult Details(int id)
        {
            var caixa = repositorio.Consultar(id);
            return View(caixa);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var caixa = context.Caixas.Find(id);
            return View(caixa);
        }
        [HttpPost]
        public IActionResult Edit(Caixa caixa)
        {
            repositorio.Edit(caixa);
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var caixa = context.Caixas.Find(id);
            return View(caixa);
        }
        [HttpPost]
        public IActionResult Delete(Caixa caixa)
        {
            repositorio.Delete(caixa);
            return RedirectToAction("List");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
