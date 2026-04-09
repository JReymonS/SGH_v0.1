using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habitaciones
    {
        public Habitaciones() { }
        public Habitaciones(string numero_Habitacion, string tipo_Habitacion, double costo_Noche, int piso, int capacidad, string descripcion, string estado, int id_Reserva)
        {
            Numero_Habitacion = numero_Habitacion;
            Tipo_Habitacion = tipo_Habitacion;
            Costo_Noche = costo_Noche;
            Piso = piso;
            Capacidad = capacidad;
            Descripcion = descripcion;
            Estado = estado;
            Id_Reserva = id_Reserva;
        }

        public string Numero_Habitacion { get; set; }
        public string Tipo_Habitacion { get; set; }
        public double Costo_Noche { get; set; }
        public int Piso { get; set; }
        public int Capacidad { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public int Id_Reserva {  get; set; }
    }
}
