namespace YOKO
{
    partial class changeButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeButton));
            this.mailsApprovedDataGrid = new System.Windows.Forms.DataGridView();
            this.mailsDeniedDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChange = new Bunifu.Framework.UI.BunifuThinButton2();
            this.navigationBar1 = new YOKO.NavigationBar.NavigationBar();
            ((System.ComponentModel.ISupportInitialize)(this.mailsApprovedDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsDeniedDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mailsApprovedDataGrid
            // 
            this.mailsApprovedDataGrid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.mailsApprovedDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailsApprovedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mailsApprovedDataGrid.Location = new System.Drawing.Point(12, 123);
            this.mailsApprovedDataGrid.Name = "mailsApprovedDataGrid";
            this.mailsApprovedDataGrid.RowTemplate.Height = 28;
            this.mailsApprovedDataGrid.Size = new System.Drawing.Size(345, 654);
            this.mailsApprovedDataGrid.TabIndex = 65;
            this.mailsApprovedDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mailsApprovedDataGrid_CellContentClick);
            this.mailsApprovedDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.mailsApprovedDataGrid_RowsAdded);
            this.mailsApprovedDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.mailsApprovedDataGrid_RowsRemoved);
            // 
            // mailsDeniedDataGrid
            // 
            this.mailsDeniedDataGrid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.mailsDeniedDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailsDeniedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mailsDeniedDataGrid.Location = new System.Drawing.Point(363, 123);
            this.mailsDeniedDataGrid.Name = "mailsDeniedDataGrid";
            this.mailsDeniedDataGrid.RowTemplate.Height = 28;
            this.mailsDeniedDataGrid.Size = new System.Drawing.Size(345, 654);
            this.mailsDeniedDataGrid.TabIndex = 66;
            this.mailsDeniedDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mailsDeniedDataGrid_CellContentClick);
            this.mailsDeniedDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.mailsDeniedDataGrid_RowsAdded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(5, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 41);
            this.label1.TabIndex = 67;
            this.label1.Text = "Subscritores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(356, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 41);
            this.label2.TabIndex = 68;
            this.label2.Text = "No Subscritos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(363, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 654);
            this.panel1.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 654);
            this.label4.TabIndex = 72;
            this.label4.Text = "Sin Datos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 654);
            this.panel2.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 654);
            this.label3.TabIndex = 71;
            this.label3.Text = "Sin Subscriptores";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonChange
            // 
            this.buttonChange.ActiveBorderThickness = 1;
            this.buttonChange.ActiveCornerRadius = 20;
            this.buttonChange.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.buttonChange.ActiveForecolor = System.Drawing.Color.White;
            this.buttonChange.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.buttonChange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChange.BackgroundImage")));
            this.buttonChange.ButtonText = "Selecciona un correo para modificar";
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonChange.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonChange.IdleBorderThickness = 1;
            this.buttonChange.IdleCornerRadius = 20;
            this.buttonChange.IdleFillColor = System.Drawing.Color.White;
            this.buttonChange.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.buttonChange.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.buttonChange.Location = new System.Drawing.Point(12, 784);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(696, 56);
            this.buttonChange.TabIndex = 93;
            this.buttonChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // navigationBar1
            // 
            this.navigationBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(1606, 60);
            this.navigationBar1.TabIndex = 64;
            // 
            // changeButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1606, 869);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailsDeniedDataGrid);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mailsApprovedDataGrid);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "changeButton";
            this.Text = "Correos";
            this.Load += new System.EventHandler(this.CreateWebMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mailsApprovedDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsDeniedDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavigationBar.NavigationBar navigationBar1;
        private System.Windows.Forms.DataGridView mailsApprovedDataGrid;
        private System.Windows.Forms.DataGridView mailsDeniedDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 AgregarUsuario;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonChange;
    }
}