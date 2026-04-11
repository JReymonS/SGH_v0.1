using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace SGH_v0._1
{
    public partial class FrmDatosCargos : Form
    {
        ManejadorCargos mc;
        public FrmDatosCargos()
        {
            InitializeComponent();
            mc = new ManejadorCargos();
            
            if(mc != null)
            {
                TxtBebida.Text = FrmCargos.cargos.Concepto;
                TxtCostoBebida.Text = FrmCargos.cargos.Monto.ToString();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string conceptoCargo = "Bebida " + TxtBebida.Text;
            decimal costo = decimal.Parse(TxtCostoBebida.Text);

            if(FrmCargos.cargos.Id_Cargo == 0)
            {
                //Orden: Id_Cargo, Fecha, Concepto, Monto, Id_Reserva
                mc.Guardar(new Cargos(0, "", conceptoCargo, costo, FrmCargos.seleccion));
            }
            else
            {
                mc.Modificar(new Cargos(FrmCargos.cargos.Id_Cargo, "", conceptoCargo, costo, FrmCargos.cargos.Id_Reserva));
            }

            Close ();
        }
    }
}
