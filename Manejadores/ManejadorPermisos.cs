using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorPermisos
    {
        Base b = new Base("localhost", "root", "2026", "SistemaGestionHotelera");

        //Guardar nvos permisos
        public void GuardarPermisos(Permisos permiso) 
        {
            var rs = b.Consulta($"CALL p_GuardarPermiso({permiso.Id_Usuario},{permiso.Id_Modulo},{permiso.permiso_leer_abrir},{permiso.permiso_escritura})", "msg");
            string mensaje = rs.Tables[0].Rows[0]["msg"].ToString();
            if (!mensaje.Equals("Ok")) { MessageBox.Show(mensaje, "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        //Eliminar permisos
        public void EliminarPermisos(Permisos permisos, string modulo) 
        {
            var rs = MessageBox.Show($"¿Esta seguro de eliminar el permiso para: {modulo}?","¡Atención!",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                var rs1 = b.Consulta($"CALL p_EliminarPermiso({permisos.Id_Permiso},{permisos.Id_Usuario},{permisos.Id_Modulo})", "msg");
                string mensaje = rs1.Tables[0].Rows[0]["msg"].ToString();
                if (!mensaje.Equals("Ok")){MessageBox.Show(mensaje, "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }


        //Obtener indices de modulos
        public int IndicesModulos(string modulo) 
        {
            int rs = 0;
            switch (modulo) 
            {
                case "Usuarios": rs = 1;  break;
                case "Habitaciones y Reserva": rs = 2; break;
                case "Housekeeping": rs = 3; break;
                case "Cargos": rs=4; break;
                case "Reportes": rs=5; break;
            }
            return rs;
        }


        //Validar permisos en checklist
        public bool ValidarPermisos(CheckBox leer, CheckBox escribir) 
        {
            bool rs = false;
            if(!leer.Checked && !escribir.Checked) 
            {
                rs = false;
                MessageBox.Show("Debe seleccionar al menos un permiso para poder agregarlo.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { rs = true; }
            return rs;
        }


        //Mostrar permisos asignados
        public void Mostrar (string consulta, DataGridView tabla, string datos) 
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consulta(consulta, datos).Tables[datos];
            tabla.Columns["Id_Usuario"].Visible = false;
            tabla.Columns["Id_Permiso"].Visible = false;
            tabla.Columns["Id_Modulo"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeColumns();
        }
    }
}
