namespace YOKO
{
    partial class ServicesWatcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesWatcher));
            this.servicesDataGrid = new System.Windows.Forms.DataGridView();
            this.navigationBar1 = new YOKO.NavigationBar.NavigationBar();
            this.finishService = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pauseService = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // servicesDataGrid
            // 
            this.servicesDataGrid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.servicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGrid.Location = new System.Drawing.Point(12, 66);
            this.servicesDataGrid.Name = "servicesDataGrid";
            this.servicesDataGrid.RowTemplate.Height = 28;
            this.servicesDataGrid.Size = new System.Drawing.Size(779, 483);
            this.servicesDataGrid.TabIndex = 0;
            // 
            // navigationBar1
            // 
            this.navigationBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(1113, 60);
            this.navigationBar1.TabIndex = 1;
            this.navigationBar1.Load += new System.EventHandler(this.navigationBar1_Load);
            // 
            // finishService
            // 
            this.finishService.ActiveBorderThickness = 1;
            this.finishService.ActiveCornerRadius = 20;
            this.finishService.ActiveFillColor = System.Drawing.Color.White;
            this.finishService.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.finishService.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.finishService.BackColor = System.Drawing.Color.White;
            this.finishService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finishService.BackgroundImage")));
            this.finishService.ButtonText = "Terminar Servicio";
            this.finishService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishService.Enabled = false;
            this.finishService.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.finishService.ForeColor = System.Drawing.Color.SeaGreen;
            this.finishService.IdleBorderThickness = 1;
            this.finishService.IdleCornerRadius = 20;
            this.finishService.IdleFillColor = System.Drawing.Color.White;
            this.finishService.IdleForecolor = System.Drawing.Color.Gray;
            this.finishService.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.finishService.Location = new System.Drawing.Point(802, 66);
            this.finishService.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.finishService.Name = "finishService";
            this.finishService.Size = new System.Drawing.Size(302, 56);
            this.finishService.TabIndex = 23;
            this.finishService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pauseService
            // 
            this.pauseService.ActiveBorderThickness = 1;
            this.pauseService.ActiveCornerRadius = 20;
            this.pauseService.ActiveFillColor = System.Drawing.Color.White;
            this.pauseService.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.pauseService.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.pauseService.BackColor = System.Drawing.Color.White;
            this.pauseService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseService.BackgroundImage")));
            this.pauseService.ButtonText = "Pausar Servicio";
            this.pauseService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseService.Enabled = false;
            this.pauseService.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.pauseService.ForeColor = System.Drawing.Color.SeaGreen;
            this.pauseService.IdleBorderThickness = 1;
            this.pauseService.IdleCornerRadius = 20;
            this.pauseService.IdleFillColor = System.Drawing.Color.White;
            this.pauseService.IdleForecolor = System.Drawing.Color.Gray;
            this.pauseService.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.pauseService.Location = new System.Drawing.Point(802, 136);
            this.pauseService.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pauseService.Name = "pauseService";
            this.pauseService.Size = new System.Drawing.Size(302, 56);
            this.pauseService.TabIndex = 24;
            this.pauseService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Reanudar Servicio";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Enabled = false;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(802, 206);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(302, 56);
            this.bunifuThinButton21.TabIndex = 25;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServicesWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 564);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.pauseService);
            this.Controls.Add(this.finishService);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.servicesDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServicesWatcher";
            this.Text = "Servicios Activos";
            this.Load += new System.EventHandler(this.ServicesWatcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView servicesDataGrid;
        private NavigationBar.NavigationBar navigationBar1;
        private Bunifu.Framework.UI.BunifuThinButton2 finishService;
        private Bunifu.Framework.UI.BunifuThinButton2 pauseService;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}