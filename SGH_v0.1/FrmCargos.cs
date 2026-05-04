using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace SGH_v0._1
{
    public partial class FrmCargos : Form
    {
        ManejadorCargos mc;
        public static Cargos cargos = new Cargos(0, "", "", 0m, 0); //El 0m es porque es un valor decimal.
        public static Huespedes huesped = new Huespedes("", "", "", "", ""); //Huesped para factura.
        public static List<Cargos> listaCargos = new List<Cargos>(); //Lista para almacenar los cargos del huesped seleccionado y mostrar el monto total a pagar.
        int fila = 0, columna = 0;
        public static int seleccion = 0; //Saber a que reserva se le va a cobrar a partir de la id de la reserva.
        public static decimal montoTotal = 0m; //Saber el monto total y cantidad a pagar.
       

        public FrmCargos()
        {
            InitializeComponent();
            mc = new ManejadorCargos();

            TxtHuesped.Text = "Buscar huesped...";
            TxtHuesped.ForeColor = Color.Gray;

            this.ActiveControl = BtnBuscar;

            DiseñoDTG(DtgDatosHuesped);
            DiseñoDTG(DtgDatosCargo);
        }


        //Buscar huesped
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = TxtHuesped.Text;

            if(busqueda == TxtHuesped.Text)
            {
                busqueda = "";
            }

            string consulta = $"SELECT Id_Reserva, NOMBRE, APELLIDOS, TELEFONO, EMAIL, RFC " +
                              $"FROM v_CargoHuesped " +
                              $"WHERE NOMBRE LIKE '%{busqueda}%' AND PAGO = 'Pagado'";

            mc.Mostrar(consulta, DtgDatosHuesped, "v_CargoHuesped");
        }


        //Seleccionar un huesped para mostrar sus cargos
        private void DtgDatosHuesped_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                seleccion = int.Parse(DtgDatosHuesped.Rows[e.RowIndex].Cells["Id_Reserva"].Value.ToString());
                string nombre = DtgDatosHuesped.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString(); //Nombre del huesped
                string apellidos = DtgDatosHuesped.Rows[e.RowIndex].Cells["APELLIDOS"].Value.ToString(); //Apellidos del huesped
                string telefono = DtgDatosHuesped.Rows[e.RowIndex].Cells["TELEFONO"].Value.ToString(); //Telefono del huesped
                string correo = DtgDatosHuesped.Rows[e.RowIndex].Cells["EMAIL"].Value.ToString(); //Correo del huesped
                string rfc = DtgDatosHuesped.Rows[e.RowIndex].Cells["RFC"].Value.ToString(); //RFC del huesped

                huesped.Nombre = nombre;
                huesped.Apellidos = apellidos;
                huesped.Telefono = telefono;
                huesped.Correo = correo;
                huesped.RFC = rfc;

                ActualizarCargos(); //Mostrar los cargos del huesped seleccionado

                if(DtgDatosCargo.Rows.Count == 0)
                {
                    MessageBox.Show($"No hay cargos registrados para el huésped {nombre}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }
        

        //Metodo para actualizar cargos del huesped
        private void ActualizarCargos()
        {
            string cargosConsulta = $"SELECT Id_Cargo, Concepto AS \"CONCEPTO\", Monto AS \"COSTO\" FROM Cargos " +
                                    $"WHERE Id_Reserva = {seleccion} AND Estado_cargo='Pendiente'";
            mc.Mostrar(cargosConsulta, DtgDatosCargo, "Cargos");
            mc.ObtenerCargos(listaCargos, DtgDatosCargo);
            CalcularCargoTotal();
        }


        //Obtiene los datos del registro
        private void DtgDatosCargo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }


        //Agrega nuevo cargo
        private void BtnAgregarCargo_Click_1(object sender, EventArgs e)
        {
            cargos.Id_Cargo = 0; cargos.Concepto = ""; cargos.Monto = 0m;

            FrmDatosCargos fdc = new FrmDatosCargos();
            fdc.ShowDialog();
            ActualizarCargos();
        }


        //Edita el cargo seleccionado
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


        //Elimina el cargo seleccionado
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


        //Obtiene los datos del cargo seleccionado para editar o eliminar
        private void DtgDatosCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargos.Id_Cargo = int.Parse(DtgDatosCargo.Rows[fila].Cells["Id_Cargo"].Value.ToString());
            cargos.Concepto = DtgDatosCargo.Rows[fila].Cells["CONCEPTO"].Value.ToString();
            cargos.Monto = decimal.Parse(DtgDatosCargo.Rows[fila].Cells["COSTO"].Value.ToString());
            cargos.Id_Reserva = seleccion;

        }


        //Metodo para calcular el monto total de los cargos
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
            montoTotal = total;
            TxtMonto.Text = total.ToString("F2"); 
        }


        //Coloca el texto fantasma en la busqueda
        private void TxtHuesped_Enter(object sender, EventArgs e)
        {
            if(TxtHuesped.Text == "Buscar huesped...")
            {
                TxtHuesped.Text = "";
                TxtHuesped.ForeColor = Color.Black;
            }

        }


        //Coloca el texto fantasma en la busqueda
        private void TxtHuesped_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TxtHuesped.Text))
            {
                TxtHuesped.Text = "Buscar huesped...";
                TxtHuesped.ForeColor = Color.Gray;

                if(DtgDatosHuesped.DataSource != null)
                {
                    ((DataTable)DtgDatosHuesped.DataSource).DefaultView.RowFilter = ""; // Quitar el filtro para mostrar todos los huespedes
                }
            }
        }


        //Filtra la busqueda en tiempo de ejecución
        private void TxtHuesped_TextChanged(object sender, EventArgs e)
        {
            if(TxtHuesped.Text != "Buscar huesped..." && DtgDatosHuesped.DataSource != null)
            {
                DataTable dt = (DataTable)DtgDatosHuesped.DataSource;
                dt.DefaultView.RowFilter = $"NOMBRE LIKE '%{TxtHuesped.Text}%'"; // Filtrar por nombre
            }
        }


        //Agrega un pago
        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtMonto.Text) && TxtMonto.Text != "0.00")
            {
                FrmPagoCargos fpc = new FrmPagoCargos();
                fpc.ShowDialog();
                ActualizarCargos();
            }
            else 
            {
                MessageBox.Show("No hay cargos que pagar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(244, 244, 244);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

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

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgv.AllowUserToResizeRows = false;

            dgv.ReadOnly = true;
        }
    }
}
