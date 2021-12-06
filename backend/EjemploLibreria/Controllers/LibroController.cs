using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EjemploLibreria.Data;
using EjemploLibreria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploLibreria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly LibreriaContext _context;

        public LibroController(LibreriaContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("mostrar")]
        public IActionResult MostrarLibros()
        {
            //List<Libro> libros = new List<Libro>();

            //Libro libro1 = new Libro("Los miserables", "Drama", new DateTime(1830, 12, 31), "20 x 14", "Victo Hugo", 60);
            //Libro libro2 = new Libro("Crimen y Castigo", "Policial", new DateTime(1866, 05, 21), "20 x 14", "Fiódor Dostoyevski", 65);
            //Libro libro3 = new Libro("Frankenstein", "Romanticismo", new DateTime(1818, 01, 01), "20 x 14", "Mary Shelley", 65);
            //Libro libro4 = new Libro("Drácula", "Romanticismo", new DateTime(1801, 05, 21), "20 x 14", "Bram Stoker", 70);
            //Libro libro5 = new Libro("De la Tierra a la Luna", "Ciencia Ficción", new DateTime(1810, 04, 12), "20 x 14", "Fiódor Dostoyevski", 65);


            //libros.Add(libro1);
            //libros.Add(libro2);
            //libros.Add(libro3);
            //libros.Add(libro4);
            //libros.Add(libro5);

            var libros = this._context.Libros.ToList();

            return Ok(libros);
        }



        [HttpPost]
        [Route("actualizar-precio")]
        public IActionResult ActualizarGenero([FromQuery] int id, [FromQuery] decimal precio)
        {


            var libro = this._context.Libros.Where(x => x.IdLibro == id).FirstOrDefault();

            if (libro == null)
            {
                return BadRequest(new { message = "No se encontro el libro" });
            }

            libro.Precio = precio;

            _context.Libros.Update(libro);

            _context.SaveChanges();

            return Ok(new { message = "Se actualizo correctamente" });
        }


    }

}
