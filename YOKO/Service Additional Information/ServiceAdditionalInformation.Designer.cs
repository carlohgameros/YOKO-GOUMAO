namespace YOKO.Service_Additional_Information
{
    partial class ServiceAdditionalInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceAdditionalInformation));
            this.ObservationsTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.knifeTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.navigationBar1 = new YOKO.NavigationBar.NavigationBar();
            this.saveButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.upButton = new System.Windows.Forms.Label();
            this.downButton = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ObservationsTextBox
            // 
            this.ObservationsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ObservationsTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObservationsTextBox.ForeColor = System.Drawing.Color.Black;
            this.ObservationsTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.ObservationsTextBox.HintText = "";
            this.ObservationsTextBox.isPassword = false;
            this.ObservationsTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.ObservationsTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.ObservationsTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.ObservationsTextBox.LineThickness = 6;
            this.ObservationsTextBox.Location = new System.Drawing.Point(16, 96);
            this.ObservationsTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ObservationsTextBox.Name = "ObservationsTextBox";
            this.ObservationsTextBox.Size = new System.Drawing.Size(696, 79);
            this.ObservationsTextBox.TabIndex = 2;
            this.ObservationsTextBox.Text = "Observaciones";
            this.ObservationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // knifeTextBox
            // 
            this.knifeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.knifeTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knifeTextBox.ForeColor = System.Drawing.Color.Black;
            this.knifeTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.knifeTextBox.HintText = "";
            this.knifeTextBox.isPassword = false;
            this.knifeTextBox.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.knifeTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.knifeTextBox.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.knifeTextBox.LineThickness = 6;
            this.knifeTextBox.Location = new System.Drawing.Point(16, 195);
            this.knifeTextBox.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.knifeTextBox.Name = "knifeTextBox";
            this.knifeTextBox.Size = new System.Drawing.Size(174, 73);
            this.knifeTextBox.TabIndex = 3;
            this.knifeTextBox.Text = "Navaja";
            this.knifeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.knifeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.knifeTextBox_KeyDown);
            // 
            // navigationBar1
            // 
            this.navigationBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(975, 60);
            this.navigationBar1.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.SeaGreen;
            this.saveButton.color = System.Drawing.Color.SeaGreen;
            this.saveButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImagePosition = 20;
            this.saveButton.ImageZoom = 50;
            this.saveButton.LabelPosition = 41;
            this.saveButton.LabelText = "Guardar";
            this.saveButton.Location = new System.Drawing.Point(0, 0);
            this.saveButton.Margin = new System.Windows.Forms.Padding(6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(219, 246);
            this.saveButton.TabIndex = 5;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 306);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(975, 11);
            this.bunifuGradientPanel1.TabIndex = 91;
            // 
            // upButton
            // 
            this.upButton.AutoSize = true;
            this.upButton.BackColor = System.Drawing.Color.Transparent;
            this.upButton.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.upButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.upButton.Location = new System.Drawing.Point(198, 200);
            this.upButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(29, 29);
            this.upButton.TabIndex = 93;
            this.upButton.Text = "▲";
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.AutoSize = true;
            this.downButton.BackColor = System.Drawing.Color.Transparent;
            this.downButton.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.downButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.downButton.Location = new System.Drawing.Point(198, 231);
            this.downButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(29, 29);
            this.downButton.TabIndex = 92;
            this.downButton.Text = "▼";
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(756, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 246);
            this.panel1.TabIndex = 94;
            // 
            // ServiceAdditionalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(975, 317);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.knifeTextBox);
            this.Controls.Add(this.ObservationsTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceAdditionalInformation";
            this.Text = "ServiceAdditionalInformation";
            this.Load += new System.EventHandler(this.ServiceAdditionalInformation_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox ObservationsTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox knifeTextBox;
        private NavigationBar.NavigationBar navigationBar1;
        private Bunifu.Framework.UI.BunifuTileButton saveButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label upButton;
        private System.Windows.Forms.Label downButton;
        private System.Windows.Forms.Panel panel1;
    }
}