using AccesoDatos;
using Entidades;
using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadoLogin
    {
        Base b = new Base("localhost", "root", "2026", "SistemaGestionHotelera");


        //Validacion de Login
        public (bool Acceso, string Mensaje, Usuarios UsuarioAcceso) ValidarLogin (string Usuario, string Contrasena)
        {
             if(string.IsNullOrEmpty(Usuario) || string.IsNullOrEmpty(Contrasena) || Usuario == " Ingrese su usuario..." || Contrasena == " Ingrese su contraseña...") 
            {
                return (false, "Por favor complete todos los campos.", null);
            }

            if (Usuario.ToString().Length > 255 || Contrasena.ToString().Length > 255) 
            {
                return (false, "Solo se admite un maximo de 255 caracteres en cada campo.", null);
            }


            DataSet ds = b.Consulta($"SELECT * FROM v_UsuariosLogin WHERE BINARY Nombre='{Usuario}' AND Contrasena ='{Sha1(Contrasena)}'", "v_UsuariosLogin");
            if (ds.Tables.Count>0 && ds.Tables[0].Rows.Count >= 1) 
            {
                DataTable dt = ds.Tables[0];
                Usuarios user = new Usuarios(0, "", "", "", false, "");

                foreach (DataRow row in dt.Rows) 
                {
                    if(user.Id_Usuario == 0) 
                    {
                        user.Id_Usuario = Convert.ToInt32(row["Id_Usuario"]);
                        user.Nombre = Convert.ToString(row["Nombre"]);
                    }

                    Permisos Permiso = new Permisos
                    ( 
                        Convert.ToInt32(row["Id_Permiso"]),
                        Convert.ToInt32(row["Id_Usuario"]),
                        Convert.ToInt32(row["Id_Modulo"]),
                        Convert.ToBoolean(row["permiso_leer_abrir"]),
                        Convert.ToBoolean(row["permiso_escritura"])
                    );
                    user.ListaPermisos.Add(Permiso);
                }
                return (true, "Acceso concedido.", user);
            }
            else 
            {
                return (false, "Usuario y/o contraseña incorrectos.", null);
            }

        }


        //Ocultar o mostrar contraseña
        public void VisualizaContrasena(TextBox contrasena, bool mostrar) 
        {
            if (!contrasena.Text.Equals(" Ingrese su contraseña..."))
            {
                contrasena.PasswordChar = (mostrar) ? '\0' : '*';
            }
        }

        //Limpiar campos
        public void LimpiarCampos(TextBox usuario, TextBox contrasena, Button visibilidad) 
        {
            contrasena.ForeColor = System.Drawing.Color.Gray;
            usuario.ForeColor = System.Drawing.Color.Gray;
            usuario.Clear(); contrasena.Clear(); 
            usuario.Text=" Ingrese su usuario..."; contrasena.Text=" Ingrese su contraseña..."; contrasena.PasswordChar = '\0';
            visibilidad.Visible = false;
        }


        //Reiniciar el icono de visibilidad de contraseña
        public void ReinicioEstadoVisibilidad(Button btnVisibilidad, Bitmap Imagen) 
        {
            btnVisibilidad.FlatStyle = FlatStyle.Flat;
            btnVisibilidad.FlatAppearance.BorderSize = 0;
            btnVisibilidad.BackgroundImage = Imagen;
        }


        public static string Sha1(string texto) 
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();

            foreach (byte i in hash) 
            {
                cadena.AppendFormat("{0:x2}",i);
            }
            return cadena.ToString();
        }
    }
}
