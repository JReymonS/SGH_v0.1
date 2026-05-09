using AccesoDatos;
using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Drawing;

namespace Manejadores
{
    public class ManejadorReportes
    {
        Base b = new Base("localhost", "root", "2026", "SistemaGestionHotelera");
        public void MostrarContactos(DataGridView tabla, string consulta, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consulta(consulta, datos).Tables[0];
            tabla.AutoResizeRows();
            tabla.AutoResizeColumns();
        }
        public void LlenarComboEspecifico(ComboBox combo)
        {
            combo.DataSource = ObtenerEspecifico();
            combo.DisplayMember = "NombreCompleto";
            combo.ValueMember = "RFC";

        }
        public DataTable ObtenerEspecifico()
        {
            DataSet ds = b.Consulta("SELECT RFC, CONCAT(Nombre,' ', Apellidos) AS NombreCompleto FROM Huespedes", "Huespedes");
            return ds.Tables["Huespedes"];
        }
        public void MostrarReporteEspecifico(DataGridView dgv, string rfc)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(220, 220, 220);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ScrollBars = ScrollBars.Horizontal;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 80, 80);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 8, 0, 8);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            dgv.RowTemplate.Height = 45;

            string query = $"SELECT * FROM v_ReporteEspecifico WHERE RFC = '{rfc}';";
            MostrarContactos(dgv, query, "v_ReporteEspecifico");

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 214, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);
        }


        public void MostrarReporteGeneral(DataGridView dgv, DateTime fechaInicio, DateTime fechaFin)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(220, 220, 220);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ScrollBars = ScrollBars.Horizontal;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 80, 80);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 8, 0, 8);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            dgv.RowTemplate.Height = 45;

            string query = $@"SELECT * FROM v_ReporteGeneral WHERE Fecha_Entrada BETWEEN '{fechaInicio:yyyy,MM,dd}' AND '{fechaFin:yyyy,MM,dd}';";
            MostrarContactos(dgv, query, "v_ReporteGeneral");

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 214, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 20, 20);
        }


        public void ExportarExcel(DataGridView tabla, string nombreArchivo)
        {
            // Dejar que el usuario elija dónde guardar
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel|*.xlsx";
                sfd.FileName = nombreArchivo;

                if (sfd.ShowDialog() != DialogResult.OK) return;

                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Reporte");

                    // Encabezados
                    for (int i = 0; i < tabla.Columns.Count; i++)
                    {
                        ws.Cell(1, i + 1).Value = tabla.Columns[i].HeaderText;
                        ws.Cell(1, i + 1).Style.Font.Bold = true;
                        ws.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.LightBlue;
                    }

                    // Datos
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        for (int j = 0; j < tabla.Columns.Count; j++)
                        {
                            var valor = tabla.Rows[i].Cells[j].Value;
                            ws.Cell(i + 2, j + 1).Value = valor?.ToString() ?? "";
                        }
                    }

                    ws.Columns().AdjustToContents(); // autoajusta el ancho
                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Reporte exportado correctamente.", "¡ÉXITO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
