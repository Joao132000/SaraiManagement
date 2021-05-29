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
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;


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
        public ViewResult List(int pagina = 1)=> View(new MovimentacaoListViewModel
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
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                ViewBag.CaixaID = new SelectList(context.Caixas.OrderBy(c => c.CaixaID), "CaixaID", "Descricao");
                ViewBag.DoadorID = new SelectList(context.Doadors.OrderBy(d => d.Nome), "DoadorID", "Nome");
                ViewBag.UsuarioID = new SelectList(context.Usuarios.OrderBy(u => u.Nome), "UsuarioID", "Nome");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        [HttpPost] //Executar a ação do metodo que vai modificar o BD - Envia dados para o metodo que modifica o BD
        public IActionResult Create(Movimentacao movimentacao)
        {
            repositorio.Create(movimentacao);
            foreach (var item in context.Caixas)
            {
                if (item.CaixaID == movimentacao.CaixaID)
                {
                    if(movimentacao.TipoMovimentacao == tipoMovimentacao.Credito)
                        item.Saldo = item.Saldo + movimentacao.Valor;
                    else
                        item.Saldo = item.Saldo - movimentacao.Valor;


                }
            }
            context.SaveChanges();
            return RedirectToAction("Index", "TelaInicial");
        }

        [HttpGet]
        public IActionResult Consultar(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var consulta = repositorio.PesquisarMovimentacao(id);
                return View(consulta);
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
                var consulta = context.Movimentacaos.Find(id);
                ViewBag.CaixaID = new SelectList(context.Caixas.OrderBy(c => c.CaixaID), "CaixaID", "Descricao");
                ViewBag.DoadorID = new SelectList(context.Doadors.OrderBy(d => d.Nome), "DoadorID", "Nome");
                ViewBag.UsuarioID = new SelectList(context.Usuarios.OrderBy(u => u.Nome), "UsuarioID", "Nome");
                return View(consulta);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
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
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var consulta = repositorio.PesquisarMovimentacao(id);
                return View(consulta);
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }

        [HttpPost]
        public IActionResult Delete(Movimentacao movimentacao)
        {
            repositorio.Delete(movimentacao);
            return RedirectToAction("HomeController");
        }
    }
}
