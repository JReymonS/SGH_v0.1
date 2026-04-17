using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reservas
    {
        public int Id_Reserva { get; set; }
        public DateTime Fecha_Entrada { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public string Estado_Pago { get; set; }
        public decimal Anticipo { get; set; }
        public string RFC { get; set; }
        public int Id_Usuario { get; set; }

        // Datos del huésped (para mostrar en formularios)
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        // Datos de habitación (para CheckIn)
        public string Numero_Habitacion { get; set; }
        public string Tipo_Habitacion { get; set; }
        public double Costo_Noche { get; set; }
        public int Piso { get; set; }
        public int Capacidad { get; set; }
        public string Descripcion { get; set; }

        // Calculados
        public int Dias { get; set; }
        public decimal CostoTotal { get; set; }
        public decimal Restante { get; set; }

        public Reservas() { }
    }
}
