using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo1Asp.Models
{
    public class Peliculas
    {
        public string Titulo { get; set; }
        public int Duración { get; set; }
        public DateTime Publicacion { get; set; }
        public string Pais { get; set; }
    }
}