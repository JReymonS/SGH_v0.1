using Manejadores;
using System;
using System.Windows.Forms;

namespace SGH_v0._1
{
    public partial class FrmPagoCargos : Form
    {
        ManejadorFactura mf;
        public FrmPagoCargos()
        {
            InitializeComponent();
            mf = new ManejadorFactura();
        }


        //Evento de carga para el datos del pago
        private void FrmPagoCargos_Load(object sender, EventArgs e)
        {
            cmbTipoPago.SelectedIndex = 0; 
            txtTotal.Text = FrmCargos.montoTotal.ToString();
            txtCantidad.Text = FrmCargos.montoTotal.ToString();
        }


        //Generar registro y factura
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mf.RegistrarFactura(cmbTipoPago.SelectedItem.ToString(), FrmCargos.montoTotal, FrmCargos.seleccion);
            var rs = MessageBox.Show("¿Desea generar su factura?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) { mf.GenerarFactura(FrmCargos.huesped, FrmCargos.listaCargos); }
            Close();
        }


        //Evento para cerrar formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
