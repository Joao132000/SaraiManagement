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
    public class ItemDoadoController : Controller
    {
        private IItemDoadoRepositorio repositorio;
        private ApplicationDbContext context;

        public ItemDoadoController(IItemDoadoRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]  //Serve para gerar a View
        public IActionResult Create(int id)//ViewBag + .Nome // ordenados pelo Nome
        {
            ViewBag.DoacaoID = new SelectList(context.Doacaos.OrderBy(d => d.DoacaoID), "DoacaoID", "DoacaoID");
            ViewBag.EstoqueID = new SelectList(context.Estoques.OrderBy(e => e.Descricao), "EstoqueID", "Descricao");            
            return View();
        }

        [HttpPost] //Executar a ação do metodo que vai modificar o BD - Envia dados para o metodo que modifica o BD
        public IActionResult Create(ItemDoado itemDoado)
        {
            repositorio.Create(itemDoado);
            return View("HomeController");
        }

        public IActionResult Details(int id)
        {
            var item = repositorio.PesquisarItemDoado(id);
            return View(item);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = context.ItemDoados.Find(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(ItemDoado itemDoado)
        {
            repositorio.Edit(itemDoado);
            return View("HomeController");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = repositorio.PesquisarItemDoado(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(ItemDoado itemDoado)
        {
            repositorio.Delete(itemDoado);
            return View("HomeController");
        }
    }
}
