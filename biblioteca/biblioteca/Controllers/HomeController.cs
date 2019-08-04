using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace biblioteca.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Socio()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Bibliotecario()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Usuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string valor)
        {
            switch (valor)
            {
                case "Modulo Socio":
                    return RedirectToAction("Socio");
                case "Modulo Bibliotecario":
                    return RedirectToAction("Bibliotecario");
                case "Modulo Usuario":
                    return RedirectToAction("Usuario");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Socio(string valor)
        {
            switch (valor)
            {
                case "1":
                    socioWS ws = new socioWS();
                    ws.leertabla();
                    break;
            }
            return View();
        }
    }
}