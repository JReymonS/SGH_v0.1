using System;
using Manejadores;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace SGH_v0._1
{    
    public partial class FrmReportes : Form
    {
        ManejadorReportes mr;
        public FrmReportes()
        {
            InitializeComponent();
            mr = new ManejadorReportes();
            mr.LlenarComboEspecifico(cmbEspecifico);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbReporte.SelectedItem == null)
            {
                MessageBox.Show("Favor de seleccionar algun tipo de reporte");
                return;
            }
                
            switch (cmbReporte.SelectedItem.ToString())
            {
                case "General":
                    FrmMostrarReporte mrGeneral = new FrmMostrarReporte(dtpFechaReporteIni.Value,dtpFechaReporteFini.Value);
                    mrGeneral.ShowDialog();
                    break;
                case "Especifico":
                    if (cmbEspecifico.SelectedItem == null)
                    {
                        MessageBox.Show("Favor de seleccionar algun huésped");
                        return;
                    }
                    string rfc = cmbEspecifico.SelectedValue.ToString();
                    FrmMostrarReporte mrEspecifico = new FrmMostrarReporte(rfc);
                    mrEspecifico.ShowDialog();
                    break;
            }
        }

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbReporte.SelectedItem.ToString())
            {
                case "General":
                    lblFechaInicial.Visible = true;
                    dtpFechaReporteIni.Visible = true;
                    lblFechaFinal.Visible = true;
                    dtpFechaReporteFini.Visible = true;
                    lblNombre.Visible = false;
                    cmbEspecifico.Visible = false;
                    break;
                case "Especifico":
                    lblNombre.Visible = true;
                    cmbEspecifico.Visible = true;
                    lblFechaInicial.Visible = false;
                    dtpFechaReporteIni.Visible = false;
                    lblFechaFinal.Visible = false;
                    dtpFechaReporteFini.Visible = false;
                    break;
            }
        }
    }
}
