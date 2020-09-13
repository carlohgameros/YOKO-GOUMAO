namespace YOKO
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.YOKKO = new System.Windows.Forms.NotifyIcon(this.components);
            this.navigationBar1 = new YOKO.NavigationBar.NavigationBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contra = new Bunifu.Framework.UI.BunifuTextbox();
            this.usuario = new Bunifu.Framework.UI.BunifuTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.crear = new System.Windows.Forms.Label();
            this.iniciar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YOKO.Properties.Resources.WhatsApp_Image_2019_03_09_at_13_50_01;
            this.pictureBox1.Location = new System.Drawing.Point(63, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // YOKKO
            // 
            this.YOKKO.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.YOKKO.BalloonTipText = "111";
            this.YOKKO.BalloonTipTitle = "222";
            this.YOKKO.Icon = ((System.Drawing.Icon)(resources.GetObject("YOKKO.Icon")));
            this.YOKKO.Text = "333";
            this.YOKKO.Visible = true;
            // 
            // navigationBar1
            // 
            this.navigationBar1.Location = new System.Drawing.Point(-639, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(1270, 60);
            this.navigationBar1.TabIndex = 13;
            this.navigationBar1.Load += new System.EventHandler(this.navigationBar1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(69, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 27);
            this.label2.TabIndex = 90;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(69, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 91;
            this.label3.Text = "Contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.contra);
            this.panel1.Controls.Add(this.usuario);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.crear);
            this.panel1.Controls.Add(this.iniciar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.navigationBar1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(638, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 615);
            this.panel1.TabIndex = 14;
            // 
            // contra
            // 
            this.contra.BackColor = System.Drawing.Color.White;
            this.contra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contra.BackgroundImage")));
            this.contra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contra.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra.ForeColor = System.Drawing.Color.Black;
            this.contra.Icon = ((System.Drawing.Image)(resources.GetObject("contra.Icon")));
            this.contra.Location = new System.Drawing.Point(74, 319);
            this.contra.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(520, 81);
            this.contra.TabIndex = 96;
            this.contra.text = "";
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.White;
            this.usuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usuario.BackgroundImage")));
            this.usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usuario.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.ForeColor = System.Drawing.Color.Black;
            this.usuario.Icon = ((System.Drawing.Image)(resources.GetObject("usuario.Icon")));
            this.usuario.Location = new System.Drawing.Point(74, 188);
            this.usuario.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(520, 81);
            this.usuario.TabIndex = 15;
            this.usuario.text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 46);
            this.label7.TabIndex = 16;
            this.label7.Text = "YOKKO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(334, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 46);
            this.label6.TabIndex = 94;
            this.label6.Text = "GOUMAO";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(202, 434);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 94;
            this.pictureBox4.TabStop = false;
            // 
            // crear
            // 
            this.crear.AutoSize = true;
            this.crear.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.crear.Location = new System.Drawing.Point(255, 491);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(153, 36);
            this.crear.TabIndex = 93;
            this.crear.Text = "Crear Perfil";
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // iniciar
            // 
            this.iniciar.AutoSize = true;
            this.iniciar.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.iniciar.Location = new System.Drawing.Point(238, 437);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(231, 46);
            this.iniciar.TabIndex = 92;
            this.iniciar.Text = "Iniciar Sesión";
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(290, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 71);
            this.label4.TabIndex = 95;
            this.label4.Text = "|";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1276, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon YOKKO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private NavigationBar.NavigationBar navigationBar1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label crear;
        private System.Windows.Forms.Label iniciar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuTextbox usuario;
        private Bunifu.Framework.UI.BunifuTextbox contra;
    }
}