using DocumentFormat.OpenXml.Drawing.Diagrams;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorFactura
    {
        public void GenerarFactura(Huespedes huesped, List<Cargos> listaCargos)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Guardar archivo";
            sfd.Filter = "Archivos de texto (*.txt)|*.txt";
            sfd.FileName = $"Factura_{huesped.RFC}.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = sfd.FileName;
                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(rutaArchivo))
                    {
                        sw.WriteLine("_______________________FACTURA______________________");
                        sw.WriteLine("====================================================");
                        sw.WriteLine($"RFC: {huesped.RFC}");
                        sw.WriteLine($"Nombre: {huesped.Nombre} {huesped.Apellidos}");
                        sw.WriteLine($"Correo: {huesped.Correo}");
                        sw.WriteLine($"Teléfono: {huesped.Telefono}");
                        sw.WriteLine($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}");
                        sw.WriteLine();
                        sw.WriteLine("Cargos registrados:");
                        sw.WriteLine($"{"CONCEPTO".PadRight(40)}{"MONTO".PadLeft(10)}");
                        foreach (var cargo in listaCargos)
                        {
                            sw.WriteLine($"{cargo.Concepto.PadRight(40)}{cargo.Monto.ToString("F2").PadLeft(10)}");
                            /*sw.WriteLine($"Concepto: {cargo.Concepto}");
                            sw.WriteLine($"Monto: ${cargo.Monto}");*/
                        }
                        sw.WriteLine("=====================================================");
                        sw.WriteLine("Gracias por su preferencia, vuelva pronto.");
                        sw.WriteLine("Generado por SGH - Sistema de Gestión Hotelera CloudInn SA. CV.");
                    }
                    MessageBox.Show("Factura generada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
