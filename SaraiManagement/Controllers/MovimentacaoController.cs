using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models;
using Microsoft.EntityFrameworkCore;
using SaraiManagement.Models.ViewModels;

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

        public IActionResult Index()
        {
            return View();
        }
    }
}
