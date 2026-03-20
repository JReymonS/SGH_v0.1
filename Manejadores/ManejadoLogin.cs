using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Manejadores
{
    public class ManejadoLogin
    {
        Base b = new Base("localhost", "root", "2026", "SistemaGestionHotelera");

        public (bool Acceso, string Mensaje, Usuarios UsuarioAcceso, Permisos Permisos) ValidarLogin (string Usuario, string Contrasena)
        {
            DataSet ds = b.Consulta($"SELECT * FROM v_UsuariosLogin WHERE BINARY Nombre like '%{Usuario}%' AND Contrasena like '%{Sha1(Contrasena)}%'", "v_UsuariosLogin");
            if (ds.Tables.Count>0 && ds.Tables[0].Rows.Count >= 1) 
            {
                DataTable dt = ds.Tables[0];
                Usuarios user = new Usuarios(0, "", "", "", false, "");
                Permisos permiso = new Permisos(0,0,0,false,false);

                foreach (DataRow row in dt.Rows) 
                {
                    if(user.Id_Usuario == 0) 
                    {
                        user.Id_Usuario = Convert.ToInt32(row["Id_Usuario"]);
                        user.Nombre = Convert.ToString(row["Nombre"]);
                    }

                    if(permiso.Id_Permiso == 0) 
                    {
                        permiso.Id_Permiso = Convert.ToInt32(row["Id_Permiso"]);
                        permiso.Id_Usuario = Convert.ToInt32(row["Id_Usuario"]);
                        permiso.Id_Modulo = Convert.ToInt32(row["Id_Modulo"]);
                        permiso.permiso_escritura = Convert.ToBoolean(row["permiso_escritura"]);
                        permiso.permiso_leer_abrir = Convert.ToBoolean(row["permiso_leer_abrir"]);
                    }
                }
                return (true, "Acceso concedido", user, permiso);
            }
            else 
            {
                return (false, "Acceso denegado", null, null);
            }

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
