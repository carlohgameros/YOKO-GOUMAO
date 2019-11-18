namespace YOKO
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb1tipo = new MetroFramework.Controls.MetroComboBox();
            this.tblCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt1Nombre = new MetroFramework.Controls.MetroTextBox();
            this.txt2Precio = new MetroFramework.Controls.MetroTextBox();
            this.txt3Stock = new MetroFramework.Controls.MetroTextBox();
            this.cb2um = new MetroFramework.Controls.MetroComboBox();
            this.tblUMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb3r = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRestaurar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.navigationBar1 = new YOKO.NavigationBar.NavigationBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Existencia,
            this.Fecha});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(599, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(768, 435);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Existencia
            // 
            this.Existencia.DataPropertyName = "Existencia";
            this.Existencia.HeaderText = "Stock";
            this.Existencia.Name = "Existencia";
            this.Existencia.Width = 50;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FReg";
            this.Fecha.HeaderText = "FReg";
            this.Fecha.Name = "Fecha";
            // 
            // tblProductosBindingSource
            // 
            this.tblProductosBindingSource.DataMember = "tblProductos";
            // 
            // cb1tipo
            // 
            this.cb1tipo.ForeColor = System.Drawing.Color.Red;
            this.cb1tipo.FormattingEnabled = true;
            this.cb1tipo.ItemHeight = 23;
            this.cb1tipo.Items.AddRange(new object[] {
            "SERVICIO",
            "PRODUCTO"});
            this.cb1tipo.Location = new System.Drawing.Point(175, 85);
            this.cb1tipo.Name = "cb1tipo";
            this.cb1tipo.Size = new System.Drawing.Size(356, 29);
            this.cb1tipo.TabIndex = 2;
            this.cb1tipo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cb1tipo.UseSelectable = true;
            this.cb1tipo.SelectedIndexChanged += new System.EventHandler(this.cb1tipo_SelectedIndexChanged);
            // 
            // tblCategoriaBindingSource
            // 
            this.tblCategoriaBindingSource.DataMember = "tblCategoria";
            // 
            // txt1Nombre
            // 
            // 
            // 
            // 
            this.txt1Nombre.CustomButton.Image = null;
            this.txt1Nombre.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txt1Nombre.CustomButton.Name = "";
            this.txt1Nombre.CustomButton.Size = new System.Drawing.Size(18, 18);
            this.txt1Nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt1Nombre.CustomButton.TabIndex = 1;
            this.txt1Nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt1Nombre.CustomButton.UseSelectable = true;
            this.txt1Nombre.CustomButton.Visible = false;
            this.txt1Nombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt1Nombre.Lines = new string[0];
            this.txt1Nombre.Location = new System.Drawing.Point(175, 123);
            this.txt1Nombre.MaxLength = 32767;
            this.txt1Nombre.Name = "txt1Nombre";
            this.txt1Nombre.PasswordChar = '\0';
            this.txt1Nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt1Nombre.SelectedText = "";
            this.txt1Nombre.SelectionLength = 0;
            this.txt1Nombre.SelectionStart = 0;
            this.txt1Nombre.ShortcutsEnabled = true;
            this.txt1Nombre.Size = new System.Drawing.Size(356, 29);
            this.txt1Nombre.TabIndex = 5;
            this.txt1Nombre.UseSelectable = true;
            this.txt1Nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt1Nombre.WaterMarkFont = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1Nombre.Click += new System.EventHandler(this.txt1Nombre_Click);
            // 
            // txt2Precio
            // 
            // 
            // 
            // 
            this.txt2Precio.CustomButton.Image = null;
            this.txt2Precio.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txt2Precio.CustomButton.Name = "";
            this.txt2Precio.CustomButton.Size = new System.Drawing.Size(18, 18);
            this.txt2Precio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt2Precio.CustomButton.TabIndex = 1;
            this.txt2Precio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt2Precio.CustomButton.UseSelectable = true;
            this.txt2Precio.CustomButton.Visible = false;
            this.txt2Precio.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt2Precio.Lines = new string[] {
        " 0.00"};
            this.txt2Precio.Location = new System.Drawing.Point(175, 161);
            this.txt2Precio.MaxLength = 32767;
            this.txt2Precio.Name = "txt2Precio";
            this.txt2Precio.PasswordChar = '\0';
            this.txt2Precio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt2Precio.SelectedText = "";
            this.txt2Precio.SelectionLength = 0;
            this.txt2Precio.SelectionStart = 0;
            this.txt2Precio.ShortcutsEnabled = true;
            this.txt2Precio.Size = new System.Drawing.Size(356, 29);
            this.txt2Precio.TabIndex = 6;
            this.txt2Precio.Text = " 0.00";
            this.txt2Precio.UseSelectable = true;
            this.txt2Precio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt2Precio.WaterMarkFont = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2Precio.Click += new System.EventHandler(this.txt2Precio_Click);
            this.txt2Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2Precio_KeyPress);
            this.txt2Precio.Leave += new System.EventHandler(this.txt2Precio_Leave);
            // 
            // txt3Stock
            // 
            // 
            // 
            // 
            this.txt3Stock.CustomButton.Image = null;
            this.txt3Stock.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txt3Stock.CustomButton.Name = "";
            this.txt3Stock.CustomButton.Size = new System.Drawing.Size(18, 18);
            this.txt3Stock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt3Stock.CustomButton.TabIndex = 1;
            this.txt3Stock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt3Stock.CustomButton.UseSelectable = true;
            this.txt3Stock.CustomButton.Visible = false;
            this.txt3Stock.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt3Stock.Lines = new string[] {
        " "};
            this.txt3Stock.Location = new System.Drawing.Point(175, 237);
            this.txt3Stock.MaxLength = 32767;
            this.txt3Stock.Name = "txt3Stock";
            this.txt3Stock.PasswordChar = '\0';
            this.txt3Stock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt3Stock.SelectedText = "";
            this.txt3Stock.SelectionLength = 0;
            this.txt3Stock.SelectionStart = 0;
            this.txt3Stock.ShortcutsEnabled = true;
            this.txt3Stock.Size = new System.Drawing.Size(356, 29);
            this.txt3Stock.TabIndex = 7;
            this.txt3Stock.Text = " ";
            this.txt3Stock.UseSelectable = true;
            this.txt3Stock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt3Stock.WaterMarkFont = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cb2um
            // 
            this.cb2um.DisplayMember = "Categoria";
            this.cb2um.ForeColor = System.Drawing.Color.Red;
            this.cb2um.FormattingEnabled = true;
            this.cb2um.ItemHeight = 23;
            this.cb2um.Items.AddRange(new object[] {
            "PIEZA",
            "CAJA",
            "NO APLICA"});
            this.cb2um.Location = new System.Drawing.Point(175, 199);
            this.cb2um.Name = "cb2um";
            this.cb2um.Size = new System.Drawing.Size(356, 29);
            this.cb2um.TabIndex = 8;
            this.cb2um.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cb2um.UseSelectable = true;
            this.cb2um.ValueMember = "Categoria";
            // 
            // tblUMBindingSource
            // 
            this.tblUMBindingSource.DataMember = "tblUM";
            // 
            // cb3r
            // 
            this.cb3r.ForeColor = System.Drawing.Color.Red;
            this.cb3r.FormattingEnabled = true;
            this.cb3r.ItemHeight = 23;
            this.cb3r.Items.AddRange(new object[] {
            "Agregar Responsiva",
            "No agregar Responsiva"});
            this.cb3r.Location = new System.Drawing.Point(176, 274);
            this.cb3r.Name = "cb3r";
            this.cb3r.Size = new System.Drawing.Size(356, 29);
            this.cb3r.TabIndex = 9;
            this.cb3r.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cb3r.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "UM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Responsiva";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.BackColor = System.Drawing.Color.Transparent;
            this.downLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.downLabel.Location = new System.Drawing.Point(537, 176);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(19, 20);
            this.downLabel.TabIndex = 17;
            this.downLabel.Text = "▼";
            this.downLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label9.Location = new System.Drawing.Point(537, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "▲";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ActiveBorderThickness = 1;
            this.btnAgregar.ActiveCornerRadius = 20;
            this.btnAgregar.ActiveFillColor = System.Drawing.Color.White;
            this.btnAgregar.ActiveForecolor = System.Drawing.Color.Purple;
            this.btnAgregar.ActiveLineColor = System.Drawing.Color.Purple;
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.IdleBorderThickness = 1;
            this.btnAgregar.IdleCornerRadius = 20;
            this.btnAgregar.IdleFillColor = System.Drawing.Color.White;
            this.btnAgregar.IdleForecolor = System.Drawing.Color.Gray;
            this.btnAgregar.IdleLineColor = System.Drawing.Color.Purple;
            this.btnAgregar.Location = new System.Drawing.Point(111, 339);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 51);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.ActiveBorderThickness = 1;
            this.btnRestaurar.ActiveCornerRadius = 20;
            this.btnRestaurar.ActiveFillColor = System.Drawing.Color.White;
            this.btnRestaurar.ActiveForecolor = System.Drawing.Color.Purple;
            this.btnRestaurar.ActiveLineColor = System.Drawing.Color.Purple;
            this.btnRestaurar.BackColor = System.Drawing.Color.White;
            this.btnRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.BackgroundImage")));
            this.btnRestaurar.ButtonText = "Eliminar";
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.Color.Black;
            this.btnRestaurar.IdleBorderThickness = 1;
            this.btnRestaurar.IdleCornerRadius = 20;
            this.btnRestaurar.IdleFillColor = System.Drawing.Color.White;
            this.btnRestaurar.IdleForecolor = System.Drawing.Color.Gray;
            this.btnRestaurar.IdleLineColor = System.Drawing.Color.Purple;
            this.btnRestaurar.Location = new System.Drawing.Point(251, 339);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(131, 51);
            this.btnRestaurar.TabIndex = 20;
            this.btnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.White;
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.Purple;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.Purple;
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Descartar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 20;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.White;
            this.btnCancelar.IdleForecolor = System.Drawing.Color.Gray;
            this.btnCancelar.IdleLineColor = System.Drawing.Color.Purple;
            this.btnCancelar.Location = new System.Drawing.Point(391, 339);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 51);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 425);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(599, 10);
            this.bunifuGradientPanel1.TabIndex = 22;
            // 
            // navigationBar1
            // 
            this.navigationBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(599, 39);
            this.navigationBar1.TabIndex = 23;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1367, 435);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb3r);
            this.Controls.Add(this.cb2um);
            this.Controls.Add(this.txt3Stock);
            this.Controls.Add(this.txt2Precio);
            this.Controls.Add(this.txt1Nombre);
            this.Controls.Add(this.cb1tipo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Productos_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblProductosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private MetroFramework.Controls.MetroComboBox cb1tipo;
        private System.Windows.Forms.BindingSource tblCategoriaBindingSource;
        private MetroFramework.Controls.MetroTextBox txt1Nombre;
        private MetroFramework.Controls.MetroTextBox txt2Precio;
        private MetroFramework.Controls.MetroTextBox txt3Stock;
        private MetroFramework.Controls.MetroComboBox cb2um;
        private MetroFramework.Controls.MetroComboBox cb3r;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRestaurar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.BindingSource tblUMBindingSource;
        private NavigationBar.NavigationBar navigationBar1;
    }
}