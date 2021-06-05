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
    public class CaixaController : Controller
    {
        private ICaixaRepositorio repositorio;
        private ApplicationDbContext context;

        public CaixaController(ICaixaRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }
        public IActionResult Index()
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                return View(context.Caixas);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var tipo = HttpContext.Session.GetString("tipo_session");
                if (tipo.ToString() == "Admin")
                    return View();
                else
                    return RedirectToAction("Index", "TelaInicial");
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        [HttpPost]
        public IActionResult Create(Caixa caixa)
        {
            repositorio.Create(caixa);
            return View("ValidacaoSucesso");
        }
        public IActionResult Details(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var caixa = repositorio.Consultar(id);
                return View(caixa);
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
                var tipo = HttpContext.Session.GetString("tipo_session");
                if (tipo.ToString() == "Admin")
                {
                    var caixa = context.Caixas.Find(id);
                    return View(caixa);
                }
                else
                    return RedirectToAction("Index", "TelaInicial");
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
        [HttpPost]
        public IActionResult Edit(Caixa caixa)
        {
            repositorio.Edit(caixa);
            return View("ValidacaoSucesso");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null) {
                var tipo = HttpContext.Session.GetString("tipo_session");
                if (tipo.ToString() == "Admin")
                {
                    var caixa = context.Caixas.Find(id);
                    return View(caixa);
                }
                else
                    return RedirectToAction("Index", "TelaInicial");
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
        [HttpPost]
        public IActionResult Delete(Caixa caixa)
        {
            repositorio.Delete(caixa);
            return View("ValidacaoSucesso");
        }
    }
}
