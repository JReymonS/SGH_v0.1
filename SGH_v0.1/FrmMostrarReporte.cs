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
    public partial class FrmMostrarReporte : Form
    {
        ManejadorReportes mr;
        private string tipoReporte;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            mr.ExportarExcel(DtgReporte, tipoReporte);
        }

        public FrmMostrarReporte(string rfc)
        {
            InitializeComponent();
            mr = new ManejadorReportes();
            tipoReporte = $"Reporte_Especifico_{rfc}";
            mr.MostrarReporteEspecifico(DtgReporte,rfc);
        }
        public FrmMostrarReporte(DateTime fechaInicio, DateTime fechaFin)
        {
            InitializeComponent();
            mr = new ManejadorReportes();
            tipoReporte = $"Reporte_General_{fechaInicio:yyyy-MM-dd}_al_{fechaFin:yyyy-MM-dd}";
            mr.MostrarReporteGeneral(DtgReporte,fechaInicio,fechaFin);
           
        }
        
    }
}
