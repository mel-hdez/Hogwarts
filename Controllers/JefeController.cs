using System;
using Hogwarts.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;


namespace Hogwarts.Controllers
{
    public class JefeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public JefeController (ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string userId = HttpContext.Session.GetString("SessionUser");
            try
            {
                using(var db = new DataContext())
                {
                    var user = db.Usuarios.First(i => i.Id == Convert.ToInt32(userId));
                    List<PermisoCumpleano> persC = new List<PermisoCumpleano>();
                    List<PermisoHora> persH = new List<PermisoHora>();
                    List<PermisoEconomico> persE = new List<PermisoEconomico>();
                    var usuarioPorDepartamento = db.Usuarios.
                        Where(i => i.DepartamentoId == user.DepartamentoId)
                        .ToList();
                    foreach (var item in usuarioPorDepartamento)
                    {
                        db.PermisoCumpleanos
                            .Where(p => p.UsuarioId == item.Id)
                            .ToList()
                            .ForEach(p => persC.Add(p));
                        db.PermisoHoras
                            .Where(p => p.UsuarioId == item.Id)
                            .ToList()
                            .ForEach(p => persH.Add(p));
                        db.PermisoEconomicos
                            .Where(p => p.UsuarioId == item.Id)
                            .ToList()
                            .ForEach(p => persE.Add(p));
                    }
                    ViewBag.persC = persC;
                    ViewBag.persH = persH;
                    ViewBag.persE = persE;

                    HttpContext.Session.SetString("pNom", user.PrimerNombre);
                    HttpContext.Session.SetString("sNom", user.SegundoNombre);
                    var dep = db.Departamentos.
                        First(d => d.Id == user.DepartamentoId);

                    ViewBag.user = user;
                    ViewBag.dep = dep;
                    return View();
                }    
            }
            catch (System.Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult AceptarPermiso(string tipoPermiso, string permisoId)
        {
            string userId = HttpContext.Session.GetString("SessionUser");
            int Id = Convert.ToInt32(permisoId);
            using(var db = new DataContext())
            {
                switch (tipoPermiso)
                {
                    case "PC":
                        var permiso = db.PermisoCumpleanos
                            .First(p => p.Id == Id);
                        permiso.Status = true;
                        db.SaveChanges();
                        break;
                    case "PH":
                        var permisoH = db.PermisoHoras
                            .First(p => p.Id == Id);
                        permisoH.Status = true;
                        db.SaveChanges();
                        break;
                    case "PE":
                        var permisoE = db.PermisoEconomicos
                            .First(p => p.Id == Id);
                        permisoE.Status = true;
                        db.SaveChanges();
                        break;
                }
            }
            return RedirectToAction("Index", "Jefe", new {param = userId});
        }

    }
}
