namespace SGH_v0._1
{
    partial class FrmHousekeeping
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.noHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBuscarHabitacion = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtHabitacionesDisponibles = new System.Windows.Forms.TextBox();
            this.LblhabitacionesDisp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LblhabitacionesOcup = new System.Windows.Forms.Label();
            this.TxtHabitacionesOcupadas = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LblhabitacionesLimp = new System.Windows.Forms.Label();
            this.TxtHabitacionesLimpieza = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.LblhabitacionesMante = new System.Windows.Forms.Label();
            this.TxtHabitacionesMantenimiento = new System.Windows.Forms.TextBox();
            this.BtnDisponible = new System.Windows.Forms.Button();
            this.BtnOcupada = new System.Windows.Forms.Button();
            this.BtnEnLimpieza = new System.Windows.Forms.Button();
            this.BtnEnMantenimiento = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.Lblinformacion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 53);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOUSEKEEPING";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGH_v0._1.Properties.Resources.Room_white;
            this.pictureBox1.Location = new System.Drawing.Point(853, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.AllowUserToDeleteRows = false;
            this.DtgDatos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noHabitacion,
            this.Tipo,
            this.estadoHabitacion,
            this.Capacidad,
            this.Piso});
            this.DtgDatos.Location = new System.Drawing.Point(36, 171);
            this.DtgDatos.Margin = new System.Windows.Forms.Padding(2);
            this.DtgDatos.MultiSelect = false;
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.ReadOnly = true;
            this.DtgDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgDatos.RowHeadersVisible = false;
            this.DtgDatos.RowHeadersWidth = 51;
            this.DtgDatos.RowTemplate.Height = 24;
            this.DtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgDatos.Size = new System.Drawing.Size(690, 315);
            this.DtgDatos.TabIndex = 1;
            this.DtgDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtgDatos_CellFormatting);
            // 
            // noHabitacion
            // 
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.noHabitacion.DefaultCellStyle = dataGridViewCellStyle21;
            this.noHabitacion.HeaderText = "NO.";
            this.noHabitacion.MinimumWidth = 6;
            this.noHabitacion.Name = "noHabitacion";
            this.noHabitacion.ReadOnly = true;
            this.noHabitacion.Width = 140;
            // 
            // Tipo
            // 
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle22;
            this.Tipo.HeaderText = "TIPO";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 180;
            // 
            // estadoHabitacion
            // 
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            this.estadoHabitacion.DefaultCellStyle = dataGridViewCellStyle23;
            this.estadoHabitacion.HeaderText = "ESTADO_HABITACION";
            this.estadoHabitacion.MinimumWidth = 6;
            this.estadoHabitacion.Name = "estadoHabitacion";
            this.estadoHabitacion.ReadOnly = true;
            this.estadoHabitacion.Width = 200;
            // 
            // Capacidad
            // 
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.Capacidad.DefaultCellStyle = dataGridViewCellStyle24;
            this.Capacidad.HeaderText = "CAPACIDAD";
            this.Capacidad.MinimumWidth = 6;
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.ReadOnly = true;
            this.Capacidad.Width = 140;
            // 
            // Piso
            // 
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            this.Piso.DefaultCellStyle = dataGridViewCellStyle25;
            this.Piso.HeaderText = "PISO";
            this.Piso.MinimumWidth = 6;
            this.Piso.Name = "Piso";
            this.Piso.ReadOnly = true;
            this.Piso.Width = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "NO.";
            // 
            // TxtBuscarHabitacion
            // 
            this.TxtBuscarHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarHabitacion.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtBuscarHabitacion.Location = new System.Drawing.Point(75, 130);
            this.TxtBuscarHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBuscarHabitacion.Multiline = true;
            this.TxtBuscarHabitacion.Name = "TxtBuscarHabitacion";
            this.TxtBuscarHabitacion.Size = new System.Drawing.Size(604, 29);
            this.TxtBuscarHabitacion.TabIndex = 3;
            this.TxtBuscarHabitacion.Text = "Buscar habitacion...";
            this.TxtBuscarHabitacion.TextChanged += new System.EventHandler(this.TxtBuscarHabitacion_TextChanged);
            this.TxtBuscarHabitacion.Enter += new System.EventHandler(this.TxtBuscarHabitacion_Enter);
            this.TxtBuscarHabitacion.Leave += new System.EventHandler(this.TxtBuscarHabitacion_Leave);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::SGH_v0._1.Properties.Resources.Google_Web_Search;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.Location = new System.Drawing.Point(699, 126);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(30, 32);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackgroundImage = global::SGH_v0._1.Properties.Resources.Save;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGuardar.Location = new System.Drawing.Point(813, 499);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(30, 32);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::SGH_v0._1.Properties.Resources.Multiplication;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.Location = new System.Drawing.Point(862, 499);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(30, 32);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtHabitacionesDisponibles
            // 
            this.TxtHabitacionesDisponibles.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtHabitacionesDisponibles.Enabled = false;
            this.TxtHabitacionesDisponibles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHabitacionesDisponibles.Location = new System.Drawing.Point(50, 82);
            this.TxtHabitacionesDisponibles.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHabitacionesDisponibles.Multiline = true;
            this.TxtHabitacionesDisponibles.Name = "TxtHabitacionesDisponibles";
            this.TxtHabitacionesDisponibles.ReadOnly = true;
            this.TxtHabitacionesDisponibles.Size = new System.Drawing.Size(178, 37);
            this.TxtHabitacionesDisponibles.TabIndex = 7;
            this.TxtHabitacionesDisponibles.Text = "Habitaciones \r\ndisponibles";
            this.TxtHabitacionesDisponibles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblhabitacionesDisp
            // 
            this.LblhabitacionesDisp.AutoSize = true;
            this.LblhabitacionesDisp.BackColor = System.Drawing.Color.PowderBlue;
            this.LblhabitacionesDisp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblhabitacionesDisp.Location = new System.Drawing.Point(200, 98);
            this.LblhabitacionesDisp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblhabitacionesDisp.Name = "LblhabitacionesDisp";
            this.LblhabitacionesDisp.Size = new System.Drawing.Size(19, 15);
            this.LblhabitacionesDisp.TabIndex = 8;
            this.LblhabitacionesDisp.Text = "20";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox2.BackgroundImage = global::SGH_v0._1.Properties.Resources.Disponibles;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(54, 86);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 28);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox3.BackgroundImage = global::SGH_v0._1.Properties.Resources.Ocupadas;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(269, 86);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 28);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // LblhabitacionesOcup
            // 
            this.LblhabitacionesOcup.AutoSize = true;
            this.LblhabitacionesOcup.BackColor = System.Drawing.Color.PowderBlue;
            this.LblhabitacionesOcup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblhabitacionesOcup.Location = new System.Drawing.Point(415, 100);
            this.LblhabitacionesOcup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblhabitacionesOcup.Name = "LblhabitacionesOcup";
            this.LblhabitacionesOcup.Size = new System.Drawing.Size(19, 15);
            this.LblhabitacionesOcup.TabIndex = 11;
            this.LblhabitacionesOcup.Text = "20";
            // 
            // TxtHabitacionesOcupadas
            // 
            this.TxtHabitacionesOcupadas.AcceptsReturn = true;
            this.TxtHabitacionesOcupadas.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtHabitacionesOcupadas.Enabled = false;
            this.TxtHabitacionesOcupadas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHabitacionesOcupadas.Location = new System.Drawing.Point(265, 82);
            this.TxtHabitacionesOcupadas.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHabitacionesOcupadas.Multiline = true;
            this.TxtHabitacionesOcupadas.Name = "TxtHabitacionesOcupadas";
            this.TxtHabitacionesOcupadas.ReadOnly = true;
            this.TxtHabitacionesOcupadas.Size = new System.Drawing.Size(178, 37);
            this.TxtHabitacionesOcupadas.TabIndex = 10;
            this.TxtHabitacionesOcupadas.Text = "Habitaciones \r\nocupadas";
            this.TxtHabitacionesOcupadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox4.BackgroundImage = global::SGH_v0._1.Properties.Resources.Housekeeping;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(485, 86);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 28);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // LblhabitacionesLimp
            // 
            this.LblhabitacionesLimp.AutoSize = true;
            this.LblhabitacionesLimp.BackColor = System.Drawing.Color.PowderBlue;
            this.LblhabitacionesLimp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblhabitacionesLimp.Location = new System.Drawing.Point(629, 100);
            this.LblhabitacionesLimp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblhabitacionesLimp.Name = "LblhabitacionesLimp";
            this.LblhabitacionesLimp.Size = new System.Drawing.Size(19, 15);
            this.LblhabitacionesLimp.TabIndex = 14;
            this.LblhabitacionesLimp.Text = "20";
            // 
            // TxtHabitacionesLimpieza
            // 
            this.TxtHabitacionesLimpieza.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtHabitacionesLimpieza.Enabled = false;
            this.TxtHabitacionesLimpieza.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHabitacionesLimpieza.Location = new System.Drawing.Point(481, 82);
            this.TxtHabitacionesLimpieza.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHabitacionesLimpieza.Multiline = true;
            this.TxtHabitacionesLimpieza.Name = "TxtHabitacionesLimpieza";
            this.TxtHabitacionesLimpieza.ReadOnly = true;
            this.TxtHabitacionesLimpieza.Size = new System.Drawing.Size(178, 37);
            this.TxtHabitacionesLimpieza.TabIndex = 13;
            this.TxtHabitacionesLimpieza.Text = "Habitaciones \r\nen limpieza\r\n";
            this.TxtHabitacionesLimpieza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox5.BackgroundImage = global::SGH_v0._1.Properties.Resources.Mantenimiento;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(700, 86);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 28);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // LblhabitacionesMante
            // 
            this.LblhabitacionesMante.AutoSize = true;
            this.LblhabitacionesMante.BackColor = System.Drawing.Color.PowderBlue;
            this.LblhabitacionesMante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblhabitacionesMante.Location = new System.Drawing.Point(847, 98);
            this.LblhabitacionesMante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblhabitacionesMante.Name = "LblhabitacionesMante";
            this.LblhabitacionesMante.Size = new System.Drawing.Size(19, 15);
            this.LblhabitacionesMante.TabIndex = 17;
            this.LblhabitacionesMante.Text = "20";
            // 
            // TxtHabitacionesMantenimiento
            // 
            this.TxtHabitacionesMantenimiento.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtHabitacionesMantenimiento.Enabled = false;
            this.TxtHabitacionesMantenimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHabitacionesMantenimiento.Location = new System.Drawing.Point(696, 82);
            this.TxtHabitacionesMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHabitacionesMantenimiento.Multiline = true;
            this.TxtHabitacionesMantenimiento.Name = "TxtHabitacionesMantenimiento";
            this.TxtHabitacionesMantenimiento.ReadOnly = true;
            this.TxtHabitacionesMantenimiento.Size = new System.Drawing.Size(178, 37);
            this.TxtHabitacionesMantenimiento.TabIndex = 16;
            this.TxtHabitacionesMantenimiento.Text = "Habitaciones \r\nen mantenimiento";
            this.TxtHabitacionesMantenimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnDisponible
            // 
            this.BtnDisponible.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnDisponible.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisponible.ForeColor = System.Drawing.Color.White;
            this.BtnDisponible.Location = new System.Drawing.Point(739, 201);
            this.BtnDisponible.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDisponible.Name = "BtnDisponible";
            this.BtnDisponible.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnDisponible.Size = new System.Drawing.Size(165, 28);
            this.BtnDisponible.TabIndex = 19;
            this.BtnDisponible.Text = " COMO DISPONIBLE";
            this.BtnDisponible.UseVisualStyleBackColor = false;
            this.BtnDisponible.Click += new System.EventHandler(this.BtnDisponible_Click);
            // 
            // BtnOcupada
            // 
            this.BtnOcupada.BackColor = System.Drawing.Color.Firebrick;
            this.BtnOcupada.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOcupada.ForeColor = System.Drawing.Color.White;
            this.BtnOcupada.Location = new System.Drawing.Point(739, 253);
            this.BtnOcupada.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOcupada.Name = "BtnOcupada";
            this.BtnOcupada.Size = new System.Drawing.Size(165, 28);
            this.BtnOcupada.TabIndex = 20;
            this.BtnOcupada.Text = "COMO OCUPADA";
            this.BtnOcupada.UseVisualStyleBackColor = false;
            this.BtnOcupada.Click += new System.EventHandler(this.BtnOcupada_Click);
            // 
            // BtnEnLimpieza
            // 
            this.BtnEnLimpieza.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnEnLimpieza.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnLimpieza.ForeColor = System.Drawing.Color.White;
            this.BtnEnLimpieza.Location = new System.Drawing.Point(739, 305);
            this.BtnEnLimpieza.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEnLimpieza.Name = "BtnEnLimpieza";
            this.BtnEnLimpieza.Size = new System.Drawing.Size(165, 28);
            this.BtnEnLimpieza.TabIndex = 21;
            this.BtnEnLimpieza.Text = "EN LIMPIEZA";
            this.BtnEnLimpieza.UseVisualStyleBackColor = false;
            this.BtnEnLimpieza.Click += new System.EventHandler(this.BtnEnLimpieza_Click);
            // 
            // BtnEnMantenimiento
            // 
            this.BtnEnMantenimiento.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnEnMantenimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnMantenimiento.ForeColor = System.Drawing.Color.White;
            this.BtnEnMantenimiento.Location = new System.Drawing.Point(739, 354);
            this.BtnEnMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEnMantenimiento.Name = "BtnEnMantenimiento";
            this.BtnEnMantenimiento.Size = new System.Drawing.Size(165, 28);
            this.BtnEnMantenimiento.TabIndex = 22;
            this.BtnEnMantenimiento.Text = "EN MANTENIMIENTO";
            this.BtnEnMantenimiento.UseVisualStyleBackColor = false;
            this.BtnEnMantenimiento.Click += new System.EventHandler(this.BtnEnMantenimiento_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox6.BackgroundImage = global::SGH_v0._1.Properties.Resources.Mantenimiento_white;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(743, 359);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(17, 19);
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox7.BackgroundImage = global::SGH_v0._1.Properties.Resources.Housekeeping_white;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(744, 310);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(17, 19);
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Firebrick;
            this.pictureBox8.BackgroundImage = global::SGH_v0._1.Properties.Resources.Ocupadas_white;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Location = new System.Drawing.Point(743, 258);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(17, 19);
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox9.BackgroundImage = global::SGH_v0._1.Properties.Resources.Disponibles_white;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(744, 206);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(17, 19);
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::SGH_v0._1.Properties.Resources.Info;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Location = new System.Drawing.Point(34, 504);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 23);
            this.pictureBox10.TabIndex = 27;
            this.pictureBox10.TabStop = false;
            // 
            // Lblinformacion
            // 
            this.Lblinformacion.AutoSize = true;
            this.Lblinformacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblinformacion.Location = new System.Drawing.Point(58, 508);
            this.Lblinformacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lblinformacion.Name = "Lblinformacion";
            this.Lblinformacion.Size = new System.Drawing.Size(175, 15);
            this.Lblinformacion.TabIndex = 28;
            this.Lblinformacion.Text = "Mostrando 8 de 20 habitaciones";
            // 
            // FrmHousekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 542);
            this.Controls.Add(this.Lblinformacion);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.BtnEnMantenimiento);
            this.Controls.Add(this.BtnEnLimpieza);
            this.Controls.Add(this.BtnOcupada);
            this.Controls.Add(this.BtnDisponible);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.LblhabitacionesMante);
            this.Controls.Add(this.TxtHabitacionesMantenimiento);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.LblhabitacionesLimp);
            this.Controls.Add(this.TxtHabitacionesLimpieza);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LblhabitacionesOcup);
            this.Controls.Add(this.TxtHabitacionesOcupadas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblhabitacionesDisp);
            this.Controls.Add(this.TxtHabitacionesDisponibles);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBuscarHabitacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHousekeeping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHousekeeping";
            this.Load += new System.EventHandler(this.FrmHousekeeping_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBuscarHabitacion;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtHabitacionesDisponibles;
        private System.Windows.Forms.Label LblhabitacionesDisp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LblhabitacionesOcup;
        private System.Windows.Forms.TextBox TxtHabitacionesOcupadas;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label LblhabitacionesLimp;
        private System.Windows.Forms.TextBox TxtHabitacionesLimpieza;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label LblhabitacionesMante;
        private System.Windows.Forms.TextBox TxtHabitacionesMantenimiento;
        private System.Windows.Forms.Button BtnDisponible;
        private System.Windows.Forms.Button BtnOcupada;
        private System.Windows.Forms.Button BtnEnLimpieza;
        private System.Windows.Forms.Button BtnEnMantenimiento;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label Lblinformacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
    }
}