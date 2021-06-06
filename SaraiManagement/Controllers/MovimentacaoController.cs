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
        public async Task<IActionResult> List(int searchString)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var tipo = HttpContext.Session.GetString("tipo_session");
                if (tipo.ToString() == "Admin")
                {
                    ViewBag.CaixaID = new SelectList(context.Caixas, "CaixaID", "Descricao");

                    var movimentacao = from e in repositorio.Movimentacoes.OrderBy(e => e.Descricao) select e;

                    if (searchString != 0)
                    {
                        movimentacao = movimentacao.Where(s => s.Caixa.CaixaID == searchString);
                    }

                    return View(await movimentacao.ToListAsync());
                }
                else 
                {
                    return RedirectToAction("Index", "TelaInicial");
                }
            }
            else
            {
                return RedirectToAction("Login", "Usuario");
            }
        }





        [HttpGet]  //Serve para gerar a View
        public IActionResult Create()//ViewBag + .Nome // ordenados pelo Nome
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var a = HttpContext.Session.GetString("usuario_session1");
                int i = int.Parse(a.ToString());
                ViewBag.UsuarioID = new SelectList(context.Usuarios.Where(d => d.UsuarioID == i), "UsuarioID", "Nome");
                ViewBag.CaixaID = new SelectList(context.Caixas.OrderBy(c => c.CaixaID), "CaixaID", "Descricao");
                ViewBag.DoadorID = new SelectList(context.Doadors.OrderBy(d => d.Nome), "DoadorID", "Nome");
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
            movimentacao.DataMovimentacao = DateTime.Now;
            repositorio.Create(movimentacao);
            foreach (var item in context.Caixas)
            {
                if (item.CaixaID == movimentacao.CaixaID)
                {
                    if(movimentacao.TipoMovimentacao == tipoMovimentacao.Debito)
                    {
                        item.Saldo = item.Saldo - movimentacao.Valor;
                    }
                    else
                    {
                        item.Saldo = item.Saldo + movimentacao.Valor;
                    }

                }
            }
            context.SaveChanges();
            return View("ValidacaoSucesso");
        }

        [HttpGet]
        public IActionResult Consultar(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var tipo = HttpContext.Session.GetString("tipo_session");
                if (tipo.ToString() == "Admin")
                {
                    var consulta = repositorio.PesquisarMovimentacao(id);
                    return View(consulta);
                }else 
                {
                    return RedirectToAction("Index", "TelaInicial");
                }
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
                    var consulta = context.Movimentacaos.Find(id);
                    ViewBag.CaixaID = new SelectList(context.Caixas.OrderBy(c => c.CaixaID), "CaixaID", "Descricao");
                    ViewBag.DoadorID = new SelectList(context.Doadors.OrderBy(d => d.Nome), "DoadorID", "Nome");
                    ViewBag.UsuarioID = new SelectList(context.Usuarios.OrderBy(u => u.Nome), "UsuarioID", "Nome");
                    return View(consulta);
                }
                else
                {
                    return RedirectToAction("Index", "TelaInicial");
                }
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
            return View("ValidacaoSucesso");
        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var tipo = HttpContext.Session.GetString("tipo_session");
                if (tipo.ToString() == "Admin")
                {
                    var consulta = repositorio.PesquisarMovimentacao(id);
                    return View(consulta);
                }
                else
                {
                    return RedirectToAction("Index", "TelaInicial");
                }
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
            return View("ValidacaoSucesso");
        }
    }
}
