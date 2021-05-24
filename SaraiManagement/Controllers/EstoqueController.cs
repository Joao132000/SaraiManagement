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
using SaraiManagement.Models.ViewModels;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace SaraiManagement.Controllers
{
    public class EstoqueController : Controller
    {
        private IEstoqueRepositorio repositorio;
        private ApplicationDbContext context;
        public int pageSize = 1;

        public EstoqueController(IEstoqueRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            var aux = HttpContext.Session.GetString("id_aux");
            if (acesso != null)
            {
                var estoque = from e in context.Estoques
                              select e;

                if (!String.IsNullOrEmpty(searchString))
                {
                    estoque = estoque.Where(s => s.Descricao.Contains(searchString));
                }

                return View(await estoque.ToListAsync());
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        public ViewResult List(int pagina = 1) =>
           View(new EstoqueListViewModel
           {
               Estoques = repositorio.Estoques
               .OrderBy(d => d.EstoqueID)
               .Skip((pagina - 1) * pageSize)
               .Take(pageSize),
               PagingInfo = new PagingInfo
               {
                   PaginaAtual = pagina,
                   ItensPorPagina = pageSize,
                   TotalItens = repositorio.Estoques.Count()

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
                return RedirectToAction("Login", "Usuario");
            }
        }
        [HttpPost]
        public IActionResult Create(Estoque estoque)
        {
            repositorio.Create(estoque);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var estoque = repositorio.Consulta(id);
                return View(estoque);
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
                var estoque = context.Estoques.Find(id);
                ViewBag.DonatarioID = new SelectList(context.Estoques.OrderBy(f
               => f.Descricao), "EstoqueID");
                return View(estoque);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
        [HttpPost]
        public IActionResult Edit(Estoque estoque)
        {
            repositorio.Edit(estoque);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var estoque = repositorio.Consulta(id);
                return View(estoque);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
        [HttpPost]
        public IActionResult Delete(Estoque estoque)
        {
            repositorio.Delete(estoque);
            return RedirectToAction("Index");
        }

        
    }
}
