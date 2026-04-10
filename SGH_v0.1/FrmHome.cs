using Entidades;
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
    public partial class FrmHome : Form
    {
        public static Usuarios _usuarioActivo;

        public FrmHome(Usuarios user)
        {
            InitializeComponent();
            _usuarioActivo=user;
        }


        //Cargar permisos de acceso.
        private void FrmHome_Load(object sender, EventArgs e)
        {
            lblUsuarioActivo.Text = $" {_usuarioActivo.Nombre} ";
            tsbHabitacionReserva.Enabled = false;
            tsbHousekeeping.Enabled = false;
            tsbCargos.Enabled = false;
            tsbReportes.Enabled = false;
            tsbUsuarios.Enabled = false;

            foreach(var permiso in _usuarioActivo.ListaPermisos)
            {
                switch (permiso.Id_Modulo) 
                {
                    case 1: tsbUsuarios.Enabled = permiso.permiso_leer_abrir; break;
                    case 2: tsbHabitacionReserva.Enabled = permiso.permiso_leer_abrir; break;
                    case 3: tsbHousekeeping.Enabled = permiso.permiso_leer_abrir; break;
                    case 4: tsbCargos.Enabled = permiso.permiso_leer_abrir; break;
                    case 5: tsbReportes.Enabled = permiso.permiso_leer_abrir; break;
                }
            }
            
        }


        //Administrar habitaciones y reservas
        private void tsbHabitacionReserva_Click(object sender, EventArgs e)
        {
            FrmHabitaciones frmHabitaciones = new FrmHabitaciones();
            frmHabitaciones.MdiParent = this;
            frmHabitaciones.Show();
        }


        //Administrar housekeeping

        private void tsbHousekeeping_Click(object sender, EventArgs e)
        {
            FrmHousekeeping frmHousekeeping = new FrmHousekeeping();
            frmHousekeeping.MdiParent = this;
            frmHousekeeping.Show();
        }


        //Administrar cargos
        private void tsbCargos_Click(object sender, EventArgs e)
        {
            FrmCargos frmCargos = new FrmCargos();
            frmCargos.MdiParent = this;
            frmCargos.Show();

        }


        //Administrar reportes
        private void tsbReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frmReportes = new FrmReportes();
            frmReportes.MdiParent = this;
            frmReportes.Show();
        }


        //Administrar usuarios
        private void tsbUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }


        //Cerrar sesion
        private void tsbLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
