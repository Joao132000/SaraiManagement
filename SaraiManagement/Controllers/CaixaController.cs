﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models.Classes;
using SaraiManagement.Models.ClassesEF;
using SaraiManagement.Models;
using SaraiManagement.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;//

namespace SaraiManagement.Controllers
{
    public class CaixaController : Controller
    {
        private ICaixaRepositorio repositorio;
        private ApplicationDbContext context;

<<<<<<< HEAD
        public CaixaController (ICaixaRepositorio repo, ApplicationDbContext ctx)
=======
        public CaixaController(ICaixaRepositorio repo, ApplicationDbContext ctx)
>>>>>>> 265343e9c68689610706a538e718077a9be023c4
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
