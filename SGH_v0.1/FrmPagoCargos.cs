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
        public FrmPagoCargos()
        {
            InitializeComponent();
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
    }
}
