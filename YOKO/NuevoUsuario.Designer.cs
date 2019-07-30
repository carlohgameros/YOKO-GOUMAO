namespace YOKO
{
    partial class NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            this.nombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ingresar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.contra1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.contra2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.correo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.codigo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.BorderColorFocused = System.Drawing.Color.Blue;
            this.nombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nombre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.nombre.BorderThickness = 3;
            this.nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nombre.isPassword = false;
            this.nombre.Location = new System.Drawing.Point(13, 115);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(370, 44);
            this.nombre.TabIndex = 1;
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa los datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cotraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ingresar
            // 
            this.ingresar.ActiveBorderThickness = 1;
            this.ingresar.ActiveCornerRadius = 20;
            this.ingresar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ingresar.ActiveForecolor = System.Drawing.Color.White;
            this.ingresar.ActiveLineColor = System.Drawing.Color.Green;
            this.ingresar.BackColor = System.Drawing.Color.White;
            this.ingresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ingresar.BackgroundImage")));
            this.ingresar.ButtonText = "Crear Usuario";
            this.ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.ForeColor = System.Drawing.Color.Red;
            this.ingresar.IdleBorderThickness = 1;
            this.ingresar.IdleCornerRadius = 20;
            this.ingresar.IdleFillColor = System.Drawing.Color.White;
            this.ingresar.IdleForecolor = System.Drawing.Color.Red;
            this.ingresar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ingresar.Location = new System.Drawing.Point(13, 533);
            this.ingresar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(366, 44);
            this.ingresar.TabIndex = 6;
            this.ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ingresar.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // contra1
            // 
            this.contra1.BorderColorFocused = System.Drawing.Color.Blue;
            this.contra1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contra1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.contra1.BorderThickness = 3;
            this.contra1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contra1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contra1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contra1.isPassword = false;
            this.contra1.Location = new System.Drawing.Point(13, 192);
            this.contra1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contra1.Name = "contra1";
            this.contra1.Size = new System.Drawing.Size(370, 44);
            this.contra1.TabIndex = 7;
            this.contra1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // contra2
            // 
            this.contra2.BorderColorFocused = System.Drawing.Color.Blue;
            this.contra2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contra2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.contra2.BorderThickness = 3;
            this.contra2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contra2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contra2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contra2.isPassword = false;
            this.contra2.Location = new System.Drawing.Point(13, 269);
            this.contra2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contra2.Name = "contra2";
            this.contra2.Size = new System.Drawing.Size(370, 44);
            this.contra2.TabIndex = 8;
            this.contra2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // correo
            // 
            this.correo.BorderColorFocused = System.Drawing.Color.Blue;
            this.correo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.correo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.correo.BorderThickness = 3;
            this.correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.correo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.correo.isPassword = false;
            this.correo.Location = new System.Drawing.Point(13, 346);
            this.correo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(370, 44);
            this.correo.TabIndex = 9;
            this.correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirma contraseña";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // codigo
            // 
            this.codigo.BorderColorFocused = System.Drawing.Color.Blue;
            this.codigo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.codigo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.codigo.BorderThickness = 3;
            this.codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.codigo.isPassword = false;
            this.codigo.Location = new System.Drawing.Point(13, 423);
            this.codigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(370, 44);
            this.codigo.TabIndex = 13;
            this.codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Código de verificación";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Navy;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Enviar Correo";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(17, 479);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Navy;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(150, 51);
            this.bunifuFlatButton1.TabIndex = 16;
            this.bunifuFlatButton1.Text = "Enviar Correo";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Navy;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Verificar";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(233, 479);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Navy;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(150, 51);
            this.bunifuFlatButton2.TabIndex = 17;
            this.bunifuFlatButton2.Text = "Verificar";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 604);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.contra2);
            this.Controls.Add(this.contra1);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoUsuario";
            this.Text = "NuevoUsuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 ingresar;
        private Bunifu.Framework.UI.BunifuMetroTextbox contra1;
        private Bunifu.Framework.UI.BunifuMetroTextbox contra2;
        private Bunifu.Framework.UI.BunifuMetroTextbox correo;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox codigo;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}