using Ejemplo1Asp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1Asp.Controllers
{
    public class OperasBasController : Controller
    {
        // GET: OperasBas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MuestraPeliculas()
        {
            var PeliculasService = new PeliculasService();
            var model = PeliculasService.ObtenerPelicula();
            return View();
        }
        public ActionResult Sumar()
        {
            var tem = new Calculos();
            return View(tem);
        }


        [HttpPost]
        public ActionResult Sumar(Calculos calculos, string r1)
        {
            var tem = new Calculos();
            tem = calculos;
            if (r1.Equals("Sumar"))
            {
                tem.Suma();
            }
            if (r1.Equals("Restar"))
            {
                tem.Resta();
            }
            ViewBag.res = tem.Resultado;
            return View();
        }

         public RedirectToRouteResult Temporal()
        {

            /*var alumno1 = new Alumno() { Nombre = "Iza", edad = 15 };
            var alumno2 = new Alumno() { Nombre = "Iza", edad = 15 };
            return Json(new List<Alumno>() { alumno1, alumno2},
                                                        JsonRequestBehavior.AllowGet);*/
            //return View();

            /*return Redirect("https://google.com.mx");*/

            return RedirectToAction("About","Home");

        }

        public ActionResult vista()
        {
            ViewBag.Nombre = "Sofia";
            ViewData["Nombre"] = "Iza";
            return View();
        }
    }
}