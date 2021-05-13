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
    public class OutrosController : Controller
    {
        private IOutrosRepositorio repositorio;
        private ApplicationDbContext context;
        public OutrosController(IOutrosRepositorio repo, ApplicationDbContext ctx)
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
