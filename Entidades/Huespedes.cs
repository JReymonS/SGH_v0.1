using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Huespedes
    {
        public Huespedes(string rfc, string nombre, string apellidos, string correo, string telefono)
        {
            RFC = rfc;
            Nombre = nombre;
            Apellidos = apellidos;
            Correo = correo;
            Telefono = telefono;
        }

        public string RFC {get;set;}
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public string Correo {get;set;}
        public string Telefono {get;set;}
    }
}
