using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace SGH_v0._1
{
    public partial class FrmCargos : Form
    {
        ManejadorCargos mc;
        public static Cargos cargos = new Cargos(0, "", "", 0m, 0); //El 0m es porque es un valor decimal.
        int fila = 0, columna = 0;
        public static int seleccion = 0; //Saber a que reserva se le va a cobrar a partir de la id de la reserva.

        public FrmCargos()
        {
            InitializeComponent();
            mc = new ManejadorCargos();

            DiseñoDTG(DtgDatosHuesped);
            DiseñoDTG(DtgDatosCargo);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string consulta = $"SELECT Id_Reserva, NOMBRE, APELLIDOS, TELEFONO, EMAIL, RFC " +
                              $"FROM v_CargoHuesped " +
                              $"WHERE NOMBRE LIKE '%{TxtHuesped.Text}%' AND PAGO = 'Pendiente'";

            mc.Mostrar(consulta, DtgDatosHuesped, "v_CargoHuesped");
        }

        private void DtgDatosHuesped_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccion = int.Parse(DtgDatosHuesped.Rows[e.RowIndex].Cells["Id_Reserva"].Value.ToString());

            ActualizarCargos();
        }

        private void ActualizarCargos()
        {
            string cargosConsulta = $"SELECT Id_Cargo, Concepto AS \"CONCEPTO\", Monto AS \"COSTO\" FROM Cargos " +
                                    $"WHERE Id_Reserva = {seleccion}";
            mc.Mostrar(cargosConsulta, DtgDatosCargo, "Cargos");

            CalcularCargoTotal();
        }

        private void DtgDatosCargo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void BtnAgregarCargo_Click_1(object sender, EventArgs e)
        {
            cargos.Id_Cargo = 0; cargos.Concepto = ""; cargos.Monto = 0m;

            FrmDatosCargos fdc = new FrmDatosCargos();
            fdc.ShowDialog();
            //DtgDatosCargo.Columns.Clear();

            ActualizarCargos();
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            if (DtgDatosCargo.CurrentRow != null) //Validar que se haya dado clic en una fila del DtgDatosCargo
            {
                // Extraer los datos de la fila seleccionada
                string conceptoSeleccionado = DtgDatosCargo.CurrentRow.Cells["CONCEPTO"].Value.ToString();
                if (conceptoSeleccionado.Contains("Desayuno"))
                {
                    MessageBox.Show("El paquete de Desayuno no se puede modificar. Si desea corregirlo, " +
                                    "elimine el cargo y vuelva a agregarlo.", "Acción denegada",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cargos.Id_Cargo = int.Parse(DtgDatosCargo.CurrentRow.Cells["Id_Cargo"].Value.ToString());
                //cargos.Concepto = DtgDatosCargo.CurrentRow.Cells["Concepto"].Value.ToString();
                cargos.Concepto = conceptoSeleccionado;
                cargos.Monto = decimal.Parse(DtgDatosCargo.CurrentRow.Cells["COSTO"].Value.ToString());

                FrmDatosCargos fdc = new FrmDatosCargos();
                fdc.ShowDialog();

                ActualizarCargos();

            }
            else
            {
                MessageBox.Show("Seleccione un cargo para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (DtgDatosCargo.CurrentRow != null)
            {
                cargos.Id_Cargo = int.Parse(DtgDatosCargo.CurrentRow.Cells["Id_Cargo"].Value.ToString());
                cargos.Concepto = DtgDatosCargo.CurrentRow.Cells["CONCEPTO"].Value.ToString();
                mc.Borrar(cargos);
                ActualizarCargos();

            }
            else
            {
                MessageBox.Show("Seleccione un cargo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DtgDatosCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargos.Id_Cargo = int.Parse(DtgDatosCargo.Rows[fila].Cells["Id_Cargo"].Value.ToString());
            //cargos.Fecha = DtgDatosCargo.Rows[fila].Cells["Fecha"].Value.ToString();
            cargos.Concepto = DtgDatosCargo.Rows[fila].Cells["CONCEPTO"].Value.ToString();
            cargos.Monto = decimal.Parse(DtgDatosCargo.Rows[fila].Cells["COSTO"].Value.ToString());
            cargos.Id_Reserva = seleccion;

        }

        private void CalcularCargoTotal()
        {
            decimal total = 0m;

            foreach(DataGridViewRow renglon in DtgDatosCargo.Rows)
            {
                if (renglon.Cells["COSTO"].Value != null)
                {
                    total += decimal.Parse(renglon.Cells["COSTO"].Value.ToString());
                }
            }
            TxtMonto.Text = total.ToString(); 
        }

        // Diseño para el DataGridView 
        private void DiseñoDTG (DataGridView dgv)
        {

            dgv.RowHeadersVisible = false;

            // Ocultar la flecha selectora y el renglón extra
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;

            // Estilo de encabezados de columnas
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(244, 244, 244);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Tamaño de encabezados de columnas
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F);

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Celdas
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(244, 244, 244);

            // Selección Azul
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 232, 245);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Líneas divisorias
            dgv.GridColor = Color.LightGray;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            //dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgv.AllowUserToResizeRows = false;

        }
    }
}
