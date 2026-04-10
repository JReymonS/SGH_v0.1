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
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string consulta = $"SELECT r.Id_Reserva, h.Nombre, h.Apellidos, h.Telefono, h.Correo, h.RFC" +
                              $"FROM Huespedes h INNER JOIN Reservas r ON h.RFC = r.RFC" +
                              $"WHERE h.Nombre LIKE '%{TxtHuesped.Text}%' AND r.Estado_Pago = 'Pendiente'";

            mc.Mostrar(consulta, DtgDatosHuesped, "Reservas");
        }

        private void DtgDatosHuesped_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccion = int.Parse(DtgDatosHuesped.Rows[e.RowIndex].Cells["Id_Reserva"].Value.ToString());

            ActualizarCargos();
        }

        private void ActualizarCargos()
        {
            string cargosConsulta = $"SELECT Id_Cargo, Descripcion, Monto FROM Cargos WHERE Id_Reserva = {seleccion}";
            mc.Mostrar(cargosConsulta, DtgDatosCargo, "Cargos");
        }

        private void DtgDatosCargo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

<<<<<<< Updated upstream
=======
        private void BtnAgregarCargo_Click(object sender, EventArgs e)
        {
            cargos.Id_Cargo = 0; cargos.Concepto = ""; cargos.Monto = 0m; 

            FrmDatosCargos fdc = new FrmDatosCargos();
            fdc.ShowDialog();
            //DtgDatosCargo.Columns.Clear();

            ActualizarCargos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DtgDatosCargo.CurrentRow != null) //Validar que se haya dado clic en una fila del DtgDatosCargo
            {
                cargos.Id_Cargo = int.Parse(DtgDatosCargo.CurrentRow.Cells["Id_Cargo"].Value.ToString());
                cargos.Concepto = DtgDatosCargo.CurrentRow.Cells["Concepto"].Value.ToString();
                cargos.Monto = decimal.Parse(DtgDatosCargo.CurrentRow.Cells["Monto"].Value.ToString());

                FrmDatosCargos fdc = new FrmDatosCargos();
                fdc.ShowDialog();

                ActualizarCargos();

            }
            else
            {
                MessageBox.Show("Seleccione un cargo para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DtgDatosCargo.CurrentRow != null)
            {
                cargos.Id_Cargo = int.Parse(DtgDatosCargo.CurrentRow.Cells["Id_Cargo"].Value.ToString());
                cargos.Concepto=  DtgDatosCargo.CurrentRow.Cells["Concepto"].Value.ToString();
                mc.Borrar(cargos);
                ActualizarCargos();

            }
            else
            {
                MessageBox.Show("Seleccione un cargo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

>>>>>>> Stashed changes
        private void DtgDatosCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargos.Id_Cargo = int.Parse(DtgDatosCargo.Rows[fila].Cells["Id_Cargo"].Value.ToString());
            //cargos.Fecha = DtgDatosCargo.Rows[fila].Cells["Fecha"].Value.ToString();
            cargos.Concepto = DtgDatosCargo.Rows[fila].Cells["Concepto"].Value.ToString();
            cargos.Monto = decimal.Parse(DtgDatosCargo.Rows[fila].Cells["Monto"].Value.ToString());
            cargos.Id_Reserva = seleccion;

        }

        //switch(columna){
            //case    












    }
}
