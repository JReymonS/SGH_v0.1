namespace SGH_v0._1
{
    partial class FrmHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.tsbHabitacionReserva = new System.Windows.Forms.ToolStripButton();
            this.tsbHousekeeping = new System.Windows.Forms.ToolStripButton();
            this.tsbCargos = new System.Windows.Forms.ToolStripButton();
            this.tsbReportes = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tsbLogout = new System.Windows.Forms.ToolStripButton();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCompress = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.AutoSize = false;
            this.tsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbHome,
            this.tsbHabitacionReserva,
            this.tsbHousekeeping,
            this.tsbCargos,
            this.tsbReportes,
            this.tsbUsuarios,
            this.tsbLogout});
            this.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(100, 755);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "MENU";
            // 
            // tsbHome
            // 
            this.tsbHome.AutoSize = false;
            this.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHome.Image = global::SGH_v0._1.Properties.Resources.Home_Page_white;
            this.tsbHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Margin = new System.Windows.Forms.Padding(0, 90, 0, 20);
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbHome.Size = new System.Drawing.Size(100, 60);
            this.tsbHome.Text = "HOME";
            this.tsbHome.Click += new System.EventHandler(this.tsbHome_Click);
            this.tsbHome.MouseEnter += new System.EventHandler(this.efectoHover_MouseEnter);
            this.tsbHome.MouseLeave += new System.EventHandler(this.efectoHover_MouseLeave);
            // 
            // tsbHabitacionReserva
            // 
            this.tsbHabitacionReserva.AutoSize = false;
            this.tsbHabitacionReserva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHabitacionReserva.Image = global::SGH_v0._1.Properties.Resources.Room_white;
            this.tsbHabitacionReserva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHabitacionReserva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHabitacionReserva.Margin = new System.Windows.Forms.Padding(0, 15, 0, 20);
            this.tsbHabitacionReserva.Name = "tsbHabitacionReserva";
            this.tsbHabitacionReserva.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbHabitacionReserva.Size = new System.Drawing.Size(100, 60);
            this.tsbHabitacionReserva.Text = "HABITACIONES - RESERVAS";
            this.tsbHabitacionReserva.Click += new System.EventHandler(this.tsbHabitacionReserva_Click);
            this.tsbHabitacionReserva.MouseEnter += new System.EventHandler(this.efectoHover_MouseEnter);
            this.tsbHabitacionReserva.MouseLeave += new System.EventHandler(this.efectoHover_MouseLeave);
            // 
            // tsbHousekeeping
            // 
            this.tsbHousekeeping.AutoSize = false;
            this.tsbHousekeeping.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHousekeeping.Image = global::SGH_v0._1.Properties.Resources.Housekeeping_white;
            this.tsbHousekeeping.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHousekeeping.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHousekeeping.Margin = new System.Windows.Forms.Padding(0, 15, 0, 20);
            this.tsbHousekeeping.Name = "tsbHousekeeping";
            this.tsbHousekeeping.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbHousekeeping.Size = new System.Drawing.Size(100, 60);
            this.tsbHousekeeping.Text = "HOUSEKEEPING";
            this.tsbHousekeeping.Click += new System.EventHandler(this.tsbHousekeeping_Click);
            this.tsbHousekeeping.MouseEnter += new System.EventHandler(this.efectoHover_MouseEnter);
            this.tsbHousekeeping.MouseLeave += new System.EventHandler(this.efectoHover_MouseLeave);
            // 
            // tsbCargos
            // 
            this.tsbCargos.AutoSize = false;
            this.tsbCargos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCargos.Image = global::SGH_v0._1.Properties.Resources.Room_Service_white;
            this.tsbCargos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCargos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCargos.Margin = new System.Windows.Forms.Padding(0, 15, 0, 20);
            this.tsbCargos.Name = "tsbCargos";
            this.tsbCargos.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbCargos.Size = new System.Drawing.Size(100, 60);
            this.tsbCargos.Text = "CARGOS - HABITACIÓN";
            this.tsbCargos.Click += new System.EventHandler(this.tsbCargos_Click);
            this.tsbCargos.MouseEnter += new System.EventHandler(this.efectoHover_MouseEnter);
            this.tsbCargos.MouseLeave += new System.EventHandler(this.efectoHover_MouseLeave);
            // 
            // tsbReportes
            // 
            this.tsbReportes.AutoSize = false;
            this.tsbReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReportes.Image = global::SGH_v0._1.Properties.Resources.Business_Report_white;
            this.tsbReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReportes.Margin = new System.Windows.Forms.Padding(0, 15, 0, 20);
            this.tsbReportes.Name = "tsbReportes";
            this.tsbReportes.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbReportes.Size = new System.Drawing.Size(100, 60);
            this.tsbReportes.Text = "REPORTES";
            this.tsbReportes.Click += new System.EventHandler(this.tsbReportes_Click);
            this.tsbReportes.MouseEnter += new System.EventHandler(this.efectoHover_MouseEnter);
            this.tsbReportes.MouseLeave += new System.EventHandler(this.efectoHover_MouseLeave);
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.AutoSize = false;
            this.tsbUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUsuarios.Image = global::SGH_v0._1.Properties.Resources.Add_User_Group_Woman_Man_white;
            this.tsbUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuarios.Margin = new System.Windows.Forms.Padding(0, 15, 0, 20);
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbUsuarios.Size = new System.Drawing.Size(100, 60);
            this.tsbUsuarios.Text = "USUARIOS";
            this.tsbUsuarios.Click += new System.EventHandler(this.tsbUsuarios_Click);
            this.tsbUsuarios.MouseEnter += new System.EventHandler(this.efectoHover_MouseEnter);
            this.tsbUsuarios.MouseLeave += new System.EventHandler(this.efectoHover_MouseLeave);
            // 
            // tsbLogout
            // 
            this.tsbLogout.AutoSize = false;
            this.tsbLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLogout.Image = global::SGH_v0._1.Properties.Resources.Open_Door_white;
            this.tsbLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogout.Margin = new System.Windows.Forms.Padding(0, 15, 0, 20);
            this.tsbLogout.Name = "tsbLogout";
            this.tsbLogout.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbLogout.Size = new System.Drawing.Size(100, 60);
            this.tsbLogout.Text = "CERRAR SESIÓN";
            this.tsbLogout.Click += new System.EventHandler(this.tsbLogout_Click);
            this.tsbLogout.MouseEnter += new System.EventHandler(this.efectoHover_MouseEnter);
            this.tsbLogout.MouseLeave += new System.EventHandler(this.efectoHover_MouseLeave);
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioActivo.Location = new System.Drawing.Point(1060, 36);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(66, 20);
            this.lblUsuarioActivo.TabIndex = 1;
            this.lblUsuarioActivo.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.BtnCompress);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblUsuarioActivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 90);
            this.panel1.TabIndex = 3;
            // 
            // BtnCompress
            // 
            this.BtnCompress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.BtnCompress.BackgroundImage = global::SGH_v0._1.Properties.Resources.Compress_white;
            this.BtnCompress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCompress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCompress.FlatAppearance.BorderSize = 0;
            this.BtnCompress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.BtnCompress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(134)))));
            this.BtnCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompress.Location = new System.Drawing.Point(1290, 25);
            this.BtnCompress.Name = "BtnCompress";
            this.BtnCompress.Size = new System.Drawing.Size(40, 40);
            this.BtnCompress.TabIndex = 6;
            this.BtnCompress.UseVisualStyleBackColor = false;
            this.BtnCompress.Click += new System.EventHandler(this.BtnCompress_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SGH_v0._1.Properties.Resources.LOGOTIPO_FONDO1;
            this.pictureBox2.Location = new System.Drawing.Point(24, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 83);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SGH_v0._1.Properties.Resources.Profile_white;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(1210, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 755);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.ToolStripButton tsbHabitacionReserva;
        private System.Windows.Forms.ToolStripButton tsbHousekeeping;
        private System.Windows.Forms.ToolStripButton tsbCargos;
        private System.Windows.Forms.ToolStripButton tsbReportes;
        private System.Windows.Forms.ToolStripButton tsbUsuarios;
        private System.Windows.Forms.ToolStripButton tsbLogout;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnCompress;
    }
}

