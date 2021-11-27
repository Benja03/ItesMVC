using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Alumno()
        {
            AlumnoModels A = new AlumnoModels { legajo = 1, Apellido = "Berterreix", Nombre = "Benjamin" };
            AlumnoModels A1 = new AlumnoModels { legajo = 2, Apellido = "Pignol", Nombre = "Manuel" };
            AlumnoModels A2 = new AlumnoModels { legajo = 3, Apellido = "Salucho", Nombre = "Mariana" };

            List<AlumnoModels> lista = new List<AlumnoModels> { A, A1, A2 };
            ViewBag.Message = "Listado de Alumnos";

            return View(lista); 
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}