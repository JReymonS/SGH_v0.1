using System;
using System.Collections.Generic;
using System.Drawing;
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
            b.Comando($"Call p_ModificarCargo('{cargos.Id_Cargo}','{cargos.Concepto}','{cargos.Monto}')");
        }

        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.BorderStyle = BorderStyle.None;
            tabla.BackgroundColor = Color.White;
            tabla.GridColor = Color.FromArgb(220, 220, 220);
            tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabla.RowHeadersVisible = false;
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToResizeRows = false;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.MultiSelect = false;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.ScrollBars = ScrollBars.Vertical;
            tabla.EnableHeadersVisualStyles = false;

            tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 80, 80);
            tabla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 8, 0, 8);
            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.ColumnHeadersHeight = 40;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            tabla.DefaultCellStyle.BackColor = Color.White;
            tabla.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            tabla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.DefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            tabla.RowTemplate.Height = 45;

            tabla.Columns.Clear();
            tabla.DataSource = b.Consulta(consulta, datos).Tables[datos];
            if (tabla.Columns.Contains("Id_Cargo")) { tabla.Columns["Id_Cargo"].Visible = false; }
            if(tabla.Columns.Contains("Id_Reserva")) { tabla.Columns["Id_Reserva"].Visible = false; }
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();

            tabla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 214, 255);
            tabla.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);
        }

        public void ObtenerCargos(List<Cargos> lista, DataGridView dtgDatos) 
        {
            lista.Clear();
            foreach (DataGridViewRow item in dtgDatos.Rows)
            {
                Cargos cargos = new Cargos(0, "", "", 0m, 0);
                cargos.Concepto = item.Cells["CONCEPTO"].Value.ToString();
                cargos.Monto = Convert.ToDecimal(item.Cells["COSTO"].Value);
                lista.Add(cargos);
            }
        }
    }
}
