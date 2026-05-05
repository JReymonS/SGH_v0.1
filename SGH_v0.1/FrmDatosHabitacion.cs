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
    public partial class FrmDatosHabitacion : Form
    {
        ManejadorHabitaciones mh;

        public FrmDatosHabitacion()
        {
            InitializeComponent();
            mh = new ManejadorHabitaciones();
            var h = FrmHabitaciones.habitacionSeleccionada;

            if (h != null && !string.IsNullOrEmpty(h.Numero_Habitacion))
            {
                TxtNo.Text = h.Numero_Habitacion;
                TxtTipo.Text = h.Tipo_Habitacion;
                TxtCapacidad.Text = h.Capacidad.ToString();
                TxtPiso.Text = h.Piso.ToString();
                TxtCosto.Text = h.Costo_Noche.ToString();
                TxtDescripcion.Text = h.Descripcion;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // === VALIDACIONES ===

            if (string.IsNullOrWhiteSpace(TxtNo.Text))
            {
                MessageBox.Show("El número de habitación no puede quedar vacío.");
                TxtNo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtTipo.Text))
            {
                MessageBox.Show("El tipo de habitación no puede quedar vacío.");
                TxtTipo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtCapacidad.Text))
            {
                MessageBox.Show("La capacidad no puede quedar vacía.");
                TxtCapacidad.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtPiso.Text))
            {
                MessageBox.Show("El piso no puede quedar vacío.");
                TxtPiso.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtCosto.Text))
            {
                MessageBox.Show("El costo por noche no puede quedar vacío.");
                TxtCosto.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                MessageBox.Show("La descripción de habitación no puede quedar vacía.");
                TxtDescripcion.Focus();
                return;
            }

            // === VALIDACIONES DE LONGITUD (SEGÚN BD) ===

            if (TxtNo.Text.Length > 5)
            {
                MessageBox.Show("El número de habitación no puede exceder 5 caracteres.");
                TxtNo.Focus();
                return;
            }

            if (TxtTipo.Text.Length > 255)
            {
                MessageBox.Show("El tipo de habitación no puede exceder 255 caracteres.");
                TxtTipo.Focus();
                return;
            }

            if (TxtDescripcion.Text.Length > 255)
            {
                MessageBox.Show("La descripción no puede exceder 255 caracteres.");
                TxtDescripcion.Focus();
                return;
            }

            // === VALIDACIONES NUMÉRICAS ===

            int capacidad;
            if (!int.TryParse(TxtCapacidad.Text, out capacidad) || capacidad <= 0)
            {
                MessageBox.Show("La capacidad debe ser un número entero mayor que 0.");
                TxtCapacidad.Focus();
                return;
            }

            int piso;
            if (!int.TryParse(TxtPiso.Text, out piso) || piso <= 0)
            {
                MessageBox.Show("El piso debe ser un número entero mayor que 0.");
                TxtPiso.Focus();
                return;
            }

            decimal costo;
            if (!decimal.TryParse(TxtCosto.Text, out costo) || costo <= 0)
            {
                MessageBox.Show("El costo por noche debe ser un número válido mayor que 0.");
                TxtCosto.Focus();
                return;
            }

            // DECIMAL(8,2) → máximo 999999.99
            if (costo > 999999.99m)
            {
                MessageBox.Show("El costo excede el límite permitido. Máximo: 999999.99");
                TxtCosto.Focus();
                return;
            }

            // === VALIDACIÓN DE EXISTENCIA ===

            if (FrmHabitaciones.habitacion == null) // AGREGAR
            {
                if (mh.ExisteHabitacion(TxtNo.Text.Trim()))
                {
                    MessageBox.Show("El número de habitación ya existe.");
                    TxtNo.Focus();
                    return;
                }
            }
            else // EDITAR
            {
                if (TxtNo.Text.Trim() != FrmHabitaciones.habitacion.Numero_Habitacion)
                {
                    if (mh.ExisteHabitacion(TxtNo.Text.Trim()))
                    {
                        MessageBox.Show("El número de habitación ya existe.");
                        TxtNo.Focus();
                        return;
                    }
                }
            }

            // === GUARDADO ===

            Habitaciones h = new Habitaciones();
            h.Numero_Habitacion = TxtNo.Text;
            h.Tipo_Habitacion = TxtTipo.Text;
            h.Capacidad = capacidad;
            h.Piso = piso;
            h.Costo_Noche = (double)costo;
            h.Descripcion = TxtDescripcion.Text;

            if (FrmHabitaciones.habitacionSeleccionada == null)
            {
                mh.Guardar(h);
            }
            else
            {
                mh.Modificar(h, FrmHabitaciones.habitacionSeleccionada.Numero_Habitacion);
            }

            this.Close();
        }
    }
}
