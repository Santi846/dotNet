using System.Security.Cryptography.X509Certificates;

namespace LeerData
{
    public class Libro
    {
        public int LibroId{get;set;}

        public string? Titulo {get;set;}

        public string? Descripcion {get;set;}

        public System.DateTime FechaPublicacion {get;set;}

    }
}