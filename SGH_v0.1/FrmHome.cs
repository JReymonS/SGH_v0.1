using Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SGH_v0._1
{
    public partial class FrmHome : Form
    {
        public static Usuarios _usuarioActivo;
        private ToolStripButton botonActivo = null;

        public FrmHome(Usuarios user)
        {

            InitializeComponent();
            _usuarioActivo = user;
        }

        //Cargar permisos de acceso.
        private void FrmHome_Load(object sender, EventArgs e)
        {
            tsMenu.Renderer = new PintorSinBordes();
            lblUsuarioActivo.Text = $" {_usuarioActivo.Nombre} ";
            tsbHabitacionReserva.Enabled = false;
            tsbHousekeeping.Enabled = false;
            tsbCargos.Enabled = false;
            tsbReportes.Enabled = false;
            tsbUsuarios.Enabled = false;


            foreach (var permiso in FrmHome._usuarioActivo.ListaPermisos)
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

            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.FromArgb(189, 225, 232);
                    break; // Solo hay un MdiClient, así que se puede salir del bucle después de encontrarlo
                }
            }

            Boton(tsbHome);
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.MdiParent = this;
            frmDashboard.Show();
        }


        //Administrar habitaciones y reservas
        private void tsbHabitacionReserva_Click(object sender, EventArgs e)
        {
            Boton(sender);
            closeForms();
            FrmHabitaciones frmHabitaciones = new FrmHabitaciones();
            frmHabitaciones.MdiParent = this;
            frmHabitaciones.Show();
        }


        //Administrar housekeeping

        private void tsbHousekeeping_Click(object sender, EventArgs e)
        {
            Boton(sender);
            closeForms();
            FrmHousekeeping frmHousekeeping = new FrmHousekeeping();
            frmHousekeeping.MdiParent = this;
            frmHousekeeping.Show();
        }


        //Administrar cargos
        private void tsbCargos_Click(object sender, EventArgs e)
        {
            Boton(sender);
            closeForms();
            FrmCargos frmCargos = new FrmCargos();
            frmCargos.MdiParent = this;
            frmCargos.Show();

        }


        //Administrar reportes
        private void tsbReportes_Click(object sender, EventArgs e)
        {
            Boton(sender);
            closeForms();
            FrmReportes frmReportes = new FrmReportes();
            frmReportes.MdiParent = this;
            frmReportes.Show();
        }


        //Administrar usuarios
        private void tsbUsuarios_Click(object sender, EventArgs e)
        {
            Boton(sender);
            closeForms();
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }

        // Administrar dashboard
        private void tsbHome_Click(object sender, EventArgs e)
        {
            Boton(sender);
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.MdiParent = this;
            frmDashboard.Show();
        }

        //Cerrar sesion
        private void tsbLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BtnCompress_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        // Diseño
        private void Boton(object sender)
        {
            Color color = Color.FromArgb(0, 180, 216); // Color para el botón activo
            Color backgroundColor = Color.FromArgb(0, 119, 182); // Color para el fondo

            foreach (ToolStripItem item in tsMenu.Items)
            {
                if (item is ToolStripButton btn)
                {
                    //btn.BackColor = backgroundColor;
                    btn.BackColor = Color.Transparent;
                }
            }

            if (sender is ToolStripButton clic)
            {
                clic.BackColor = color;
                botonActivo = clic;
            }
        }

        private void efectoHover_MouseEnter(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton;

            tsMenu.Cursor = Cursors.Hand;

            if (btn != null && btn != botonActivo)
            {
                btn.BackColor = Color.FromArgb(0, 119, 182);
            }
        }

        private void efectoHover_MouseLeave(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton;

            tsMenu.Cursor = Cursors.Default;

            if (btn != null && btn != botonActivo)
            {
                btn.BackColor = Color.Transparent;
            }

        }

        public class ColoresLimpios : ProfessionalColorTable
        {
            // Vuelve invisible el cuadro blanco de "Hover"
            public override Color ButtonSelectedHighlight => Color.Transparent;
            public override Color ButtonSelectedHighlightBorder => Color.Transparent;

            // Vuelve invisible el cuadro blanco al hacer "Clic"
            public override Color ButtonPressedHighlight => Color.Transparent;
            public override Color ButtonPressedBorder => Color.Transparent;

            // Vuelve invisible el fondo cuando un botón está "Checked"
            public override Color ButtonCheckedHighlight => Color.Transparent;
            public override Color ButtonCheckedHighlightBorder => Color.Transparent;

            // Vuelve invisible la línea divisoria del menú
            public override Color ToolStripBorder => Color.Transparent;
        }

        public class PintorSinBordes : ToolStripProfessionalRenderer
        {
            public PintorSinBordes() : base(new ColoresLimpios()) { }

            // Aquí interceptamos el dibujo del borde
            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
            
            }
        }
    }
}
