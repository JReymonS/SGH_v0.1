using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Manejadores;

namespace SGH_v0._1
{
    public partial class FrmHousekeeping : Form
    {
        ManejadorHabitaciones mh = new ManejadorHabitaciones();
        public FrmHousekeeping()
        {
            InitializeComponent();
            TxtBuscarHabitacion.Text = "Buscar habitación...";
            TxtBuscarHabitacion.ForeColor = Color.Gray;
        }


        //Actualizar tabla de habitaciones
        void ActualizarTabla()
        {
            mh.MostrarHousekeeping("SELECT Numero_Habitacion AS 'NO.', Tipo_Habitacion AS 'TIPO', Estado AS 'ESTADO_HABITACION', Capacidad AS 'CAPACIDAD', Piso AS 'PISO' FROM Habitaciones", DtgDatos, "Habitaciones");
            ActualizarContadoresVisuales();
            int mostrados = DtgDatos.Rows.Count;
            int totales = mh.ContarTotalHabitaciones();
            Lblinformacion.Text = $"Mostrando {mostrados} de {totales} habitaciones";
        }


        //Actualizar los controles visuales
        void ActualizarContadoresVisuales()
        {
            int disp = 0, ocup = 0, limp = 0, mant = 0;
            int mostrados = DtgDatos.Rows.Count;
            int totales = mh.ContarTotalHabitaciones();

            // VALIDACIÓN: Si no hay filas, ponemos todo en 0 y salimos
            if (DtgDatos.Rows.Count == 0)
            {
                LblhabitacionesDisp.Text = "0"; LblhabitacionesOcup.Text = "0";
                LblhabitacionesLimp.Text = "0"; LblhabitacionesMante.Text = "0";
                return;
            }

            foreach (DataGridViewRow row in DtgDatos.Rows)
            {
                var cellValue = row.Cells["ESTADO_HABITACION"].Value;
                if (cellValue != null)
                {
                    string estado = cellValue.ToString();
                    if (estado == "Disponible") disp++;
                    else if (estado == "Ocupada") ocup++;
                    else if (estado == "Limpieza") limp++;
                    else if (estado == "Mantenimiento") mant++;
                }
            }
            LblhabitacionesDisp.Text = disp.ToString();
            LblhabitacionesOcup.Text = ocup.ToString();
            LblhabitacionesLimp.Text = limp.ToString();
            LblhabitacionesMante.Text = mant.ToString();
            Lblinformacion.Text = $"Mostrando {mostrados} de {totales} habitaciones";
        }


        //Evento para texto fantasma
        private void TxtBuscarHabitacion_TextChanged(object sender, EventArgs e)
        {
           
            if (TxtBuscarHabitacion.Text != "Buscar habitación..." && DtgDatos.DataSource != null)
            {
                DataTable dt = (DataTable)DtgDatos.DataSource;
                dt.DefaultView.RowFilter = string.Format("[NO.] LIKE '%{0}%'", TxtBuscarHabitacion.Text.Split('\''));
            }
        }


