using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejadores
{
    public class ManejadorPermisos
    {
        Base b = new Base("localhost", "root", "2026", "SistemaGestionHotelera");


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
