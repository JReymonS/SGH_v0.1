using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorHabitaciones
    {
        Base b = new Base("localhost", "root", "2026", "SistemaGestionHotelera");

        public void Guardar(Habitaciones habitacion)
        {
            b.Comando($"CALL AgregarHabitacion('{habitacion.Numero_Habitacion}','{habitacion.Tipo_Habitacion}',{habitacion.Costo_Noche}," +
                $"{habitacion.Piso},{habitacion.Capacidad},'{habitacion.Descripcion}',NULL);");
        }

        public void Borrar(Habitaciones habitacion)
        {
            var rs = MessageBox.Show($"Esta seguro de eliminar la habitacion No. {habitacion.Numero_Habitacion}",
                "ATENCIÓN!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from Habitaciones where Numero_Habitacion = '{habitacion.Numero_Habitacion}';");
            }
        }

        public void Modificar(Habitaciones habitacion, string actual)
        {
            b.Comando($"CALL ModificarHabitacion('{actual}', '{habitacion.Numero_Habitacion}', '{habitacion.Tipo_Habitacion}'," +
                $"{Convert.ToDecimal(habitacion.Costo_Noche)}, {habitacion.Piso}, {habitacion.Capacidad}, '{habitacion.Descripcion}' );");
        }

        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consulta(consulta, datos).Tables[0];
            tabla.Columns.Insert(5, Boton("RESERVAR", Color.Orange));
            tabla.Columns.Insert(6, Boton("CHECK-IN", Color.Green));
            tabla.Columns.Insert(7, Boton("CHECK-OUT", Color.Red));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        // Housekeeping (Sin botones extra)
        public void MostrarHousekeeping(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consulta(consulta, datos).Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }
        public static DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
            return btn;
        }
        public Habitaciones ObtenerHabitacion(string numero)
        {
            DataSet ds = b.Consulta(
                $"SELECT * FROM Habitaciones WHERE Numero_Habitacion = '{numero}'",
                "habitaciones"
            );

            if (ds.Tables["habitaciones"].Rows.Count == 0)
                return null;

            DataRow r = ds.Tables["habitaciones"].Rows[0];

            return new Habitaciones()
            {
                Numero_Habitacion = r["Numero_Habitacion"].ToString(),
                Tipo_Habitacion = r["Tipo_Habitacion"].ToString(),
                Costo_Noche = Convert.ToDouble(r["Costo_Noche"]),
                Piso = Convert.ToInt32(r["Piso"]),
                Capacidad = Convert.ToInt32(r["Capacidad"]),
                Descripcion = r["Descripcion"].ToString(),
                Estado = r["Estado"].ToString(),
                Id_Reserva = r["Id_Reserva"] != DBNull.Value ? Convert.ToInt32(r["Id_Reserva"]) : 0
            };
        }
        public bool ExisteHabitacion(string numero)
        {
            // Ejecuta el procedimiento almacenado
            DataSet ds = b.Consulta($"CALL HabitacionExiste('{numero}');", "habitacion");

            if (ds.Tables["habitacion"].Rows.Count > 0)
            {
                int existe = Convert.ToInt32(ds.Tables["habitacion"].Rows[0][0]);
                return existe > 0;
            }

            return false;
        }
        public void ActualizarEstado(string numero, string nuevoEstado)
        {
            b.Comando($"UPDATE Habitaciones SET Estado = '{nuevoEstado}' WHERE Numero_Habitacion = '{numero}';");
        }

        public int ContarTotalHabitaciones()
        {
            DataSet ds = b.Consulta("SELECT COUNT(*) FROM Habitaciones", "count");
            return Convert.ToInt32(ds.Tables["count"].Rows[0][0]);
        }
    }
}
