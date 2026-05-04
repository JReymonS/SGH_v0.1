using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorDashboard
    {
        Base b = new Base("localhost", "root", "2026", "SistemaGestionHotelera", 3311);

        // Tupla
        public (int disponible, int ocupada, int limpieza, int mantenimiento) SumaDeEstado()
        {
            DataSet ds = b.Consulta("CALL p_SumaDeEstadoDashboard()", "Habitaciones");

            DataTable dt = ds.Tables[0];

            int dispo = 0, ocupa = 0, limpi = 0, mante = 0;

            if(dt.Rows.Count > 0) //Validar que la tabla no este vacía
            {
                DataRow fila = dt.Rows[0];

                dispo = Convert.ToInt32(fila["Disponible"]);
                ocupa = Convert.ToInt32(fila["Ocupada"]);
                limpi = Convert.ToInt32(fila["Limpieza"]);
                mante = Convert.ToInt32(fila["Mantenimiento"]);

            }
            return (dispo, ocupa, limpi, mante) ;

        }

        public DataTable ActividadReciente()
        {
            string consulta = "SELECT * FROM v_ActividadReciente ORDER BY FECHA DESC LIMIT 10";

            DataSet ds = b.Consulta(consulta, "ActividadReciente"); return ds.Tables[0];

        }



    }
}
