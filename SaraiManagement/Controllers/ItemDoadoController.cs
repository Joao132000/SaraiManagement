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
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                return View("Correto");
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        [HttpGet]  //Serve para gerar a View
        public IActionResult Create(int idEstoque)//ViewBag + .Nome // ordenados pelo Nome
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                ViewBag.DoacaoID = new SelectList(context.Doacaos.OrderBy(d => d.DoacaoID), "DoacaoID", "DoacaoID");
                ViewBag.EstoqueID = new SelectList(context.Estoques.Where(e => e.EstoqueID == idEstoque), "EstoqueID", "Descricao");

                return View();
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        [HttpPost] //Executar a ação do metodo que vai modificar o BD - Envia dados para o metodo que modifica o BD
        public IActionResult Create(ItemDoado itemDoado, string x)
        {
            repositorio.Create(itemDoado);
            if(x == "Sim")
                return RedirectToAction("Index", "Estoque");
            else
                return RedirectToAction("Index", "TelaInicial");

        }

        public IActionResult Details(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var item = repositorio.PesquisarItemDoado(id);
                return View(item);
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
                var item = context.ItemDoados.Find(id);
                return View(item);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
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
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var item = repositorio.PesquisarItemDoado(id);
                return View(item);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        [HttpPost]
        public IActionResult Delete(ItemDoado itemDoado)
        {
            repositorio.Delete(itemDoado);
            return View("HomeController");
        }
    }
}
