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

                IQueryable<ItemDoado> itemDoados = context.ItemDoados.Where(d => d.DoacaoID.ToString() == context.Doacaos.Count().ToString());   
                return View(itemDoados);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        public ViewResult List() =>
            View(new ItemEstoqueListViewModel
            {
                ItemDoados = repositorio.ItemDoados
                .OrderBy(p => p.ItemDoadoID)
                .Where(d => d.DoacaoID.ToString() == context.Doacaos.Count().ToString())
            });


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
            foreach (var item in context.Estoques)
            {
                if (item.EstoqueID == itemDoado.EstoqueID)
                {
                    if (itemDoado.Quantidade > item.Quantidade)
                    {
                        return View("Erro");
                    }
                    else
                    {
                        repositorio.Create(itemDoado);
                        item.Quantidade = item.Quantidade - itemDoado.Quantidade;
                    }
                }
            }
            context.SaveChanges();
            if (x == "Sim")
                return RedirectToAction("Index", "Estoque");
            else if(x == "Vizualizar")
                return RedirectToAction("List");
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
            foreach (var item in context.ItemDoados)
            {
                if (item.ItemDoadoID == itemDoado.ItemDoadoID)
                {

                    foreach (var item1 in context.Estoques)
                    {
                        if (item1.EstoqueID == item.EstoqueID)
                        {
                            item1.Quantidade = item1.Quantidade + item.Quantidade;
                        }
                    }
                    itemDoado = item;

                }
            }
            context.SaveChanges();
            repositorio.Delete(itemDoado);
            return RedirectToAction("List");
        }
    }
}
