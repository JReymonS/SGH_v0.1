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
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.AutoSize = false;
            this.tsMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            this.tsbHome.Size = new System.Drawing.Size(85, 50);
            this.tsbHome.Text = "HOME";
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
            this.tsbHabitacionReserva.Size = new System.Drawing.Size(85, 50);
            this.tsbHabitacionReserva.Text = "HABITACIONES - RESERVAS";
            this.tsbHabitacionReserva.Click += new System.EventHandler(this.tsbHabitacionReserva_Click);
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
            this.tsbHousekeeping.Size = new System.Drawing.Size(85, 50);
            this.tsbHousekeeping.Text = "HOUSEKEEPING";
            this.tsbHousekeeping.Click += new System.EventHandler(this.tsbHousekeeping_Click);
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
            this.tsbCargos.Size = new System.Drawing.Size(85, 50);
            this.tsbCargos.Text = "CARGOS - HABITACIÓN";
            this.tsbCargos.Click += new System.EventHandler(this.tsbCargos_Click);
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
            this.tsbReportes.Size = new System.Drawing.Size(85, 50);
            this.tsbReportes.Text = "REPORTES";
            this.tsbReportes.Click += new System.EventHandler(this.tsbReportes_Click);
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
            this.tsbUsuarios.Size = new System.Drawing.Size(85, 50);
            this.tsbUsuarios.Text = "USUARIOS";
            this.tsbUsuarios.Click += new System.EventHandler(this.tsbUsuarios_Click);
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
            this.tsbLogout.Size = new System.Drawing.Size(85, 50);
            this.tsbLogout.Text = "CERRAR SESIÓN";
            this.tsbLogout.Click += new System.EventHandler(this.tsbLogout_Click);
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.Location = new System.Drawing.Point(194, 52);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(54, 13);
            this.lblUsuarioActivo.TabIndex = 1;
            this.lblUsuarioActivo.Text = "NOMBRE";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 755);
            this.Controls.Add(this.lblUsuarioActivo);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

