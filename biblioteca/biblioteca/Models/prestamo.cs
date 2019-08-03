using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace biblioteca.Models
{
    public class prestamo
    {
        public int idlibro { get; set; }
        public int idsocio { get; set; }
        public DateTime fecha { get; set; }
    }
}