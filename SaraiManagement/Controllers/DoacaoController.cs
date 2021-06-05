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
using SaraiManagement.Controllers;

namespace SaraiManagement.Controllers
{
    public class DoacaoController : Controller
    {
        private IDoacaoRepositorio repositorio;
        private ApplicationDbContext context;
        public int pageSize = 10;

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

       
        public ViewResult List(string searchString) =>
            View(new DoacaoListViewModel
            {                 
                 Doacaos = repositorio.Doacoes
                .Where(s => s.Donatario.Nome.StartsWith(searchString))
                .OrderByDescending(p => p.dataDoacao)
               
            });

        public ViewResult ListPorID(int id) =>
           View(new DoacaoListViewModel
           {
               Doacaos = repositorio.Doacoes
               .Where(s => s.Donatario.DonatarioID==id)
               .OrderByDescending(p => p.dataDoacao)

           });

        [HttpGet]
        public IActionResult Create(int idDonatario)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {

                var a = HttpContext.Session.GetString("usuario_session1");
                int i = int.Parse(a.ToString());
                ViewBag.UsuarioID = new SelectList(context.Usuarios.Where(d => d.UsuarioID == i), "UsuarioID", "Nome");
                ViewBag.DonatarioID = new SelectList(context.Donatarios.Where(e => e.DonatarioID == idDonatario), "DonatarioID", "Nome");                
                ViewBag.CaixaID = new SelectList(context.Caixas.OrderBy(f => f.Descricao), "CaixaID", "Descricao");

                return View();
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        [HttpPost]
        public IActionResult Create(Doacao doacao, int x)
        {
            repositorio.Create(doacao);
            if (doacao.Valor != null)
            {
                foreach (var item in context.Caixas)
                {
                    if (item.CaixaID == doacao.CaixaID)
                    {
                        item.Saldo = item.Saldo - doacao.Valor;
                    }
                }
                context.SaveChanges();
            }
            else
            {
                doacao.Valor = 0;
                context.SaveChanges();
            }

            if (x==1)
                return RedirectToAction("Index", "Estoque");
            else
                return View("ValidacaoSucesso");
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
