using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

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
            string query = $"SELECT * FROM v_ReporteEspecifico WHERE RFC = '{rfc}';";
            MostrarContactos(dgv, query, "v_ReporteEspecifico");
        }
        public void MostrarReporteGeneral(DataGridView dgv, DateTime fechaInicio, DateTime fechaFin)
        {
            string query = $@"SELECT * FROM v_ReporteGeneral WHERE Fecha_Entrada BETWEEN '{fechaInicio:yyyy,MM,dd}' AND '{fechaFin:yyyy,MM,dd}';";
            MostrarContactos(dgv, query, "v_ReporteGeneral");
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

                MessageBox.Show("Reporte exportado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
