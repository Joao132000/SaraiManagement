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
    public class AlimentoController : Controller
    {
        private IAlimentoRepositorio repositorio;

        public AlimentoController(IAlimentoRepositorio repo)
        {
            repositorio = repo;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
