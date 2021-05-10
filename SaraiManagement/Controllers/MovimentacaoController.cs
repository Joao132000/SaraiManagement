﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace SaraiManagement.Controllers
{
    public class MovimentacaoController : Controller
    {
        private IMovimentacaoRepositorio repositorio;

        public MovimentacaoController(IMovimentacaoRepositorio repo)
        {
            repositorio = repo;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
