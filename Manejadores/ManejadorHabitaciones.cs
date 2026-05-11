using AccesoDatos;
using DocumentFormat.OpenXml.Wordprocessing;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

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
            tabla.BorderStyle = BorderStyle.None;
            tabla.BackgroundColor = Color.White;
            tabla.GridColor = Color.FromArgb(220, 220, 220);
            tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabla.RowHeadersVisible = false;
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToResizeRows = false;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.MultiSelect = false;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.ScrollBars = ScrollBars.Vertical;
            tabla.EnableHeadersVisualStyles = false;

            // === ENCABEZADO (Header) ===
            tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 80, 80);
            tabla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 8, 0, 8);
            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.ColumnHeadersHeight = 40;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // === FILAS (alternando colores) ===
            //tabla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            tabla.DefaultCellStyle.BackColor = Color.White;
            tabla.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            tabla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.DefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            tabla.RowTemplate.Height = 45;
                
            

            //
            tabla.Columns.Clear();
            tabla.DataSource = b.Consulta(consulta, datos).Tables[0];
            tabla.Columns.Insert(5, Boton("RESERVAR", Color.Orange));
            tabla.Columns.Insert(6, Boton("CHECK-IN", Color.Green));
            tabla.Columns.Insert(7, Boton("CHECK-OUT", Color.Red));
            tabla.Columns["COSTO_NOCHE"].Visible = false;
            tabla.Columns["ESTADO"].Visible = false;

            // === FILA SELECCIONADA ===
            tabla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 214, 255);
            tabla.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);

            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        // Housekeeping (Sin botones extra)
        public int ConsultarReserva(string consulta) 
        {
           var rs = b.Consulta(consulta, "Existencia").Tables[0].Rows[0][0];
           int no = int.Parse(rs.ToString());
           return no;
        }
        
        public void MostrarHousekeeping(string consulta, DataGridView tabla, string datos)
        {
            tabla.BorderStyle = BorderStyle.None;
            tabla.BackgroundColor = Color.White;
            tabla.GridColor = Color.FromArgb(220, 220, 220);
            tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabla.RowHeadersVisible = false;
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToResizeRows = false;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.MultiSelect = false;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.ScrollBars = ScrollBars.Vertical;
            tabla.EnableHeadersVisualStyles = false;

            tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 80, 80);
            tabla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 8, 0, 8);
            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.ColumnHeadersHeight = 40;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            tabla.DefaultCellStyle.BackColor = Color.White;
            tabla.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            tabla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.DefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            tabla.RowTemplate.Height = 45;

            tabla.Columns.Clear();
            tabla.DataSource = b.Consulta(consulta, datos).Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            tabla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 214, 255);
            tabla.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20,20,20);
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
        //

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
        public string Check_Out(Habitaciones habitacion)
        {
            DataSet ds = b.Consulta(
                $"CALL SP_CheckOut('{habitacion.Numero_Habitacion}');",
                "resultado"
            );

            if (ds.Tables["resultado"].Rows.Count > 0)
            {
                return ds.Tables["resultado"].Rows[0]["Resultado"].ToString();
            }

            return "ERROR: No se obtuvo respuesta del procedimiento";
        }
    }
}
