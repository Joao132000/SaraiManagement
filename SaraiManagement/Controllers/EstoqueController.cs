﻿using Microsoft.AspNetCore.Mvc;
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
        public int pageSize = 5;

        public EstoqueController(IEstoqueRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }

        public async Task<IActionResult> Index(string searchString, int idDoacao)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var estoque = from e in context.Estoques.OrderBy(e => e.Descricao) select e;

                if (!String.IsNullOrEmpty(searchString))
                {
                    estoque = estoque.Where(s => s.Descricao.StartsWith(searchString));
                }

                return View(await estoque.ToListAsync());
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        public async Task<IActionResult> List(string searchString, int idDoacao)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var estoque = from e in context.Estoques.OrderBy(e => e.Descricao) select e;

                if (!String.IsNullOrEmpty(searchString))
                {
                    estoque = estoque.Where(s => s.Descricao.StartsWith(searchString));
                }

                return View(await estoque.ToListAsync());
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
            return View("ValidacaoSucesso");
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
            return View("ValidacaoSucesso");
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
            return View("ValidacaoSucesso");
        }

        
    }
}
