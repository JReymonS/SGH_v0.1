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
                TxtBebida.Text = FrmCargos.cargos.Concepto.Replace("Bebida - ", ""); 
                  
                TxtCostoBebida.Text = FrmCargos.cargos.Monto.ToString();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            /*Este es un método para guardar el cargo de desayuno, 
             * evitando un error si dejamos los campos de bebida y costoBebida vacíos*/
            if (FrmCargos.cargos.Id_Cargo == 0)
            {
                if (string.IsNullOrWhiteSpace(TxtBebida.Text))
                {
                    mc.Guardar(new Cargos(0, "", "Desayuno - Huevos estrellados con chilaquiles", 150.00m, FrmCargos.seleccion));
                }
                else
                {
                    //Si sí se escribió el costo de la bebida, entonces se guarda
                    decimal costo = 0; //Costo de la bebida 
                    decimal.TryParse(TxtCostoBebida.Text, out costo);

                    string conceptoCargo = "Bebida - " + TxtBebida.Text;
                    mc.Guardar(new Cargos(0, "", conceptoCargo, costo, FrmCargos.seleccion));

                }
            }
            else
            {
                decimal costo = 0;
                decimal.TryParse(TxtCostoBebida.Text, out costo);

                string conceptoCargo = "Bebida - " + TxtBebida.Text;
                mc.Guardar(new Cargos(FrmCargos.cargos.Id_Cargo, "", conceptoCargo, costo, FrmCargos.cargos.Id_Reserva));

            }
            Close ();
        }
    }
}
