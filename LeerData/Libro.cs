using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Collections.Generic;

namespace LeerData
{
    public class Libro
    {
        public int LibroId{get;set;}

        public string? Titulo {get;set;}

        public string? Descripcion {get;set;}

        public System.DateTime FechaPublicacion {get;set;}

        public Precio? PrecioPromocion {get;set;}

        // Save more than one commentary
        public ICollection<Comentario>? ComentarioLista {get;set;}

        public ICollection<LibroAutor>? AutorLink {get;set;}

    }
}