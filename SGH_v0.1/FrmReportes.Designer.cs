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
            this.dPanel = new System.Windows.Forms.Panel();
            this.dPanelNombre = new System.Windows.Forms.Panel();
            this.dPanelFInicial = new System.Windows.Forms.Panel();
            this.dPanelFFinal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dPanel.SuspendLayout();
            this.dPanelNombre.SuspendLayout();
            this.dPanelFInicial.SuspendLayout();
            this.dPanelFFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(145)))));
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "   REPORTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "TIPO REPORTE:";
            // 
            // cmbReporte
            // 
            this.cmbReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReporte.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReporte.FormattingEnabled = true;
            this.cmbReporte.Items.AddRange(new object[] {
            "General",
            "Especifico"});
            this.cmbReporte.Location = new System.Drawing.Point(1, 1);
            this.cmbReporte.Margin = new System.Windows.Forms.Padding(2);
            this.cmbReporte.Name = "cmbReporte";
            this.cmbReporte.Size = new System.Drawing.Size(200, 33);
            this.cmbReporte.TabIndex = 3;
            this.cmbReporte.SelectedIndexChanged += new System.EventHandler(this.cmbReporte_SelectedIndexChanged);
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(23, 241);
            this.lblFechaInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(134, 25);
            this.lblFechaInicial.TabIndex = 4;
            this.lblFechaInicial.Text = "FECHA INCIAL:";
            this.lblFechaInicial.Visible = false;
            // 
            // dtpFechaReporteIni
            // 
            this.dtpFechaReporteIni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaReporteIni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaReporteIni.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReporteIni.Location = new System.Drawing.Point(1, 1);
            this.dtpFechaReporteIni.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaReporteIni.Name = "dtpFechaReporteIni";
            this.dtpFechaReporteIni.Size = new System.Drawing.Size(243, 32);
            this.dtpFechaReporteIni.TabIndex = 5;
            this.dtpFechaReporteIni.Visible = false;
            // 
            // cmbEspecifico
            // 
            this.cmbEspecifico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEspecifico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEspecifico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecifico.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecifico.FormattingEnabled = true;
            this.cmbEspecifico.Location = new System.Drawing.Point(1, 1);
            this.cmbEspecifico.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEspecifico.Name = "cmbEspecifico";
            this.cmbEspecifico.Size = new System.Drawing.Size(200, 33);
            this.cmbEspecifico.TabIndex = 8;
            this.cmbEspecifico.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(447, 117);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 25);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "NOMBRE:";
            this.lblNombre.Visible = false;
            // 
            // dtpFechaReporteFini
            // 
            this.dtpFechaReporteFini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaReporteFini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaReporteFini.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReporteFini.Location = new System.Drawing.Point(1, 1);
            this.dtpFechaReporteFini.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaReporteFini.Name = "dtpFechaReporteFini";
            this.dtpFechaReporteFini.Size = new System.Drawing.Size(243, 32);
            this.dtpFechaReporteFini.TabIndex = 11;
            this.dtpFechaReporteFini.Visible = false;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(414, 241);
            this.lblFechaFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(126, 25);
            this.lblFechaFinal.TabIndex = 10;
            this.lblFechaFinal.Text = "FECHA FINAL:";
            this.lblFechaFinal.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::SGH_v0._1.Properties.Resources.Multiplication;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(754, 332);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::SGH_v0._1.Properties.Resources.Google_Web_Search;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(649, 332);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 35);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(145)))));
            this.pictureBox1.BackgroundImage = global::SGH_v0._1.Properties.Resources.Room_white;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(734, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dPanel
            // 
            this.dPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(145)))));
            this.dPanel.Controls.Add(this.cmbReporte);
            this.dPanel.Location = new System.Drawing.Point(163, 114);
            this.dPanel.Name = "dPanel";
            this.dPanel.Padding = new System.Windows.Forms.Padding(1);
            this.dPanel.Size = new System.Drawing.Size(202, 35);
            this.dPanel.TabIndex = 12;
            // 
            // dPanelNombre
            // 
            this.dPanelNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(145)))));
            this.dPanelNombre.Controls.Add(this.cmbEspecifico);
            this.dPanelNombre.Location = new System.Drawing.Point(544, 114);
            this.dPanelNombre.Name = "dPanelNombre";
            this.dPanelNombre.Padding = new System.Windows.Forms.Padding(1);
            this.dPanelNombre.Size = new System.Drawing.Size(202, 35);
            this.dPanelNombre.TabIndex = 13;
            this.dPanelNombre.Visible = false;
            // 
            // dPanelFInicial
            // 
            this.dPanelFInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(145)))));
            this.dPanelFInicial.Controls.Add(this.dtpFechaReporteIni);
            this.dPanelFInicial.Location = new System.Drawing.Point(163, 236);
            this.dPanelFInicial.Name = "dPanelFInicial";
            this.dPanelFInicial.Padding = new System.Windows.Forms.Padding(1);
            this.dPanelFInicial.Size = new System.Drawing.Size(245, 34);
            this.dPanelFInicial.TabIndex = 14;
            this.dPanelFInicial.Visible = false;
            // 
            // dPanelFFinal
            // 
            this.dPanelFFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(145)))));
            this.dPanelFFinal.Controls.Add(this.dtpFechaReporteFini);
            this.dPanelFFinal.Location = new System.Drawing.Point(545, 237);
            this.dPanelFFinal.Name = "dPanelFFinal";
            this.dPanelFFinal.Padding = new System.Windows.Forms.Padding(1);
            this.dPanelFFinal.Size = new System.Drawing.Size(245, 34);
            this.dPanelFFinal.TabIndex = 15;
            this.dPanelFFinal.Visible = false;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 400);
            this.Controls.Add(this.dPanelFFinal);
            this.Controls.Add(this.dPanelFInicial);
            this.Controls.Add(this.dPanelNombre);
            this.Controls.Add(this.dPanel);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dPanel.ResumeLayout(false);
            this.dPanelNombre.ResumeLayout(false);
            this.dPanelFInicial.ResumeLayout(false);
            this.dPanelFFinal.ResumeLayout(false);
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
        private System.Windows.Forms.Panel dPanel;
        private System.Windows.Forms.Panel dPanelNombre;
        private System.Windows.Forms.Panel dPanelFInicial;
        private System.Windows.Forms.Panel dPanelFFinal;
    }
}