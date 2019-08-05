using biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace biblioteca
{
    /// <summary>
    /// Summary description for WS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WS : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataSet consultalibro(int id)
        {
            DataSet tabla = new DataSet();
            libro objlibro = new libro();
            tabla = objlibro.consultalibro(id);
            return tabla;
        }

        [WebMethod]
        public DataSet consultasocio(int id)
        {
            DataSet tabla = new DataSet();
            socio objsocio = new socio();
            tabla = objsocio.consultasocio(id);
            return tabla;
        }

        [WebMethod]
        public void insertarsocio(string nombre, string direccion)
        {
            socio objsocio = new socio();
            objsocio.insertarsocio(nombre, direccion, 1);
        }

        [WebMethod]
        public void insertalibro(string titulo, string autor, int dispo, string localiz, string signa)
        {
            libro objlibro = new libro();
            objlibro.insertarlibro(titulo, autor, dispo, localiz, signa);
        }

        [WebMethod]
        public void eliminarsocio(int id)
        {
            socio objsocio = new socio();
            objsocio.borrarsocio(id);
        }
    }
}
