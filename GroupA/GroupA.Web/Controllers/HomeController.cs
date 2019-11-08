using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupA.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.NombreEmpresa = "Group A";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Nosotros";
            ViewBag.Mision = "Ser una empresa encargada del desarrollo de sistemas Web para empresas ofreciendo un servicio de alta calidad,tecnología confiable y diseños de vanguardia. Maximizando el potencial de nuestros clientes a través del internet.";
            ViewBag.Vision = "Ser la empresa de desarrolladores de Páginas Web más elegida y cotizada por su compromiso, originalidad  y capacidad de potenciar a nuestros clientes en el mercado digital.";
            var lista = new List<String>();
            lista.Add("Poder captar la idea del cliente, darle estética y funcionalidad.");
            lista.Add("Calidad adaptable a todos los navegadores, dándole prioridad a la usabilidad.");
            lista.Add("Que los proyectos de nuestros clientes alcancen una mayor visibilidad a nivel global");
            ViewBag.Objetivos = lista;
           
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}