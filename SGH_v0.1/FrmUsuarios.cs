using Entidades;
using Manejadores;
using System;
using System.Windows.Forms;

namespace SGH_v0._1
{
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu;
        public static Usuarios usuario = new Usuarios(0, "", "", "", false, "");

        public FrmUsuarios()
        {
            InitializeComponent();
            mu=new ManejadorUsuarios();
        }


        //Buscar usuario
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mu.Mostrar($"SELECT * FROM v_Usuarios WHERE NOMBRE like '%{txtBuscar.Text.Trim('\'')}%'", dtgDatos, "v_Usuarios");
        }


        //Agregar un nuevo usuario
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            usuario.Id_Usuario = 0;
            usuario.Nombre = "";
            usuario.Contrasena = "";
            usuario.Rol = "";
            usuario.Estatus = false;
            usuario.FechaRegistro = "";
            FrmDatosUsuario frmDatosUsuario = new FrmDatosUsuario();
            this.Hide();
            frmDatosUsuario.ShowDialog();
            this.Show();
            dtgDatos.Columns.Clear();
        }


        //Agregar o cambiar permisos de usuario
        private void btnPermisos_Click(object sender, EventArgs e)
        {
            if(usuario.Id_Usuario != 0) 
            {
                FrmPermisosUsuario frmPermisosUsuario = new FrmPermisosUsuario();
                this.Hide();
                frmPermisosUsuario.ShowDialog();
                this.Show();
                dtgDatos.Columns.Clear();
                usuario.Id_Usuario = 0;
            }
            else { MessageBox.Show("Seleccione primero un registro.", "¡Informacion!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }


        //Editar un usuario existente
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(usuario.Id_Usuario != 0) 
            {
                FrmDatosUsuario frmDatosUsuario = new FrmDatosUsuario();
                this.Hide();
                frmDatosUsuario.ShowDialog();
                this.Show();
                dtgDatos.Columns.Clear();
                usuario.Id_Usuario = 0;
            }
            else { MessageBox.Show("Seleccione primero un registro.","¡Informacion!",MessageBoxButtons.OK,MessageBoxIcon.Information); }
        }


        //Borrar un usuario
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(usuario.Id_Usuario != 0) 
            {
                mu.Borrar(usuario);
                dtgDatos.Columns.Clear();
                usuario.Id_Usuario = 0;
            }
            else { MessageBox.Show("Seleccione primero un registro.", "¡Informacion!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }


        //Evento para obtener datos
        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex < 0 || dtgDatos.CurrentCell==null) return;
            int indice = dtgDatos.CurrentRow.Index;
            usuario.Id_Usuario = int.Parse(dtgDatos.Rows[indice].Cells["Id_Usuario"].Value.ToString());
            usuario.Nombre = dtgDatos.Rows[indice].Cells["NOMBRE"].Value.ToString();
            usuario.Contrasena = dtgDatos.Rows[indice].Cells["CONTRASEÑA"].Value.ToString(); 
            usuario.Rol = dtgDatos.Rows[indice].Cells["ROL"].Value.ToString();
        }


        //Evento para carga configuracion de interfaz
        private void FrmUsuarios_Shown(object sender, EventArgs e)
        {
            var rs = FrmHome._usuarioActivo.ListaPermisos.Find(x => x.Id_Modulo == 1);
            btnAgregar.Enabled = rs.permiso_escritura;
            btnEditar.Enabled = rs.permiso_escritura;
            btnBorrar.Enabled = rs.permiso_escritura;
        }
    }
}