        //Evento 2 para texto fantasma
        private void TxtBuscarHabitacion_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarHabitacion.Text == "Buscar habitación...")
            {
                TxtBuscarHabitacion.Text = "";
                TxtBuscarHabitacion.ForeColor = Color.Black;
            }
        }


        //Evento 3 para texto fantasma
        private void TxtBuscarHabitacion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBuscarHabitacion.Text))
            {
                TxtBuscarHabitacion.Text = "Buscar habitación...";
                TxtBuscarHabitacion.ForeColor = Color.Gray;

                if (DtgDatos.DataSource != null)
                {
                    ((DataTable)DtgDatos.DataSource).DefaultView.RowFilter = "";
                    ActualizarContadoresVisuales();
                }
            }
        }


        //Actualizar la tabla al cargar el formulario
        private void FrmHousekeeping_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }


        //Cambiar estado a limpieza
        private void BtnEnLimpieza_Click(object sender, EventArgs e)
        {
            if (DtgDatos.CurrentRow != null)
            {
                string noHab = DtgDatos.CurrentRow.Cells["NO."].Value.ToString();
                mh.ActualizarEstado(noHab, "Limpieza");
                ActualizarTabla();
                MessageBox.Show($"Habitación: {noHab}, ahora está en estado de: \"Limpieza\".", "¡ATENCIÓN!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una habitación de la lista.","¡ATENCIÓN!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }


        //Cambiar estado a mantenimiento
        private void BtnEnMantenimiento_Click(object sender, EventArgs e)
        {
            if (DtgDatos.CurrentRow != null)
            {  
                string noHab = DtgDatos.CurrentRow.Cells["NO."].Value.ToString();
                mh.ActualizarEstado(noHab, "Mantenimiento");
                ActualizarTabla();
                MessageBox.Show($"Habitación: {noHab}, ahora está en estado de: \"Mantenimiento\".", "¡ATENCIÓN!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una habitación de la lista.","¡ATENCIÓN!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Cambiar estado a ocupada
        private void BtnOcupada_Click(object sender, EventArgs e)
        {
            if (DtgDatos.CurrentRow == null) return;
            string noHab = DtgDatos.CurrentRow.Cells["NO."].Value.ToString();
            var hab = mh.ObtenerHabitacion(noHab);
            if (hab.Id_Reserva == 0)
            {
                MessageBox.Show($"No hay una reserva para la habitación: {noHab}, solo se podrá poner en \"Ocupada\" una habitación con reserva.", "¡VALIDACIÓN!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            mh.ActualizarEstado(noHab, "Ocupada");
            ActualizarTabla();
        }


        //Cambiar estado a disponible
        private void BtnDisponible_Click(object sender, EventArgs e)
        {
            if (DtgDatos.CurrentRow == null) return;

            string estadoActual = DtgDatos.CurrentRow.Cells["ESTADO_HABITACION"].Value.ToString();
            string noHab = DtgDatos.CurrentRow.Cells["NO."].Value.ToString();
            int estadoReserva = mh.ConsultarReserva($"SELECT COUNT(*) AS \"Existencia\" FROM Reservas r JOIN Habitaciones h ON r.Numero_Habitacion = h.Numero_Habitacion WHERE r.Numero_Habitacion = \"{noHab}\" AND Estado_Pago = \"Pagado\"OR Estado_Pago=\"Pendiente\";");

            // REGLA: No puedes poner Disponible si está Ocupada (Falta Check-out)
            if (estadoReserva >0)
            {
                MessageBox.Show($"El huésped de la habitación: {noHab}, aún no hace CHECK-OUT. Vuelva a colocar la habitación en \"Ocupada\".", "¡AVISO!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            // REGLA: Si ya terminaron de limpiar o de reparar
            if (estadoActual == "Limpieza" || estadoActual == "Mantenimiento")
            {
                mh.ActualizarEstado(noHab, "Disponible");
                ActualizarTabla();
                MessageBox.Show($"Habitación: {noHab}, ahora está en estado: \"Disponible\". Ahora es visible en habitaciones.", "¡ATENCIÓN!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }


        //Formatear el data grid de housekeeping
        private void DtgDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DtgDatos.Columns[e.ColumnIndex].Name == "ESTADO_HABITACION")
            {
                if (e.Value != null)
                {
                    string estado = e.Value.ToString();
                    switch (estado)
                    {
                        case "Disponible":
                            e.CellStyle.BackColor = Color.LightGreen;
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                        case "Ocupada":
                            e.CellStyle.BackColor = Color.FromArgb(255, 192, 192); // Rojo suave
                            e.CellStyle.ForeColor = Color.DarkRed;
                            break;
                        case "Limpieza":
                            e.CellStyle.BackColor = Color.Orange;
                            e.CellStyle.ForeColor = Color.White;
                            break;
                        case "Mantenimiento":
                            e.CellStyle.BackColor = Color.LightYellow;
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                    }
                }
            }
        }


        //Guardar cambios / sincronizar con la BD
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sincronización y actualización de datos completada exitosamente.","¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtBuscarHabitacion.Text = "Buscar habitación...";
            TxtBuscarHabitacion.ForeColor = Color.Gray;
            ActualizarTabla();
        }


        //Evento para cargar permisos
        private void FrmHousekeeping_Shown(object sender, EventArgs e)
        {
            var permiso = FrmHome._usuarioActivo.ListaPermisos.Find(x => x.Id_Modulo == 3);

            if (permiso == null || !permiso.permiso_leer_abrir)
            {
                MessageBox.Show("No tienes permiso para acceder al módulo Housekeeping.","¡ACCESO DENEGADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            if (!permiso.permiso_escritura)
            {
                BtnGuardar.Enabled = false;
                BtnEnMantenimiento.Enabled = false;
                BtnOcupada.Enabled = false;
                BtnDisponible.Enabled = false;
                BtnEnLimpieza.Enabled = false;
            }
        }
    }
}
