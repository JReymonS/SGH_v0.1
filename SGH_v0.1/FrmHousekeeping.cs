using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
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
            this.ActiveControl = BtnSalir;

        }
        void ActualizarTabla()
        {
            mh.MostrarHousekeeping("SELECT Numero_Habitacion AS 'NO.', Tipo_Habitacion AS 'TIPO', Estado AS 'ESTADO_HABITACION', Capacidad AS 'CAPACIDAD', Piso AS 'PISO' FROM Habitaciones", DtgDatos, "Habitaciones");

            ActualizarContadoresVisuales();
            int mostrados = DtgDatos.Rows.Count;
            int totales = mh.ContarTotalHabitaciones();
            Lblinformacion.Text = $"Mostrando {mostrados} de {totales} habitaciones";
        }

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

        private void TxtBuscarHabitacion_TextChanged(object sender, EventArgs e)
        {
           
            if (TxtBuscarHabitacion.Text != "Buscar habitación..." && DtgDatos.DataSource != null)
            {
                DataTable dt = (DataTable)DtgDatos.DataSource;
                dt.DefaultView.RowFilter = string.Format("[NO.] LIKE '%{0}%'", TxtBuscarHabitacion.Text);
            }
        }

        private void TxtBuscarHabitacion_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarHabitacion.Text == "Buscar habitación...")
            {
                TxtBuscarHabitacion.Text = "";
                TxtBuscarHabitacion.ForeColor = Color.Black;
            }
        }

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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas regresar al menú principal?",
        "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmHousekeeping_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void BtnEnLimpieza_Click(object sender, EventArgs e)
        {
            if (DtgDatos.CurrentRow != null)
            {
            
                string noHab = DtgDatos.CurrentRow.Cells["NO."].Value.ToString();

                mh.ActualizarEstado(noHab, "Limpieza");

                ActualizarTabla();
                MessageBox.Show($"Habitación {noHab} ahora está en Limpieza", "Éxito");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una habitación de la lista.");
            }
        }

        private void BtnEnMantenimiento_Click(object sender, EventArgs e)
        {
            if (DtgDatos.CurrentRow != null)
            {
               
                string noHab = DtgDatos.CurrentRow.Cells["NO."].Value.ToString();

                mh.ActualizarEstado(noHab, "Mantenimiento");

                ActualizarTabla();
                MessageBox.Show($"Habitación {noHab} ahora está en Mantenimiento", "Éxito");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una habitación de la lista.");
            }
        }

        private void BtnOcupada_Click(object sender, EventArgs e)
        {
            if (DtgDatos.CurrentRow == null) return;
            string noHab = DtgDatos.CurrentRow.Cells["NO."].Value.ToString();
            var hab = mh.ObtenerHabitacion(noHab);

            if (hab.Id_Reserva == 0)
            {
                MessageBox.Show("No hay una reservación activa para esta habitación.", "Validación");
                return;
            }

            mh.ActualizarEstado(noHab, "Ocupada");
            ActualizarTabla();
        }

        private void BtnDisponible_Click(object sender, EventArgs e)
        {
            if (DtgDatos.CurrentRow == null) return;

            string estadoActual = DtgDatos.CurrentRow.Cells["ESTADO_HABITACION"].Value.ToString();
            string noHab = DtgDatos.CurrentRow.Cells["NO."].Value.ToString();

            // REGLA: No puedes poner Disponible si está Ocupada (Falta Check-out)
            if (estadoActual == "Ocupada")
            {
                MessageBox.Show("El huésped aún no hace Check-out. No se puede liberar.", "Aviso");
                return;
            }

            // REGLA: Si ya terminaron de limpiar o de reparar
            if (estadoActual == "Limpieza" || estadoActual == "Mantenimiento")
            {
                mh.ActualizarEstado(noHab, "Disponible");
                ActualizarTabla();
                MessageBox.Show($"Habitación {noHab} liberada. Ya es visible en Recepción.", "Éxito");
            }
        }

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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sincronización con la base de datos completada exitosamente.",
                    "Sistema de Housekeeping", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtBuscarHabitacion.Text = "Buscar habitación...";
            TxtBuscarHabitacion.ForeColor = Color.Gray;
            // Esto es vital por si se hizo un Check-in mientras se tenga la pantalla abierta
            ActualizarTabla();
        }

        private void FrmHousekeeping_Shown(object sender, EventArgs e)
        {
            var permiso = FrmHome._usuarioActivo.ListaPermisos.Find(x => x.Id_Modulo == 3);

            if (permiso == null || !permiso.permiso_leer_abrir)
            {
                MessageBox.Show("No tienes permiso para acceder a Housekeeping.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
