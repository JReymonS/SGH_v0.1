namespace SGH_v0._1
{
    partial class FrmCargos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHuesped = new System.Windows.Forms.TextBox();
            this.DtgDatosHuesped = new System.Windows.Forms.DataGridView();
            this.DtgDatosCargo = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnAgregarCargo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosHuesped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(145)))));
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1001, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARGOS A LA HABITACIÓN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(145)))));
            this.pictureBox1.BackgroundImage = global::SGH_v0._1.Properties.Resources.Room_white;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(867, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "HUESPED:";
            // 
            // TxtHuesped
            // 
            this.TxtHuesped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtHuesped.Location = new System.Drawing.Point(143, 144);
            this.TxtHuesped.Margin = new System.Windows.Forms.Padding(4);
            this.TxtHuesped.Multiline = true;
            this.TxtHuesped.Name = "TxtHuesped";
            this.TxtHuesped.Size = new System.Drawing.Size(647, 29);
            this.TxtHuesped.TabIndex = 3;
            // 
            // DtgDatosHuesped
            // 
            this.DtgDatosHuesped.AllowUserToAddRows = false;
            this.DtgDatosHuesped.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.DtgDatosHuesped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgDatosHuesped.DefaultCellStyle = dataGridViewCellStyle1;
            this.DtgDatosHuesped.GridColor = System.Drawing.SystemColors.ControlText;
            this.DtgDatosHuesped.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.DtgDatosHuesped.Location = new System.Drawing.Point(48, 191);
            this.DtgDatosHuesped.Margin = new System.Windows.Forms.Padding(4);
            this.DtgDatosHuesped.Name = "DtgDatosHuesped";
            this.DtgDatosHuesped.RowHeadersWidth = 51;
            this.DtgDatosHuesped.Size = new System.Drawing.Size(833, 153);
            this.DtgDatosHuesped.TabIndex = 5;
            this.DtgDatosHuesped.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatosHuesped_CellClick);
            // 
            // DtgDatosCargo
            // 
            this.DtgDatosCargo.AllowUserToAddRows = false;
            this.DtgDatosCargo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.DtgDatosCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgDatosCargo.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtgDatosCargo.GridColor = System.Drawing.SystemColors.ControlText;
            this.DtgDatosCargo.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.DtgDatosCargo.Location = new System.Drawing.Point(48, 370);
            this.DtgDatosCargo.Margin = new System.Windows.Forms.Padding(4);
            this.DtgDatosCargo.Name = "DtgDatosCargo";
            this.DtgDatosCargo.RowHeadersWidth = 51;
            this.DtgDatosCargo.Size = new System.Drawing.Size(577, 139);
            this.DtgDatosCargo.TabIndex = 6;
            this.DtgDatosCargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatosCargo_CellClick);
            this.DtgDatosCargo.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatosCargo_CellEnter);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::SGH_v0._1.Properties.Resources.Google_Web_Search;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(789, 134);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(53, 49);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnAgregarCargo
            // 
            this.BtnAgregarCargo.BackgroundImage = global::SGH_v0._1.Properties.Resources.Add_New;
            this.BtnAgregarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAgregarCargo.FlatAppearance.BorderSize = 0;
            this.BtnAgregarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCargo.Location = new System.Drawing.Point(633, 362);
            this.BtnAgregarCargo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregarCargo.Name = "BtnAgregarCargo";
            this.BtnAgregarCargo.Size = new System.Drawing.Size(53, 49);
            this.BtnAgregarCargo.TabIndex = 8;
            this.BtnAgregarCargo.UseVisualStyleBackColor = true;
            this.BtnAgregarCargo.Click += new System.EventHandler(this.BtnAgregarCargo_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(716, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "MONTO:";
            // 
            // TxtMonto
            // 
            this.TxtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMonto.Enabled = false;
            this.TxtMonto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.Location = new System.Drawing.Point(799, 370);
            this.TxtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMonto.Multiline = true;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(81, 28);
            this.TxtMonto.TabIndex = 10;
            this.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SGH_v0._1.Properties.Resources.Info;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(53, 551);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 554);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tip: Seleccione un registro que desea editar o eliminar.\r\n\r\n";
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackgroundImage = global::SGH_v0._1.Properties.Resources.Pay;
            this.BtnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPagar.FlatAppearance.BorderSize = 0;
            this.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagar.Location = new System.Drawing.Point(799, 530);
            this.BtnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(57, 49);
            this.BtnPagar.TabIndex = 13;
            this.BtnPagar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackgroundImage = global::SGH_v0._1.Properties.Resources.Pencil;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Location = new System.Drawing.Point(873, 528);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(53, 49);
            this.BtnEditar.TabIndex = 14;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackgroundImage = global::SGH_v0._1.Properties.Resources.Remove_Book;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(944, 529);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(53, 49);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click_1);
            // 
            // FrmCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 603);
            this.Controls.Add(this.TxtHuesped);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAgregarCargo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DtgDatosCargo);
            this.Controls.Add(this.DtgDatosHuesped);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCargos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosHuesped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHuesped;
        private System.Windows.Forms.DataGridView DtgDatosHuesped;
        private System.Windows.Forms.DataGridView DtgDatosCargo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnAgregarCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}