using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models;
using Microsoft.EntityFrameworkCore;
using SaraiManagement.Models.ViewModels;
using SaraiManagement.Infraestrutura;

namespace SaraiManagement.Controllers
{
    public class DonatarioController : Controller
    {
        private IDonatarioRepositorio repositorio;
        private ApplicationDbContext context;
        public int pageSize = 10;
        public DonatarioController(IDonatarioRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }

        public ViewResult List(int pagina = 1) =>
            View(new DonatarioListViewModel
            {
                Donatarios = repositorio.Donatarios
                .OrderBy(d => d.DonatarioID)
                .Skip((pagina - 1) * pageSize)
                .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = pageSize,
                    TotalItens = repositorio.Donatarios.Count()

                }
            });

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Donatario donatario)
        {
            repositorio.Create(donatario);
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var donatario = repositorio.Consulta(id);
            return View(donatario);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var donatario = context.Donatarios.Find(id);
            ViewBag.DonatarioID = new SelectList(context.Donatarios.OrderBy(f
           => f.Nome), "DonatarioID");
            return View(donatario);
        }
        [HttpPost]
        public IActionResult Edit(Donatario donatario)
        {
            repositorio.Edit(donatario);
            return RedirectToAction("Home");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var donatario = repositorio.Consulta(id);
            return View(donatario);
        }
        [HttpPost]
        public IActionResult Delete(Donatario donatario)
        {
            repositorio.Delete(donatario);
            return RedirectToAction("Home");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
