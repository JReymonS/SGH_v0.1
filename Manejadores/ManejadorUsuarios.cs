using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorUsuarios
    {
        Base b = new Base("localhost", "root", "2026", "SistemaGestionHotelera");
        public bool valido = true;

        //Guardar usuarios
        public void Guardar(Usuarios usuario)
        {
            valido = true;
            var rs = b.Consulta($"CALL p_InsertarUsuario('{usuario.Nombre}','{ManejadoLogin.Sha1(usuario.Contrasena)}','{usuario.Rol}')","msg");
            string mensaje = rs.Tables["msg"].Rows[0]["msg"].ToString();

            if (!mensaje.Equals("Ok"))
            { 
                valido=false;
                MessageBox.Show(mensaje,"¡Atención!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        //Modificar usuarios
        public void Modificar(Usuarios usuario, bool pContrasena) 
        {
            valido = true;
            string mensaje = "";
            if (pContrasena)
            {
                var rs = b.Consulta($"CALL p_ModificarUsuario({usuario.Id_Usuario},'{usuario.Nombre}','{ManejadoLogin.Sha1(usuario.Contrasena)}','{usuario.Rol}',1)", "msg");
                mensaje = rs.Tables[0].Rows[0]["msg"].ToString();
                if (!mensaje.Equals("Ok"))
                {
                    valido = false;
                    MessageBox.Show(mensaje, "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                var rs = b.Consulta($"CALL p_ModificarUsuario({usuario.Id_Usuario},'{usuario.Nombre}','{usuario.Contrasena}','{usuario.Rol}',0)", "msg");
                mensaje = rs.Tables[0].Rows[0]["msg"].ToString();
                if (!mensaje.Equals("Ok"))
                {
                    valido = false;
                    MessageBox.Show(mensaje, "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Borrar usuarios
        public void Borrar(Usuarios usuario) 
        {
            var rs = MessageBox.Show($"¿Esta seguro de eliminar al usuario {usuario.Nombre} de la lista?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) { b.Comando($"CALL p_DesactivarUsuario({usuario.Id_Usuario})"); }
        }


        //Mostrar usuarios
        public void Mostrar(string consulta, DataGridView tabla, string datos) 
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consulta(consulta, datos).Tables[datos];
            tabla.Columns["Id_Usuario"].Visible=false;
            tabla.Columns["FechaRegistro"].Visible = false;
            tabla.Columns["Estatus"].Visible= false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }


        //Validar los campos del formulario
        public void ValidarCampos(TextBox txtNombre, TextBox txtContrasena, TextBox txtRol, bool pContrasena) 
        {
            valido = true;
            if(string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtRol.Text)) 
            {
                MessageBox.Show("Ingrese todos los campos porfavor.", "¡Datos incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
                return;
            }
            if (txtNombre.Text.Length > 255) 
            {
                MessageBox.Show("Ha excedido el maximo de caracteres para el nombre.\r\nIngrese uno valido (max 255).", "¡Campo excedido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Clear();
                valido = false;
                return;
            }
            if (txtContrasena.Text.Length > 255)
            {
                MessageBox.Show("Ha excedido el maximo de caracteres para la contraseña.\r\nIngrese una valida (max 255).", "¡Campo excedido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Clear();
                valido = false;
                return;
            }
            if (txtRol.Text.Length > 255)
            {
                MessageBox.Show("Ha excedido el maximo de caracteres para el rol.\r\nIngrese uno valido (max 255).", "¡Campo excedido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRol.Clear();
                valido = false;
                return;
            }
            if(pContrasena && string.IsNullOrWhiteSpace(txtContrasena.Text)) 
            {
                MessageBox.Show("Se requiere de una contraseña para el nuevo usuario.", "¡Datos incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido=false;
                return;
            }
        }






    }
}
