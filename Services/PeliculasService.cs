using Ejemplo1Asp.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo1Asp.Services
{
    public class PeliculasService
    {
        public List<Peliculas> ObtenerPelicula()
        {
            var pelicula1 = new Peliculas()
            {
                Titulo = "Super man",
                Duración = 120,
                Pais ="USA",
                Publicacion = new DateTime (2013, 02, 5)

            };
            var pelicula2 = new Peliculas()
            {
                Titulo = "Spider Man",
                Duración = 150,
                Pais = "USA",
                Publicacion = new DateTime(2013, 05, 5)

            };
            return new List<Peliculas> { pelicula1, pelicula2 };
        }
        


    }

}