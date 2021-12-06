using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploLibreria.Models
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Dimension { get; set; }
        public string Autor { get; set; }
        public float Precio { get; set; }

        public Libro(string titulo, string genero, DateTime fechaPublicacion, string dimension, string autor, float precio)
        {
            Titulo = titulo;
            Genero = genero;
            FechaPublicacion = fechaPublicacion;
            Dimension = dimension;
            Autor = autor;
            Precio = precio;
        }
    }
}
