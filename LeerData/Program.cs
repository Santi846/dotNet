using System;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Session instance
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

                    // Get prize with the Book

                    // var libros = db.Libro.Include(x => x.PrecioPromocion).AsNoTracking();
                    // foreach (var libro in libros)
                    // {   
                    //     Console.WriteLine(libro.Titulo + "   "  + libro.Descripcion + "   "  + libro.PrecioPromocion?.PrecioActual);
                        
                    // }

                    // Get comments with the Book


                    // if (db.Comentario != null)
                    // {
                    //   var libros = db.Libro.Include(x => x.ComentarioLista).AsNoTracking();
                    // foreach (var libro in libros)
                    // {   
                    //     Console.WriteLine(libro.Titulo);
                    //     foreach (var comentario in libro.ComentarioLista)
                    //     {
                    //         Console.WriteLine(comentario.ComentarioTexto);
                    //     }
                        
                    // }  
                    // }
                

                // Get Book + related author

                    // var libros = db.Libro.Include(x => x.AutorLink).ThenInclude(xi => xi.Autor);
                    
                    // foreach (var libro in libros)
                    // {
                    //     Console.WriteLine(libro.Titulo);
                        
                    //     foreach (var autLink in libro.AutorLink)
                    //     {
                    //         Console.WriteLine(autLink.Autor.Nombre);
                    //     }
                    // }
                
                // Instert data for an entity

                // var newAuthor =  new Autor{
                //     Nombre = "Saltaro",
                //     Apellidos = "Menez",
                //     Grado = "Master"
                // };

                // db.Add(newAuthor);

                // var newAuthor2 =  new Autor{
                //     Nombre = "Julia",
                //     Apellidos = "Perez",
                //     Grado = "Master"
                // };

                // db.Add(newAuthor2);
                // var stateTransaction = db.SaveChanges();

                // Console.WriteLine("Cantidad de Transacciones: " + stateTransaction);

                // }
                // else
                // {
                //     Console.WriteLine("No books found in the database.");


                // Update data for an entity instance

                // var autorPerson = db.Autor?.Single(x=> x.AutorId == 4);

                // if (autorPerson != null)
                // {
                //     autorPerson.Apellidos = "D.Silva";
                //     autorPerson.Grado = "Capa";
                //     var estadoTransaccion = db.SaveChanges();
                //     Console.WriteLine("Actualizacion exitosa: " + estadoTransaccion);
                // }

                // Delete an entity instance

                var autorPerson = db.Autor?.Single(x=> x.AutorId == 6);

                if (autorPerson != null)
                {   
                    db.Remove(autorPerson);
                    var estadoTransaccion = db.SaveChanges();
                    Console.WriteLine("Eliminacion exitosa: " + estadoTransaccion);
                }
                }
            }
        }
    }
}
