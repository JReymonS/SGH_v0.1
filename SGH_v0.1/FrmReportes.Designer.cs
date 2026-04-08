namespace SGH_v0._1
{
    partial class FrmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReporte = new System.Windows.Forms.ComboBox();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.dtpFechaReporteIni = new System.Windows.Forms.DateTimePicker();
            this.cmbEspecifico = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaReporteFini = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(145)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1085, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "TIPO REPORTE";
            // 
            // cmbReporte
            // 
            this.cmbReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReporte.FormattingEnabled = true;
            this.cmbReporte.Items.AddRange(new object[] {
            "General",
            "Especifico"});
            this.cmbReporte.Location = new System.Drawing.Point(195, 135);
            this.cmbReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbReporte.Name = "cmbReporte";
            this.cmbReporte.Size = new System.Drawing.Size(275, 36);
            this.cmbReporte.TabIndex = 3;
            this.cmbReporte.SelectedIndexChanged += new System.EventHandler(this.cmbReporte_SelectedIndexChanged);
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(41, 276);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(135, 28);
            this.lblFechaInicial.TabIndex = 4;
            this.lblFechaInicial.Text = "FECHA INCIAL";
            this.lblFechaInicial.Visible = false;
            // 
            // dtpFechaReporteIni
            // 
            this.dtpFechaReporteIni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReporteIni.Location = new System.Drawing.Point(192, 270);
            this.dtpFechaReporteIni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaReporteIni.Name = "dtpFechaReporteIni";
            this.dtpFechaReporteIni.Size = new System.Drawing.Size(323, 34);
            this.dtpFechaReporteIni.TabIndex = 5;
            this.dtpFechaReporteIni.Visible = false;
            // 
            // cmbEspecifico
            // 
            this.cmbEspecifico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecifico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecifico.FormattingEnabled = true;
            this.cmbEspecifico.Location = new System.Drawing.Point(611, 132);
            this.cmbEspecifico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEspecifico.Name = "cmbEspecifico";
            this.cmbEspecifico.Size = new System.Drawing.Size(275, 36);
            this.cmbEspecifico.TabIndex = 8;
            this.cmbEspecifico.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(505, 135);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 28);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "NOMBRE";
            this.lblNombre.Visible = false;
            // 
            // dtpFechaReporteFini
            // 
            this.dtpFechaReporteFini.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReporteFini.Location = new System.Drawing.Point(681, 270);
            this.dtpFechaReporteFini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaReporteFini.Name = "dtpFechaReporteFini";
            this.dtpFechaReporteFini.Size = new System.Drawing.Size(323, 34);
            this.dtpFechaReporteFini.TabIndex = 11;
            this.dtpFechaReporteFini.Visible = false;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(539, 276);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(128, 28);
            this.lblFechaFinal.TabIndex = 10;
            this.lblFechaFinal.Text = "FECHA FINAL";
            this.lblFechaFinal.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(968, 430);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 44);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::SGH_v0._1.Properties.Resources.Google_Web_Search_x64;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(850, 430);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 44);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(145)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::SGH_v0._1.Properties.Resources.Room_white_x64;
            this.pictureBox1.Location = new System.Drawing.Point(1007, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.dtpFechaReporteFini);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbEspecifico);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFechaReporteIni);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.cmbReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbReporte;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaReporteIni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbEspecifico;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaReporteFini;
        private System.Windows.Forms.Label lblFechaFinal;
    }
}