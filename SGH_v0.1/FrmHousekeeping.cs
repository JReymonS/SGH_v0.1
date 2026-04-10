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
    public partial class FrmHousekeeping : Form
    {
        public FrmHousekeeping()
        {
            InitializeComponent();
        }

        private void TxtBuscarHabitacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBuscarHabitacion_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarHabitacion.Text == "Buscar habitación...")
            {
                TxtBuscarHabitacion.Text = ""; // Borra el texto gris
                TxtBuscarHabitacion.ForeColor = Color.Black; // Cambia el color a negro para escribir
            }
        }

        private void TxtBuscarHabitacion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBuscarHabitacion.Text))
            {
                TxtBuscarHabitacion.Text = "Buscar habitación..."; // Pone el placeholder de nuevo
                TxtBuscarHabitacion.ForeColor = Color.Gray; // Lo vuelve a poner gris
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

        }
    }
}
