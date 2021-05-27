using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models;
using SaraiManagement.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SaraiManagement.Models.Enuns;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace SaraiManagement.Controllers
{
    public class DoacaoController : Controller
    {
        private IDoacaoRepositorio repositorio;
        private ApplicationDbContext context;
        public int PageSize = 2;

        public DoacaoController(IDoacaoRepositorio repo, ApplicationDbContext ctx)
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

        public ViewResult List(int pagina = 1) => View(new DoacaoListViewModel
        {
            Doacaos = repositorio.Doacoes
            .OrderBy(d => d.DoacaoID)
            .Skip((pagina - 1) * PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                PaginaAtual = pagina,
                ItensPorPagina = PageSize,
                TotalItens = repositorio.Doacoes.Count()
            }
        });
        [HttpGet]
        public IActionResult Create()
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                ViewBag.DonatarioID = new SelectList(context.Donatarios.OrderBy(f => f.Nome), "DonatarioID", "Nome");
                ViewBag.UsuarioID = new SelectList(context.Usuarios.OrderBy(f => f.Nome), "UsuarioID", "Nome");
                ViewBag.CaixaID = new SelectList(context.Caixas.OrderBy(f => f.Descricao), "CaixaID", "Descricao");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        [HttpPost]
        public IActionResult Create(Doacao doacao)
        {
            HttpContext.Session.SetString("idDoacao", doacao.DoacaoID.ToString());

            repositorio.Create(doacao);
            return View();
        }

        [HttpGet]
        public IActionResult Consultar(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var doacao = repositorio.Consultar(id);
                return View(doacao);
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
                var doacao = context.Doacaos.Find(id);
                return View(doacao);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        [HttpPost]
        public IActionResult Edit(Doacao doacao)
        {
            repositorio.Edit(doacao);
            return RedirectToAction("HomeController");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var doacao = repositorio.Consultar(id);
                return View(doacao);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
        [HttpPost]
        public IActionResult Delete(Doacao doacao)
        {
            repositorio.Delete(doacao);
            return RedirectToAction("HomeController");
        }
    }
}
