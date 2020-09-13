namespace YOKO
{
    partial class Configuraciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuraciones));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ivaUpButton = new System.Windows.Forms.Label();
            this.ivaDownButton = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ivaField = new MetroFramework.Controls.MetroTextBox();
            this.dolarUpButton = new System.Windows.Forms.Label();
            this.dolarDownButton = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dolarField = new MetroFramework.Controls.MetroTextBox();
            this.updateDolarCB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.useIVACB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label6 = new System.Windows.Forms.Label();
            this.showDolarCB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.navigationBar1 = new YOKO.NavigationBar.NavigationBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 546);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(839, 12);
            this.bunifuGradientPanel1.TabIndex = 23;
            // 
            // ivaUpButton
            // 
            this.ivaUpButton.AutoSize = true;
            this.ivaUpButton.BackColor = System.Drawing.Color.Transparent;
            this.ivaUpButton.Cursor = System.Windows.Forms.Cursors.No;
            this.ivaUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ivaUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ivaUpButton.Location = new System.Drawing.Point(394, 97);
            this.ivaUpButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ivaUpButton.Name = "ivaUpButton";
            this.ivaUpButton.Size = new System.Drawing.Size(29, 29);
            this.ivaUpButton.TabIndex = 27;
            this.ivaUpButton.Text = "▲";
            this.ivaUpButton.Click += new System.EventHandler(this.label9_Click);
            // 
            // ivaDownButton
            // 
            this.ivaDownButton.AutoSize = true;
            this.ivaDownButton.BackColor = System.Drawing.Color.Transparent;
            this.ivaDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ivaDownButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ivaDownButton.Location = new System.Drawing.Point(394, 128);
            this.ivaDownButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ivaDownButton.Name = "ivaDownButton";
            this.ivaDownButton.Size = new System.Drawing.Size(29, 29);
            this.ivaDownButton.TabIndex = 26;
            this.ivaDownButton.Text = "▼";
            this.ivaDownButton.Click += new System.EventHandler(this.ivaDownButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 41);
            this.label4.TabIndex = 25;
            this.label4.Text = "I.V.A.";
            // 
            // ivaField
            // 
            // 
            // 
            // 
            this.ivaField.CustomButton.Image = null;
            this.ivaField.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.ivaField.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ivaField.CustomButton.Name = "";
            this.ivaField.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.ivaField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ivaField.CustomButton.TabIndex = 1;
            this.ivaField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ivaField.CustomButton.UseSelectable = true;
            this.ivaField.CustomButton.Visible = false;
            this.ivaField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ivaField.Lines = new string[] {
        " 0.00"};
            this.ivaField.Location = new System.Drawing.Point(182, 108);
            this.ivaField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ivaField.MaxLength = 32767;
            this.ivaField.Name = "ivaField";
            this.ivaField.PasswordChar = '\0';
            this.ivaField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ivaField.SelectedText = "";
            this.ivaField.SelectionLength = 0;
            this.ivaField.SelectionStart = 0;
            this.ivaField.ShortcutsEnabled = true;
            this.ivaField.Size = new System.Drawing.Size(209, 45);
            this.ivaField.TabIndex = 24;
            this.ivaField.Text = " 0.00";
            this.ivaField.UseSelectable = true;
            this.ivaField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ivaField.WaterMarkFont = new System.Drawing.Font("Microsoft JhengHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dolarUpButton
            // 
            this.dolarUpButton.AutoSize = true;
            this.dolarUpButton.BackColor = System.Drawing.Color.Transparent;
            this.dolarUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolarUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dolarUpButton.Location = new System.Drawing.Point(394, 254);
            this.dolarUpButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dolarUpButton.Name = "dolarUpButton";
            this.dolarUpButton.Size = new System.Drawing.Size(29, 29);
            this.dolarUpButton.TabIndex = 31;
            this.dolarUpButton.Text = "▲";
            this.dolarUpButton.Click += new System.EventHandler(this.dolarUpButton_Click);
            // 
            // dolarDownButton
            // 
            this.dolarDownButton.AutoSize = true;
            this.dolarDownButton.BackColor = System.Drawing.Color.Transparent;
            this.dolarDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolarDownButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dolarDownButton.Location = new System.Drawing.Point(394, 286);
            this.dolarDownButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dolarDownButton.Name = "dolarDownButton";
            this.dolarDownButton.Size = new System.Drawing.Size(29, 29);
            this.dolarDownButton.TabIndex = 30;
            this.dolarDownButton.Text = "▼";
            this.dolarDownButton.Click += new System.EventHandler(this.dolarDownButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 41);
            this.label5.TabIndex = 29;
            this.label5.Text = "DOLAR";
            // 
            // dolarField
            // 
            // 
            // 
            // 
            this.dolarField.CustomButton.Image = null;
            this.dolarField.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.dolarField.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dolarField.CustomButton.Name = "";
            this.dolarField.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.dolarField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dolarField.CustomButton.TabIndex = 1;
            this.dolarField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dolarField.CustomButton.UseSelectable = true;
            this.dolarField.CustomButton.Visible = false;
            this.dolarField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.dolarField.Lines = new string[] {
        " 0.00"};
            this.dolarField.Location = new System.Drawing.Point(182, 266);
            this.dolarField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dolarField.MaxLength = 32767;
            this.dolarField.Name = "dolarField";
            this.dolarField.PasswordChar = '\0';
            this.dolarField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dolarField.SelectedText = "";
            this.dolarField.SelectionLength = 0;
            this.dolarField.SelectionStart = 0;
            this.dolarField.ShortcutsEnabled = true;
            this.dolarField.Size = new System.Drawing.Size(209, 45);
            this.dolarField.TabIndex = 28;
            this.dolarField.Text = " 0.00";
            this.dolarField.UseSelectable = true;
            this.dolarField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dolarField.WaterMarkFont = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // updateDolarCB
            // 
            this.updateDolarCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateDolarCB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.updateDolarCB.Checked = true;
            this.updateDolarCB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateDolarCB.ForeColor = System.Drawing.Color.White;
            this.updateDolarCB.Location = new System.Drawing.Point(63, 333);
            this.updateDolarCB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateDolarCB.Name = "updateDolarCB";
            this.updateDolarCB.Size = new System.Drawing.Size(20, 20);
            this.updateDolarCB.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 320);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 41);
            this.label1.TabIndex = 33;
            this.label1.Text = "Descargar automaticamente el precio del dolar.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 41);
            this.label3.TabIndex = 35;
            this.label3.Text = "Incluir I.V.A. en los precios.";
            // 
            // useIVACB
            // 
            this.useIVACB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.useIVACB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.useIVACB.Checked = true;
            this.useIVACB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.useIVACB.ForeColor = System.Drawing.Color.White;
            this.useIVACB.Location = new System.Drawing.Point(62, 184);
            this.useIVACB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.useIVACB.Name = "useIVACB";
            this.useIVACB.Size = new System.Drawing.Size(20, 20);
            this.useIVACB.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(581, 41);
            this.label6.TabIndex = 92;
            this.label6.Text = "Mostrar notificacion en precio del Dolar";
            // 
            // showDolarCB
            // 
            this.showDolarCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showDolarCB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.showDolarCB.Checked = true;
            this.showDolarCB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showDolarCB.ForeColor = System.Drawing.Color.White;
            this.showDolarCB.Location = new System.Drawing.Point(62, 377);
            this.showDolarCB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.showDolarCB.Name = "showDolarCB";
            this.showDolarCB.Size = new System.Drawing.Size(20, 20);
            this.showDolarCB.TabIndex = 91;
            // 
            // navigationBar1
            // 
            this.navigationBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(839, 60);
            this.navigationBar1.TabIndex = 95;
            this.navigationBar1.Load += new System.EventHandler(this.navigationBar1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 10);
            this.panel1.TabIndex = 96;
            // 
            // saveButton
            // 
            this.saveButton.ActiveBorderThickness = 1;
            this.saveButton.ActiveCornerRadius = 20;
            this.saveButton.ActiveFillColor = System.Drawing.Color.White;
            this.saveButton.ActiveForecolor = System.Drawing.Color.Black;
            this.saveButton.ActiveLineColor = System.Drawing.Color.Black;
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.ButtonText = "Guardar";
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.IdleBorderThickness = 1;
            this.saveButton.IdleCornerRadius = 20;
            this.saveButton.IdleFillColor = System.Drawing.Color.Black;
            this.saveButton.IdleForecolor = System.Drawing.Color.White;
            this.saveButton.IdleLineColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(277, 439);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(284, 66);
            this.saveButton.TabIndex = 97;
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Configuraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(839, 558);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showDolarCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.useIVACB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateDolarCB);
            this.Controls.Add(this.dolarUpButton);
            this.Controls.Add(this.dolarDownButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dolarField);
            this.Controls.Add(this.ivaUpButton);
            this.Controls.Add(this.ivaDownButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ivaField);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Configuraciones";
            this.RightToLeftLayout = true;
            this.Text = "Configuraciones";
            this.Load += new System.EventHandler(this.Configuraciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label ivaUpButton;
        private System.Windows.Forms.Label ivaDownButton;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox ivaField;
        private System.Windows.Forms.Label dolarUpButton;
        private System.Windows.Forms.Label dolarDownButton;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox dolarField;
        private Bunifu.Framework.UI.BunifuCheckbox updateDolarCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox useIVACB;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCheckbox showDolarCB;
        private NavigationBar.NavigationBar navigationBar1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 saveButton;
    }
}