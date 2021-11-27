using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DocenteController : Controller
    {
        // GET: Docente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Docente()
        {
            /*DocenteModels D = new DocenteModels { legajo = 1, Nombre = "Fabio", Apellido = "Gross",  Materia = "Prog Web" };
            DocenteModels D1 = new DocenteModels { legajo = 2, Nombre = "Federico", Apellido = "Trani", Materia = "Prog Movil" };
            DocenteModels D2 = new DocenteModels { legajo = 3, Nombre = "Fernando", Apellido = "Lopez", Materia = "Analisis Matematico" };

            List<DocenteModels> lista = new List<DocenteModels> { D, D1, D2 };*/
            ViewBag.Message = "Listado de Docentes";

            List<DocenteModels> lista_Docentes = null;
            try
            {
                using (var db = new ITES_MVCEntities())
                {
                    lista_Docentes = (from docente in db.Docentes
                                      select new DocenteModels { 
                                      legajo = docente.legajo,
                                      Nombre = docente.Nombre,
                                      Apellido = docente.Apellido,
                                      Materia = docente.Materia,
                                      Mail = docente.Mail
                                      }).ToList();

                    return View(lista_Docentes);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}