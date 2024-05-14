using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace LeerData

{
    public class Autor
    {
        public int AutorId{get;set;}

        public string? Nombre {get;set;}

        public string? Apellidos {get;set;}

        public string? Grado{get;set;}

        public byte[]? FotoPerfil {get;set;}

        // public int LibroId {get;set;}

        // public Libro? Libro {get;set;}

        // public ICollection<Libro>? Lib {get;set;}
        public ICollection<LibroAutor>? LibroLink {get;set;}

    }
}