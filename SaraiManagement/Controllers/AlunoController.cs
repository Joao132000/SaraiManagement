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
    public class AlunoController : Controller
    {
        private IAlunoRepositorio repositorio;
        private ApplicationDbContext context;
        public int pageSize = 20;

        public AlunoController(IAlunoRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }
        public ViewResult List(int pagina = 1) => View(new AlunoListViewModel
           {
                Alunos = repositorio.Alunos.OrderBy(d => d.AlunoID)
               .Skip((pagina - 1) * pageSize)
               .Take(pageSize),
               PagingInfo = new PagingInfo
               {
                   PaginaAtual = pagina,
                   ItensPorPagina = pageSize,
                   TotalItens = repositorio.Alunos.Count()
               }
           });
        public IActionResult Index()
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                return RedirectToAction();
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
                return View("Create");
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
            repositorio.Create(aluno);
            return RedirectToAction("List");
        }
        public IActionResult Details(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var aluno = repositorio.Consultar(id);
                return View(aluno);
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
                var aluno = context.Alunos.Find(id);
                return View(aluno);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
        [HttpPost]
        public IActionResult Edit(Aluno aluno)
        {
            repositorio.Edit(aluno);
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var aluno = context.Alunos.Find(id);
                return View(aluno);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }
        [HttpPost]
        public IActionResult Delete(Aluno aluno)
        {
            repositorio.Delete(aluno);
            return RedirectToAction("List");
        }
    }
}
