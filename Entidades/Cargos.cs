using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cargos
    {
        public Cargos(int id_Cargo, string fecha, string concepto, decimal monto, int id_Reserva)
        {
            Id_Cargo = id_Cargo;
            Fecha = fecha;
            Concepto = concepto;
            Monto = monto;
            Id_Reserva = id_Reserva;
        }

        public int Id_Cargo { get; set; }
        public string Fecha { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }
        public int Id_Reserva { get; set; }

    }
}
