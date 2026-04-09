using Manejadores;
using Entidades;
using System;
using System.Windows.Forms;

namespace SGH_v0._1
{
    public partial class FrmDatosUsuario : Form
    {
        ManejadorUsuarios mu;
        public FrmDatosUsuario()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            if (FrmUsuarios.usuario.Id_Usuario > 0) 
            {
                txtNombre.Text = FrmUsuarios.usuario.Nombre;
                txtRol.Text = FrmUsuarios.usuario.Rol;
            }
        }


        //Guardar nvos registros o modificaciones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(FrmUsuarios.usuario.Id_Usuario == 0) 
            {
                mu.ValidarCampos(txtNombre, txtContrasena, txtRol, true); //Nvo Registro
                if (!mu.valido) { return; }
                else
                {
                    mu.Guardar(new Usuarios(0, txtNombre.Text, txtContrasena.Text, txtRol.Text, false, ""));
                    if(!mu.valido ) { return; }
                    Close();
                }
            }
            else 
            {
                if(txtContrasena.Text == "") 
                {
                    mu.ValidarCampos(txtNombre, txtContrasena, txtRol, false);
                    if (!mu.valido) { return; }
                    else 
                    {
                        mu.Modificar(new Usuarios(FrmUsuarios.usuario.Id_Usuario, txtNombre.Text,txtContrasena.Text,txtRol.Text,false,""), false);
                        if (!mu.valido) { return; }
                        Close();
                    }
                }
                else 
                {
                    mu.ValidarCampos(txtNombre, txtContrasena, txtRol, true);
                    if (!mu.valido) { return; }
                    else 
                    {
                        mu.Modificar(new Usuarios(FrmUsuarios.usuario.Id_Usuario, txtNombre.Text, txtContrasena.Text, txtRol.Text, false, ""), true);
                        if (!mu.valido) { return; }
                        Close();
                    }
                }
            }
        }


        //Cerrar formulario de datos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
