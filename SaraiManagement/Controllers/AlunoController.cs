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
;            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
