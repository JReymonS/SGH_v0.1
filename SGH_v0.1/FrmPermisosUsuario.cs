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
        public FrmPermisosUsuario()
        {
            InitializeComponent();
            mp=new ManejadorPermisos();
            mp.Mostrar($"SELECT * FROM v_UsuariosPermisos WHERE Id_Usuario='{FrmUsuarios.usuario.Id_Usuario}'", dtgDatos, "v_UsuariosPermisos");
            cmbModulos.SelectedIndex = 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
