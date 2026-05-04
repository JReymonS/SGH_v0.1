using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorFactura
    {
        Base b = new Base("localhost", "root", "2026", "SistemaGestionHotelera", 3311);

        //Registrar factura
        public void RegistrarFactura(string metodoPago, decimal monto_total, int idReserva) 
        {
            b.Comando($"CALL p_PagarCargo('{metodoPago}',{monto_total},{idReserva})");
            MessageBox.Show("Pago registrado existosamente.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Generar factura en formato .txt
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
                        sw.WriteLine("_____________________________FACTURA_____________________________");
                        sw.WriteLine("=================================================================");
                        sw.WriteLine($"RFC: {huesped.RFC}");
                        sw.WriteLine($"Nombre: {huesped.Nombre} {huesped.Apellidos}");
                        sw.WriteLine($"Correo: {huesped.Correo}");
                        sw.WriteLine($"Teléfono: {huesped.Telefono}");
                        sw.WriteLine($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}");
                        sw.WriteLine();
                        sw.WriteLine("Cargos registrados:");
                        sw.WriteLine($"{"CONCEPTO".PadRight(50)}{"MONTO".PadLeft(10)}");
                        foreach (var cargo in listaCargos)
                        {
                            sw.WriteLine($"{cargo.Concepto.PadRight(50)}{cargo.Monto.ToString("F2").PadLeft(10)}");
                        }
                        sw.WriteLine("=================================================================");
                        sw.WriteLine("Gracias por su preferencia, vuelva pronto.");
                        sw.WriteLine("Generado por SGH - Sistema de Gestión Hotelera / CloudInn SA. CV.");
                    }
                    MessageBox.Show("Factura generada exitosamente.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar la factura: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
