using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploLibreria.Entities
{
    public class ELibro
    {       

        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Dimension { get; set; }
        public string Autor { get; set; }
        public decimal Precio { get; set; }



        public ELibro(string titulo, string genero, DateTime fechaPublicacion, string dimension, string autor, decimal precio)
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
