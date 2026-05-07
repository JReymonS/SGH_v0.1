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
    public partial class FrmHabitaciones : Form
    {
        ManejadorHabitaciones mh;
        public static Habitaciones habitacion = new Habitaciones("","",0,0,0,"","",0);
        int fila = 0, columna = 0;
        public static Habitaciones habitacionSeleccionada;
        public static string numeroActual;

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            mh.Mostrar($"SELECT * FROM v_Habitaciones WHERE NO LIKE '%{TxtBuscar.Text.Trim('\'')}%';", DtgDatos, "Habitaciones");
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fila < 0) return; // evita error si clic en encabezado

            habitacion.Numero_Habitacion = DtgDatos.Rows[fila].Cells[0].Value.ToString();
            habitacion.Tipo_Habitacion = DtgDatos.Rows[fila].Cells[1].Value.ToString();
            habitacion.Descripcion = DtgDatos.Rows[fila].Cells[2].Value.ToString();
            habitacion.Capacidad = int.Parse(DtgDatos.Rows[fila].Cells[3].Value.ToString());
            habitacion.Piso = int.Parse(DtgDatos.Rows[fila].Cells[4].Value.ToString());
            habitacion.Costo_Noche = double.Parse(DtgDatos.Rows[fila].Cells[8].Value.ToString());

            var permiso = FrmHome._usuarioActivo.ListaPermisos.Find(x => x.Id_Modulo == 2);

            // Columnas 5, 6, 7 son acciones de escritura
            if (columna >= 5 && columna <= 7)
            {
                if (permiso == null || !permiso.permiso_escritura)
                {
                    MessageBox.Show("No tienes permiso de escritura en este módulo.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string estado = DtgDatos.Rows[fila].Cells["ESTADO"].Value.ToString();
            switch (columna)
            {
                case 5:
                    {
                        if (estado == "Disponible")
                        {
                            new FrmReservas().ShowDialog();
                            DtgDatos.Columns.Clear();
                        }
                        else
                        {
                            if (estado == "Ocupada")
                            {
                                new FrmReservas().ShowDialog();
                                DtgDatos.Columns.Clear();
                            }
                            else
                            {
                                MessageBox.Show(
                                    $"La habitación está en estado '{estado}' y no puede reservarse.",
                                    "No disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }; break;
                case 6:
                    {
                        if (estado == "Ocupada")
                        {
                            new FrmCheckIn().ShowDialog();
                            DtgDatos.Columns.Clear();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Solo se puede hacer Check-In a habitaciones con reserva activa como Ocupada.",
                                "No disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }; break;
                case 7:
                    {
                        
                    }; break;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmHabitaciones.habitacionSeleccionada = null; // 🔥 LIMPIAR
            FrmHabitaciones.habitacion = new Habitaciones();

            new FrmDatosHabitacion().ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DtgDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una habitación primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string numero = DtgDatos.SelectedRows[0].Cells[0].Value.ToString();

            FrmHabitaciones.habitacionSeleccionada = mh.ObtenerHabitacion(numero);

            new FrmDatosHabitacion().ShowDialog();

            DtgDatos.Columns.Clear();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DtgDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una habitación primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string numero = DtgDatos.SelectedRows[0].Cells["NO"].Value.ToString();
            string estado = DtgDatos.SelectedRows[0].Cells["ESTADO"].Value.ToString();

            // 🔥 VALIDACIÓN
            if (estado != "Disponible")
            {
                MessageBox.Show(
                    $"No se puede eliminar la habitación porque está en estado '{estado}'.",
                    "Operación no permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            habitacion.Numero_Habitacion = numero;

            mh.Borrar(habitacion);

            DtgDatos.Columns.Clear();
        }

        private void FrmHabitaciones_Shown(object sender, EventArgs e)
        {
            var permiso = FrmHome._usuarioActivo.ListaPermisos.Find(x => x.Id_Modulo == 2);

            if (permiso == null || !permiso.permiso_leer_abrir)
            {
                MessageBox.Show("No tienes permiso para acceder a Habitaciones y Reservas.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            if (!permiso.permiso_escritura)
            {
                BtnAgregar.Enabled = false;
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
                // Los botones del DataGridView (RESERVAR, CHECK-IN, CHECK-OUT)
                // se controlan en CellClick
            }
        }

        public FrmHabitaciones()
        {
            InitializeComponent();
            mh = new ManejadorHabitaciones();
        }
    }
}
