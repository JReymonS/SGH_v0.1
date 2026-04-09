using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorCargos
    {
        Base b = new Base("localhost", "root", "2026", "SistemaGestionHotelera", 3311);

        public void Guardar(Cargos cargos)
        {
            b.Comando($"Call p_GuardarCargo('{cargos.Concepto}','{cargos.Monto}','{cargos.Id_Reserva}')");
        }

        public void Borrar(Cargos cargos)
        {
            var rs = MessageBox.Show($"¿Estás seguro de eliminar el cargo?",
                "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                b.Comando($"Call p_EliminarCargo('{cargos.Id_Cargo}')");
            } 
        }

        public void Modificar(Cargos cargos)
        {
            b.Comando($"Call p_ModificarCargo('{cargos.Id_Cargo}','{cargos.Concepto},'{cargos.Monto}')");
        }

        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consulta(consulta, datos).Tables[0];
            tabla.Columns["Id_Cargo"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
