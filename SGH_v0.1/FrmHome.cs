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


        //Cerrar sesion
        private void tsbLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tsbHabitacionReserva_Click(object sender, EventArgs e)
        {
            FrmHabitaciones fh = new FrmHabitaciones();
            fh.ShowDialog();
        }
    }
}
