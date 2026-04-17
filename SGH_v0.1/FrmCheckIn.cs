using Entidades;
using Manejadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGH_v0._1
{
    public partial class FrmCheckIn : Form
    {
        ManejadorReservas mr = new ManejadorReservas();
        Reservas datos;
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
            string numero = FrmHabitaciones.habitacion.Numero_Habitacion;
            datos = mr.ObtenerCheckIn(numero);

            if(datos == null)
            {
                MessageBox.Show("No hay reserva pendiente para esta habitacion.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            //Habitacion
            txtNo.Text = datos.Numero_Habitacion;
            txtTipo.Text = datos.Tipo_Habitacion;
            txtCapacidad.Text = datos.Capacidad.ToString();
            txtPiso.Text = datos.Piso.ToString();
            txtDescripcion.Text = datos.Descripcion;
            //Huesped
            txtNombre.Text = datos.Nombre;
            txtApellidos.Text = datos.Apellidos;
            txtTelefono.Text = datos.Telefono;
            txtEmail.Text = datos.Correo;
            //Costos
            txtCosto.Text = datos.CostoTotal.ToString("F2");
            txtDias.Text = datos.Dias.ToString();
            txtAnticipo.Text = datos.Anticipo.ToString("F2");
            txtRestante.Text = datos.Restante.ToString("F2");
            //Pagar se pre-rellena con el restante
            txtPagar.Text = datos.Restante.ToString("F2");
        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPagar.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (monto < datos.Restante)
            {
                MessageBox.Show(
                    $"El monto ingresado (${monto:F2}) no cubre el total restante (${datos.Restante:F2}).\n" +
                    "Debe pagar el total para completar el Check-In.",
                    "Monto insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultado = mr.RegistrarCheckIn(datos.Id_Reserva, monto);

            if (resultado == "OK")
            {
                MessageBox.Show("Pago registrado. Check-In completado.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
