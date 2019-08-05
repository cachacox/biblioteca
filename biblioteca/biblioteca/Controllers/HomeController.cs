using biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace biblioteca.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.WSSoapClient ws = new ServiceReference1.WSSoapClient();
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
        public ActionResult Socio(socio socio, string valor)
        {
            switch (valor)
            {
                case "Buscar":
                    if (socio.idsocio > 0)
                    {
                        DataSet dts = new DataSet();
                        int intsocio = socio.idsocio;
                        dts = ws.consultasocio(intsocio);
                        socio.tblsocio = dts.Tables[0];
                        return View();
                    }
                    break;
                case "Insertar":                    
                    ws.insertarsocio(socio.nombre, socio.direccion);
                    break;
                case "Eliminar":
                    int intsocio1 = socio.idsocio;
                    ws.eliminarsocio(intsocio1);
                    break;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Usuario(libro libro)
        {
            DataSet dts = new DataSet();
            int intlibro = libro.idlibro;
            dts = ws.consultalibro(intlibro);
            return View();           
        }
    }
}