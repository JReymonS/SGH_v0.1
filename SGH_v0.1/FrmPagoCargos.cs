using Manejadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        //Evento de carga para el datos del pago.
        private void FrmPagoCargos_Load(object sender, EventArgs e)
        {
            cmbTipoPago.SelectedIndex = 0; 
            txtTotal.Text = FrmCargos.montoTotal.ToString();
            txtCantidad.Text = FrmCargos.montoTotal.ToString();
        }


        //Evento para cerrar formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Logica
            var rs=MessageBox.Show("¿Desea generar su factura?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) { mf.GenerarFactura(FrmCargos.huesped, FrmCargos.listaCargos); }



           /* MessageBox.Show($"Pago registrado exitosamente para {FrmCargos.huesped.Nombre} {FrmCargos.huesped.Apellidos}");
            foreach (var item in FrmCargos.listaCargos) 
            {
                MessageBox.Show("Cargo: " + item.Concepto + "\nMonto: " + item.Monto);
            }*/
        }
    }
}
