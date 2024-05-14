using System.Security.Cryptography.X509Certificates;

namespace LeerData

{
    public class LibroAutor
    {
        public int LibroId{get;set;}

        public int AutorId{get;set;}

        public Libro? Libro {get;set;}

        public Autor? Autor {get;set;}

    }
}