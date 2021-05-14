using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using SaraiManagement.Models.Classes;
using SaraiManagement.Models;
using SaraiManagement.Models.ClassesEF;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace SaraiManagement.Controllers
{
    public class EstoqueController : Controller
    {
        private IEstoqueRepositorio repositorio;
        private ApplicationDbContext context;
        public EstoqueController(IEstoqueRepositorio repo, ApplicationDbContext ctx)
        {
            repositorio = repo;
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
