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
    public partial class Login : Form
    {
        ManejadoLogin ml;


        public Login()
        {
            InitializeComponent();
            ml = new ManejadoLogin();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            var rs = ml.ValidarLogin(usuario, contrasena);

            if (rs.Acceso) 
            {
                Home frmHome = new Home();
                frmHome.Show();
            }
        }
    }
}
