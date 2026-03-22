using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permisos
    {
        public Permisos(int id_Permiso, int id_Usuario, int id_Modulo, bool permiso_leer_abrir, bool permiso_escritura)
        {
            Id_Permiso = id_Permiso;
            Id_Usuario = id_Usuario;
            Id_Modulo = id_Modulo;
            this.permiso_leer_abrir = permiso_leer_abrir;
            this.permiso_escritura = permiso_escritura;
        }

        public int Id_Permiso { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Modulo { get; set; }
        public bool permiso_leer_abrir { get; set; }
        public bool permiso_escritura { get; set;  }

     }
}
