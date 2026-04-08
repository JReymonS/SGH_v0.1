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
            Habitaciones h = new Habitaciones();
            h.Numero_Habitacion = TxtNo.Text;
            h.Tipo_Habitacion = TxtTipo.Text;
            h.Capacidad = int.Parse(TxtCapacidad.Text);
            h.Piso = int.Parse(TxtPiso.Text);
            h.Costo_Noche = double.Parse(TxtCosto.Text);
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
