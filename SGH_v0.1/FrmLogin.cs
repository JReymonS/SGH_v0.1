using Manejadores;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SGH_v0._1
{
    public partial class FrmLogin : Form
    {
        
        ManejadoLogin ml;
        int intentosFallidos = 0;
        bool visualizarContrasena=false;


        public FrmLogin()
        {
            InitializeComponent();
            ml = new ManejadoLogin();
        }


        //Evento para acceder al formulario
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            var rs = ml.ValidarLogin(usuario, contrasena);


            if (rs.Acceso) 
            {
                FrmHome frmHome = new FrmHome(rs.UsuarioAcceso);
                frmHome.Show();
                this.Hide();
            }
            else 
            {
                
                if (intentosFallidos >= 3) 
                {
                    MessageBox.Show("Ha excedido el número maximo de intentos.\n\nSe activo el bloqueo por 3 segundos.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Enabled = false;
                    txtContrasena.Enabled = false;
                    btnVisibilidad.Enabled = false;
                    btnAcceder.Enabled = false;
                    Thread.Sleep(3000);

                    MessageBox.Show("Se desactivó el bloqueo temporal, puede intentar nuevamente.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Enabled = true;
                    txtContrasena.Enabled = true;
                    btnVisibilidad.Enabled = true;
                    btnAcceder.Enabled = true;
                    intentosFallidos = 0;
                    ml.LimpiarCampos(txtUsuario, txtContrasena);
                }
                else 
                {
                    MessageBox.Show(rs.Mensaje, "¡ERROR DE AUTENTICACIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ml.LimpiarCampos(txtUsuario,txtContrasena);
                    intentosFallidos++;
                }
            }
        }


        private void btnVisibilidad_Click(object sender, EventArgs e)
        {
            visualizarContrasena = !visualizarContrasena;
            ml.VisualizaContrasena(txtContrasena, visualizarContrasena);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
