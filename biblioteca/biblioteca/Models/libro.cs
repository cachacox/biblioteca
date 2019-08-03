using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace biblioteca.Models
{
    public class libro
    {
        public int idlibro { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public int disponible { get; set; }
        public string localizacion { get; set; }
        public string signatura { get; set; }
    }
}