using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Manejadores;
using Entidades; 

namespace SGH_v0._1
{
    public partial class FrmDashboard : Form
    {
        ManejadorDashboard md;
        public FrmDashboard()
        {
            InitializeComponent();
            md = new ManejadorDashboard();

            // Mostrar la suma del estado de la habitacion
            var total = md.SumaDeEstado();
            LblDisponibles.Text = total.disponibles.ToString();
            LblOcupadas.Text = total.ocupadas.ToString();
            LblLimpieza.Text = total.limpieza.ToString();
        }


        // Método para redondear los bordes de los eleme
        private void Redondear(Control control, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(control.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(control.Width - radio, control.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, control.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            Redondear(panelHabitacionesDisponibles, 20);
            Redondear(panelHabitacionesOcupadas, 20);
            Redondear(panelHabitacionesLimpieza, 20);
            Redondear(panelHabitacionesMantenimiento, 20);

            Redondear(BtnNuevaReserva, 10);
            Redondear(BtnHouseKeeping, 10);
            Redondear(BtnReportes, 10);

            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNuevaReserva_Click(object sender, EventArgs e)
        {
            FrmReservas frmReservas = new FrmReservas();
            frmReservas.ShowDialog();
        }

        private void BtnHouseKeeping_Click(object sender, EventArgs e)
        {
            FrmHousekeeping frmHousek = new FrmHousekeeping();
            frmHousek.ShowDialog();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frmReportes = new FrmReportes();
            frmReportes.ShowDialog();
        }
    }
}
