using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SaraiManagement.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace SaraiManagement.Controllers
{
    public class TelaInicialController : Controller
    {
        public IActionResult Index()
        {
            var acesso = HttpContext.Session.GetString("usuario_session");

            if (acesso != null)
            {
                return View();
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
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult MyImage()
        {
            return File(@"..\SaraiManagement\Imagens\CadastroAluno.JPG", "image/jpg");
        }
    }
}
