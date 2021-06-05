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
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace SaraiManagement.Controllers
{
    public class DonatarioController : Controller
    {
        private IDonatarioRepositorio repositorio;
        private ApplicationDbContext context;
        public int pageSize = 20;
        public DonatarioController(IDonatarioRepositorio repo, ApplicationDbContext ctx)
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
        public IActionResult Create(Donatario donatario)
        {
            repositorio.Create(donatario);
            return View("ValidacaoSucesso");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var donatario = repositorio.Consulta(id);
                return View(donatario);
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
                var donatario = context.Donatarios.Find(id);
                ViewBag.DonatarioID = new SelectList(context.Donatarios.OrderBy(f
               => f.Nome), "DonatarioID");
                return View(donatario);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
        [HttpPost]
        public IActionResult Edit(Donatario donatario)
        {
            repositorio.Edit(donatario);
            return View("ValidacaoSucesso");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var donatario = repositorio.Consulta(id);
                return View(donatario);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
        [HttpPost]
        public IActionResult Delete(Donatario donatario)
        {
            repositorio.Delete(donatario);
            return View("ValidacaoSucesso");
        }
    }
}
