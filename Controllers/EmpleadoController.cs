using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hogwarts.Data;
using Microsoft.AspNetCore.Http;

namespace Hogwarts.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public EmpleadoController (ILogger<HomeController> logger)
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

                    HttpContext.Session.SetString("pNom", user.PrimerNombre);
                    HttpContext.Session.SetString("sNom", user.SegundoNombre);
                    var dep = db.Departamentos.
                        First(d => d.Id == user.DepartamentoId);
                    var perC = db.PermisoCumpleanos.
                        Where(i => i.UsuarioId == user.Id).ToList();
                    var perH = db.PermisoHoras.
                        Where(i => i.UsuarioId == user.Id).ToList();
                    var perE = db.PermisoEconomicos.
                        Where(i => i.UsuarioId == user.Id).ToList();

                    ViewBag.user = user;
                    ViewBag.perC = perC;
                    ViewBag.perH = perH;
                    ViewBag.perE = perE;
                    ViewBag.dep = dep;
                    ViewBag.fecha = user.FechaNacimiento.ToString("yyyy-MMM-dd");
                    return View();
                }    
            }
            catch (System.Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult PermisoHora(string motivo, string horario)
        {
            string _motivo = motivo;
            string _horario = horario;
            string userId = HttpContext.Session.GetString("SessionUser");

            using (var db = new DataContext())
            {
                try
                {
                    DateTime today = DateTime.Today;
                    db.Add(new PermisoHora {
                        Status = false,
                        Motivo = _motivo,
                        Horario = _horario,
                        Fecha = today,
                        UsuarioId = Convert.ToInt32(userId)
                    });
                    db.SaveChanges();
                    return RedirectToAction("Index", "Empleado", new {param = userId});
                }
                catch (System.Exception)
                {
                    ModelState.AddModelError("", "Error al insertar datos");
                    return View("Index");
                }
            }
        }

        [HttpPost]
        public ActionResult PermisoEcono(string fechaInicio, string fechaFinal)
        {
            string _fechaInicio = fechaInicio;
            string _fechaFinal = fechaFinal;
            var userId = HttpContext.Session.GetString("SessionUser");
            DateTime FechaIni = DateTime.Parse(_fechaInicio);
            DateTime FechaFin = DateTime.Parse(_fechaFinal);

            using (var db = new DataContext())
            {
                try
                {
                    db.Add(new PermisoEconomico {
                        Status = false,
                        FechaInicio = FechaIni,
                        FechaFinal = FechaFin,
                        UsuarioId = Convert.ToInt32(userId)
                    });
                    db.SaveChanges();
                    return RedirectToAction("Index", "Empleado", new {param = userId});
                }
                catch (System.Exception)
                {
                    ModelState.AddModelError("", "Error al insertar datos");
                    return View("Index");
                }
            }
        }

        [HttpPost]
        public IActionResult PermisoCumple(string fechaCumple)
        {
            string _fechaCumple = fechaCumple;
            var userId = HttpContext.Session.GetString("SessionUser");
            DateTime FechaC = DateTime.Parse(_fechaCumple);
            using (var db = new DataContext())
            {
                try
                {
                    db.Add(new PermisoCumpleano {
                        Status = false,
                        Fecha = FechaC,
                        UsuarioId = Convert.ToInt32(userId)
                    });
                    db.SaveChanges();
                    return RedirectToAction("Index", "Empleado", new {param = userId});
                }
                catch (System.Exception)
                {
                    ModelState.AddModelError("", "Error al insertar datos");
                    return View("Index");
                }
            }
        }
    }
}
