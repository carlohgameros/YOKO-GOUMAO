namespace YOKO.NavigationBar
{
    partial class NavigationBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationBar));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.hiddeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.navigationTitle = new System.Windows.Forms.Label();
            this.backButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiddeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.navigationPanel.AutoSize = true;
            this.navigationPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.navigationPanel.BackColor = System.Drawing.Color.Transparent;
            this.navigationPanel.Controls.Add(this.hiddeButton);
            this.navigationPanel.Controls.Add(this.bunifuImageButton1);
            this.navigationPanel.Controls.Add(this.navigationTitle);
            this.navigationPanel.Controls.Add(this.backButton);
            this.navigationPanel.Controls.Add(this.closeButton);
            this.navigationPanel.Controls.Add(this.bunifuImageButton2);
            this.navigationPanel.Controls.Add(this.bunifuImageButton3);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(1371, 60);
            this.navigationPanel.TabIndex = 1;
            this.navigationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navigationPanel_Paint);
            this.navigationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navigationPanel_MouseDown);
            this.navigationPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navigationPanel_MouseMove);
            this.navigationPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navigationPanel_MouseUp);
            // 
            // hiddeButton
            // 
            this.hiddeButton.BackColor = System.Drawing.Color.Transparent;
            this.hiddeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.hiddeButton.Image = ((System.Drawing.Image)(resources.GetObject("hiddeButton.Image")));
            this.hiddeButton.ImageActive = null;
            this.hiddeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hiddeButton.Location = new System.Drawing.Point(1247, 0);
            this.hiddeButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.hiddeButton.Name = "hiddeButton";
            this.hiddeButton.Size = new System.Drawing.Size(52, 60);
            this.hiddeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hiddeButton.TabIndex = 7;
            this.hiddeButton.TabStop = false;
            this.hiddeButton.Zoom = 10;
            this.hiddeButton.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1299, 0);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(12, 60);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 13;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // navigationTitle
            // 
            this.navigationTitle.AutoSize = true;
            this.navigationTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationTitle.Font = new System.Drawing.Font("Microsoft JhengHei Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationTitle.ForeColor = System.Drawing.Color.Gray;
            this.navigationTitle.Location = new System.Drawing.Point(64, 0);
            this.navigationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.navigationTitle.Name = "navigationTitle";
            this.navigationTitle.Size = new System.Drawing.Size(106, 55);
            this.navigationTitle.TabIndex = 12;
            this.navigationTitle.Text = "Title";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageActive = null;
            this.backButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backButton.Location = new System.Drawing.Point(12, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(52, 60);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 8;
            this.backButton.TabStop = false;
            this.backButton.Zoom = 10;
            this.backButton.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeButton.Location = new System.Drawing.Point(1311, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(48, 60);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 6;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1359, 0);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(12, 60);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 14;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton3.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(12, 60);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 15;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // NavigationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationPanel);
            this.Name = "NavigationBar";
            this.Size = new System.Drawing.Size(1371, 60);
            this.Load += new System.EventHandler(this.NavigationBar_Load);
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiddeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Label navigationTitle;
        private Bunifu.Framework.UI.BunifuImageButton backButton;
        private Bunifu.Framework.UI.BunifuImageButton hiddeButton;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
    }
}
