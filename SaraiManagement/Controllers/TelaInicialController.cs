﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SaraiManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaraiManagement.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SaraiManagement.Models.Enuns;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using SaraiManagement.Controllers;

namespace SaraiManagement.Controllers
{
    public class TelaInicialController : Controller
    {
        public IActionResult Index()
        {
            var acesso = HttpContext.Session.GetString("usuario_session");
            if (acesso != null)
            {
                var tipo = HttpContext.Session.GetString("tipo_session");
                if (tipo.ToString() == "Admin")
                    return View();
                else
                    return View("TelaInicioUser");
           }
           else
           {
                return RedirectToAction("Login", "Usuario");
           }
        }
        public IActionResult Sobre()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        public ActionResult MyImage()
        {
            return File(@"..\SaraiManagement\Imagens\CadastroAluno.JPG", "image/jpg");
        }
    }
}
