using System;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
           using(var db = new AppVentaLibrosContext())
        //    {
        //     var libros = db.Libro.AsNoTracking();

        //     foreach (var libro in libros)
        //     {
        //         Console.WriteLine(libro.Titulo);
        //     }
        //    }
        {
                if (db.Libro != null)
                {
                    // var libros = db.Libro.Include(x => x.PrecioPromocion).AsNoTracking();
                    // foreach (var libro in libros)
                    // {   
                    //     Console.WriteLine(libro.Titulo + "   "  + libro.Descripcion + "   "  + libro.PrecioPromocion?.PrecioActual);
                        
                    // }
                    if (db.Comentario != null)
                    {
                      var libros = db.Libro.Include(x => x.ComentarioLista).AsNoTracking();
                    foreach (var libro in libros)
                    {   
                        Console.WriteLine(libro.Titulo);
                        foreach (var comentario in libro.ComentarioLista)
                        {
                            Console.WriteLine(comentario.ComentarioTexto);
                        }
                        
                    }  
                    }
                    
                }
                else
                {
                    Console.WriteLine("No books found in the database.");
                }
            }
        }
    }
}
