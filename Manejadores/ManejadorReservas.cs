using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Windows.Forms;
using System.Data;

namespace Manejadores
{
    public class ManejadorReservas
    {
        Base b = new Base("localhost", "root", "2026", "SistemaGestionHotelera");
        public string Crear(string numeroHabitacion, DateTime entrada, DateTime salida, decimal anticipo, string rfc, int idUsuario)
        {
            string sql =
                $"CALL SP_CrearReserva(" +
                $"'{numeroHabitacion}'," +
                $"'{entrada:yyyy-MM-dd HH:mm:ss}'," +
                $"'{salida:yyyy-MM-dd HH:mm:ss}'," +
                $"{anticipo.ToString(System.Globalization.CultureInfo.InvariantCulture)}," +
                $"'{rfc}'," +
                $"{idUsuario});";

            DataSet ds = b.Consulta(sql, "resultado");

            if (ds.Tables["resultado"] != null && ds.Tables["resultado"].Rows.Count > 0)
                return ds.Tables["resultado"].Rows[0]["Resultado"].ToString();

            return "ERROR: Sin respuesta del servidor";
        }
        public void GuardarHuesped(string rfc, string nombre, string apellidos,
                                   string correo, string telefono)
        {
            b.Comando($"CALL SP_InsertarHuesped('{rfc}','{nombre}','{apellidos}'," +
                      $"'{correo}','{telefono}');");
        }
        public Reservas ObtenerHuesped(string rfc)
        {
            DataSet ds = b.Consulta($"CALL SP_ObtenerHuesped('{rfc}');", "huesped");

            if (ds.Tables["huesped"].Rows.Count == 0) return null;

            DataRow r = ds.Tables["huesped"].Rows[0];
            return new Reservas
            {
                RFC = r["RFC"].ToString(),
                Nombre = r["Nombre"].ToString(),
                Apellidos = r["Apellidos"].ToString(),
                Correo = r["Correo"].ToString(),
                Telefono = r["Telefono"].ToString()
            };
        }
        public Reservas ObtenerCheckIn(string numeroHabitacion)
        {
            DataSet ds = b.Consulta(
                $"CALL SP_ObtenerCheckIn('{numeroHabitacion}');", "checkin");

            if (ds.Tables["checkin"].Rows.Count == 0) return null;

            DataRow r = ds.Tables["checkin"].Rows[0];
            return new Reservas
            {
                Numero_Habitacion = r["Numero_Habitacion"].ToString(),
                Tipo_Habitacion = r["Tipo_Habitacion"].ToString(),
                Capacidad = Convert.ToInt32(r["Capacidad"]),
                Piso = Convert.ToInt32(r["Piso"]),
                Descripcion = r["Descripcion"].ToString(),
                Costo_Noche = Convert.ToDouble(r["Costo_Noche"]),
                Nombre = r["Nombre"].ToString(),
                Apellidos = r["Apellidos"].ToString(),
                Correo = r["Correo"].ToString(),
                Telefono = r["Telefono"].ToString(),
                Dias = Convert.ToInt32(r["Dias"]),
                CostoTotal = Convert.ToDecimal(r["CostoTotal"]),
                Anticipo = Convert.ToDecimal(r["Anticipo"]),
                Restante = Convert.ToDecimal(r["Restante"]),
                Id_Reserva = Convert.ToInt32(r["Id_Reserva"]),
                Estado_Pago = r["Estado_Pago"].ToString()
            };
        }
        public string RegistrarCheckIn(int idReserva, decimal montoPago)
        {
            string sql =
                $"CALL SP_RegistrarCheckIn(" +
                $"{idReserva}," +
                $"{montoPago.ToString(System.Globalization.CultureInfo.InvariantCulture)});";

            DataSet ds = b.Consulta(sql, "resultado");

            if (ds.Tables["resultado"] != null && ds.Tables["resultado"].Rows.Count > 0)
                return ds.Tables["resultado"].Rows[0]["Resultado"].ToString();

            return "ERROR";
        }
        public string CancelarReserva(int idReserva)
        {
            string sql = $"CALL SP_CancelarReserva({idReserva});";

            DataSet ds = b.Consulta(sql, "resultado");

            if (ds.Tables["resultado"] != null && ds.Tables["resultado"].Rows.Count > 0)
                return ds.Tables["resultado"].Rows[0]["Resultado"].ToString();

            return "ERROR";
        }
        public Reservas ObtenerReservaPorHabitacion(string numeroHabitacion)
        {
            DataSet ds = b.Consulta(
            $"SELECT r.Id_Reserva, r.Fecha_Entrada, r.Fecha_Salida, r.Estado_Pago, " +
            $"r.Anticipo, r.RFC, hg.Nombre, hg.Apellidos, hg.Correo, hg.Telefono " +
            $"FROM Habitaciones h " +
            $"JOIN Reservas r ON r.Id_Reserva = h.Id_Reserva " +
            $"JOIN Huespedes hg ON hg.RFC = r.RFC " +
            $"WHERE h.Numero_Habitacion = '{numeroHabitacion}' " +
            $"AND r.Estado_Pago != 'Cancelado' AND r.Estado_Pago != 'Finalizado';", "reserva"); // ← filtro agregado

            if (ds.Tables["reserva"] == null || ds.Tables["reserva"].Rows.Count == 0)
                return null;

            DataRow r = ds.Tables["reserva"].Rows[0];
            return new Reservas
            {
                Id_Reserva = Convert.ToInt32(r["Id_Reserva"]),
                Fecha_Entrada = Convert.ToDateTime(r["Fecha_Entrada"]),
                Fecha_Salida = Convert.ToDateTime(r["Fecha_Salida"]),
                Estado_Pago = r["Estado_Pago"].ToString(),
                Anticipo = Convert.ToDecimal(r["Anticipo"]),
                RFC = r["RFC"].ToString(),
                Nombre = r["Nombre"].ToString(),
                Apellidos = r["Apellidos"].ToString(),
                Correo = r["Correo"].ToString(),
                Telefono = r["Telefono"].ToString()
            };
        }
    }
}
