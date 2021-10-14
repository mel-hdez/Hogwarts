using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hogwarts.Models;
using Hogwarts.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Hogwarts.Controllers
{
    public class HomeController : Controller
    {
        const string SessionUser = "_User";
        public IConfiguration Configuration { get; }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario model)
        {
            using(var db = new DataContext())
            {
                if(model.Id.Equals("") || model.Contrasena == null
                    || model.Contrasena.Equals(""))
                    {
                        ModelState.AddModelError("", "Ingrese datos correctos");
                    }
                    else
                    {
                        var user = db.Usuarios.SingleOrDefault(x => x.Id == model.Id);
                        if(user == null)
                        {
                            ModelState.AddModelError("", "Ingrese datos correctos");

                        }
                        if(user.Contrasena == model.Contrasena)
                        {
                            HttpContext.Session.SetString("SessionUser", model.Id.ToString());
                            if(user.TipoUsuarioId == 1)
                                return RedirectToAction("Index", "Jefe");
                            if(user.TipoUsuarioId == 2)
                                return RedirectToAction("Index", "Empleado");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Ingrese datos correctos");
                        }
                    }
                return View("Index");
            }
        }

        public IActionResult LogOff()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Home", "Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
