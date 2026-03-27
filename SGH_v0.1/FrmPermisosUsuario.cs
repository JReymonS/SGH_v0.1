using Entidades;
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
    public partial class FrmPermisosUsuario : Form
    {
        ManejadorPermisos mp;
        public static Permisos usuario_permiso = new Permisos(0,0,0,false,false);
        string nombreModulo = "";
        public FrmPermisosUsuario()
        {
            InitializeComponent();
            mp=new ManejadorPermisos();
            mp.Mostrar($"SELECT * FROM v_UsuariosPermisos WHERE Id_Usuario='{FrmUsuarios.usuario.Id_Usuario}'", dtgDatos, "v_UsuariosPermisos");
            cmbModulos.SelectedIndex = 0;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (usuario_permiso.Id_Usuario == 0) 
            {
                usuario_permiso.Id_Usuario = FrmUsuarios.usuario.Id_Usuario;
                usuario_permiso.Id_Modulo =  mp.IndicesModulos(cmbModulos.SelectedItem.ToString());
                MessageBox.Show(usuario_permiso.Id_Modulo.ToString());
                usuario_permiso.Id_Usuario = 0;
            }
        }


        //Borrar un permiso seleccionado
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (usuario_permiso.Id_Permiso != 0)
            {
                mp.EliminarPermisos(usuario_permiso, nombreModulo);
                dtgDatos.Columns.Clear();
                mp.Mostrar($"SELECT * FROM v_UsuariosPermisos WHERE Id_Usuario='{FrmUsuarios.usuario.Id_Usuario}'", dtgDatos, "v_UsuariosPermisos");
                usuario_permiso.Id_Permiso = 0;

            }
            else { MessageBox.Show("Seleccione primero un registro.", "¡Informacion!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }


        //Cancelar gestion de permisos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Obtener datos de registros
        private void dtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dtgDatos.CurrentCell == null) return;
            int indice = dtgDatos.CurrentRow.Index;
            usuario_permiso.Id_Permiso = int.Parse(dtgDatos.Rows[indice].Cells["Id_Permiso"].Value.ToString());
            usuario_permiso.Id_Usuario = int.Parse(dtgDatos.Rows[indice].Cells["Id_Usuario"].Value.ToString());
            usuario_permiso.Id_Modulo = int.Parse(dtgDatos.Rows[indice].Cells["Id_Modulo"].Value.ToString());
            usuario_permiso.permiso_escritura = bool.Parse(dtgDatos.Rows[indice].Cells["ESCRITURA"].Value.ToString());
            usuario_permiso.permiso_leer_abrir = bool.Parse(dtgDatos.Rows[indice].Cells["LECTURA"].Value.ToString());
            nombreModulo = dtgDatos.Rows[indice].Cells["MODULO"].Value.ToString();
        }
    }
}
