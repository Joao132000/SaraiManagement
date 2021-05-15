using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models;
using Microsoft.EntityFrameworkCore;
using SaraiManagement.Models.ViewModels;
using SaraiManagement.Models.Enuns;

namespace SaraiManagement.Controllers
{
    public class MovimentacaoController : Controller
    {
        private IMovimentacaoRepositorio repositorio;
        private ApplicationDbContext context;
        public int PageSize = 2;

        public MovimentacaoController(IMovimentacaoRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }

        public ViewResult List(int pagina = 1) => View(new MovimentacaoListViewModel
        {
            Movimentacaos = repositorio.Movimentacoes
            .OrderBy(m => m.MovimentacaoID)
            .Skip((pagina - 1) * PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                PaginaAtual = pagina,
                ItensPorPagina = PageSize,
                TotalItens = repositorio.Movimentacoes.Count()
            }
        });

        [HttpGet]  //Serve para gerar a View
        public IActionResult Create()//ViewBag + .Nome // ordenados pelo Nome
        {
            ViewBag.CaixaID = new SelectList(context.Caixas.OrderBy(c => c.CaixaID), "CaixaID", "Nome");
            ViewBag.DoadorID = new SelectList(context.Doadors.OrderBy(d => d.Nome), "DoadorID", "Nome");
            ViewBag.UsuarioID = new SelectList(context.Usuarios.OrderBy(u => u.Nome), "UsuarioID", "Nome");
            return View();
        }

        [HttpPost] //Executar a ação do metodo que vai modificar o BD - Envia dados para o metodo que modifica o BD
        public IActionResult Create(Movimentacao movimentacao)
        {
            repositorio.Create(movimentacao);
            return View("HomeController");
        }


        public IActionResult PesquisarMovimentacao(int id)
        {
            var consulta = repositorio.PesquisarMovimentacao(id);
            return View(consulta);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var consulta = context.Movimentacaos.Find(id);
            ViewBag.DoadorID = new SelectList(context.Doadors.OrderBy(d => d.Nome), "DoadorID", "Nome");
            ViewBag.UsuarioID = new SelectList(context.Usuarios.OrderBy(u => u.Nome), "UsuarioID", "Nome");
            return View(consulta);
        }

        [HttpPost]
        public IActionResult Edit(Movimentacao movimentacao)
        {
            repositorio.Edit(movimentacao);
            return RedirectToAction("List");
        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            var consulta = repositorio.PesquisarMovimentacao(id);
            return View(consulta);
        }

        [HttpPost]
        public IActionResult Delete(Movimentacao movimentacao)
        {
            repositorio.Delete(movimentacao);
            return RedirectToAction("HomeController");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
