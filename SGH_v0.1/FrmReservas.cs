using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace SGH_v0._1
{
    public partial class FrmReservas : Form
    {
        ManejadorReservas mr = new ManejadorReservas();
        Habitaciones ha = FrmHabitaciones.habitacion;
        Reservas reservaActual = null;
        public FrmReservas()
        {
            InitializeComponent();
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            txtNo.Text = ha.Numero_Habitacion;
            txtTipo.Text = ha.Tipo_Habitacion;
            txtCapacidad.Text = ha.Capacidad.ToString();
            txtPiso.Text = ha.Piso.ToString();
            txtCosto.Text = ha.Costo_Noche.ToString("F2");
            txtDescripcion.Text = ha.Descripcion;

            reservaActual = mr.ObtenerReservaPorHabitacion(ha.Numero_Habitacion);

            if (reservaActual != null)
                CargarModoVer();
            else
                CargarModoCrear();
        }
        private void DtpFecha_ValueChanged(object sender, EventArgs e) => RecalcularCosto();
        private void RecalcularCosto() 
        {
            int dias = (dtpFechaFinal.Value.Date - dtpFechaInicial.Value.Date).Days;

            if (dias < 1)
            {
                txtDias.Text = "0";
                txtCostoCal.Text = "0.00";
                return;
            }

            txtDias.Text  = dias.ToString();
            txtCostoCal.Text = (ha.Costo_Noche * dias).ToString("F2");
        }

        private void TxtRFC_Leave(object sender, EventArgs e)
        {
            if (txtRFC.Text.Trim().Length == 0) return;
            Reservas huesped = mr.ObtenerHuesped(txtRFC.Text.Trim());
            if (huesped != null)
            {
                txtNombre.Text = huesped.Nombre;
                txtApellidos.Text = huesped.Apellidos;
                txtTelefono.Text = huesped.Telefono;
                txtEmail.Text = huesped.Correo;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            mr.GuardarHuesped(
                txtRFC.Text.Trim(),
                txtNombre.Text.Trim(),
                txtApellidos.Text.Trim(),
                txtEmail.Text.Trim(),
                txtTelefono.Text.Trim());

            decimal anticipo = 0;
            decimal.TryParse(txtAnticipo.Text, out anticipo);

            // Id_Usuario: ajusta según cómo manejes la sesión en tu proyecto
            int idUsuario = 1; // reemplaza con el ID del usuario logueado

            string resultado = mr.Crear(
                ha.Numero_Habitacion,
                dtpFechaInicial.Value,
                dtpFechaFinal.Value,
                anticipo,
                txtRFC.Text.Trim(),
                idUsuario);

            if (resultado == "OK")
            {
                MessageBox.Show("Reserva creada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(resultado, "Error al reservar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            var conf = MessageBox.Show(
            $"¿Desea cancelar la reserva de {reservaActual.Nombre} {reservaActual.Apellidos}?",
            "Confirmar cancelación",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (conf != DialogResult.Yes) return;

            string resultado = mr.CancelarReserva(reservaActual.Id_Reserva);

            if (resultado == "OK")
            {
                MessageBox.Show("Reserva cancelada correctamente.", "Listo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(resultado, "No se pudo cancelar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool Validar()
        {
            if (txtRFC.Text.Trim().Length == 0 ||
                txtNombre.Text.Trim().Length == 0 ||
                txtApellidos.Text.Trim().Length == 0)
            {
                MessageBox.Show("Complete los datos del huésped.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpFechaFinal.Value.Date <= dtpFechaInicial.Value.Date)
            {
                MessageBox.Show("La fecha de salida debe ser posterior a la de entrada.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void CargarModoCrear()
        {
            dtpFechaInicial.Value = DateTime.Today;
            dtpFechaFinal.Value = DateTime.Today.AddDays(1);
            txtAnticipo.Text = "0";

            txtRFC.Enabled = true;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            dtpFechaInicial.Enabled = true;
            dtpFechaFinal.Enabled = true;
            txtAnticipo.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelarReserva.Enabled = false;

            RecalcularCosto();
        }

        private void CargarModoVer()
        {
            txtRFC.Text = reservaActual.RFC;
            txtNombre.Text = reservaActual.Nombre;
            txtApellidos.Text = reservaActual.Apellidos;
            txtTelefono.Text = reservaActual.Telefono;
            txtEmail.Text = reservaActual.Correo;

            dtpFechaInicial.Value = reservaActual.Fecha_Entrada;
            dtpFechaFinal.Value = reservaActual.Fecha_Salida;
            txtAnticipo.Text = reservaActual.Anticipo.ToString("F2");

            txtRFC.Enabled = false;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            dtpFechaInicial.Enabled = false;
            dtpFechaFinal.Enabled = false;
            txtAnticipo.Enabled = false;

            btnGuardar.Enabled = false; 
            btnCancelarReserva.Enabled = true;  

            RecalcularCosto();
        }
    }
}
