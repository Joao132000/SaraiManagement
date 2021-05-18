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
    public class AlunoController : Controller
    {
        private IAlunoRepositorio repositorio;
        private ApplicationDbContext context;

        public AlunoController(IAlunoRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            ; context = ctx;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
            repositorio.Create(aluno);
            return RedirectToAction("List");
        }
        public IActionResult Details(int id)
        {
            var aluno = repositorio.Consultar(id);
            return View(aluno);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var aluno = context.Alunos.Find(id);
            return View(aluno);
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
            var aluno = context.Alunos.Find(id);
            return View(aluno);
        }
        [HttpPost]
        public IActionResult Delete(Aluno aluno)
        {
            repositorio.Delete(aluno);
            return RedirectToAction("List");
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}
