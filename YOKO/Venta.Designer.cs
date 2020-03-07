namespace YOKO
{
    partial class Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.clienteCB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.telefonoCB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.celularCB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientes = new System.Windows.Forms.DataGridView();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.mascotas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuCheckbox4 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.registro = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.PetNote = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Import = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.DangerPetIndicator = new Bunifu.Framework.UI.BunifuCheckbox();
            this.DangerPetLabel = new System.Windows.Forms.Label();
            this.petAddRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.AgregarUsuario = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AgregarMascota = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AgregarProducto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tblClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.navigationBar1 = new YOKO.NavigationBar.NavigationBar();
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteCB
            // 
            resources.ApplyResources(this.clienteCB, "clienteCB");
            this.clienteCB.BackColor = System.Drawing.Color.SeaGreen;
            this.clienteCB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.clienteCB.Checked = true;
            this.clienteCB.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.clienteCB.ForeColor = System.Drawing.Color.White;
            this.clienteCB.Name = "clienteCB";
            this.clienteCB.OnChange += new System.EventHandler(this.clienteCB_OnChange);
            // 
            // telefonoCB
            // 
            this.telefonoCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.telefonoCB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.telefonoCB.Checked = false;
            this.telefonoCB.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.telefonoCB.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.telefonoCB, "telefonoCB");
            this.telefonoCB.Name = "telefonoCB";
            this.telefonoCB.OnChange += new System.EventHandler(this.telefonoCB_OnChange);
            // 
            // celularCB
            // 
            this.celularCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.celularCB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.celularCB.Checked = false;
            this.celularCB.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.celularCB.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.celularCB, "celularCB");
            this.celularCB.Name = "celularCB";
            this.celularCB.Tag = "v";
            this.celularCB.OnChange += new System.EventHandler(this.celularCB_OnChange);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // clientes
            // 
            this.clientes.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.clientes, "clientes");
            this.clientes.Name = "clientes";
            this.clientes.RowHeadersVisible = false;
            this.clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientes_CellContentClick);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.metroTextBox1.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.metroTextBox1.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.metroTextBox1.CustomButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin")));
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.Lines = new string[0];
            resources.ApplyResources(this.metroTextBox1, "metroTextBox1");
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.ShowButton = true;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mascotas
            // 
            this.mascotas.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.mascotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.mascotas, "mascotas");
            this.mascotas.Name = "mascotas";
            this.mascotas.RowHeadersVisible = false;
            this.mascotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // bunifuCheckbox4
            // 
            this.bunifuCheckbox4.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCheckbox4.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox4.Checked = true;
            this.bunifuCheckbox4.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.bunifuCheckbox4.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bunifuCheckbox4, "bunifuCheckbox4");
            this.bunifuCheckbox4.Name = "bunifuCheckbox4";
            this.bunifuCheckbox4.Tag = "v";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("textBox1.AutoCompleteCustomSource"),
            resources.GetString("textBox1.AutoCompleteCustomSource1"),
            resources.GetString("textBox1.AutoCompleteCustomSource2")});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            resources.ApplyResources(this.bunifuDatepicker1, "bunifuDatepicker1");
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Value = new System.DateTime(2018, 6, 14, 18, 56, 28, 303);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // txtMoneda
            // 
            this.txtMoneda.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("txtMoneda.AutoCompleteCustomSource"),
            resources.GetString("txtMoneda.AutoCompleteCustomSource1"),
            resources.GetString("txtMoneda.AutoCompleteCustomSource2")});
            this.txtMoneda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMoneda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            resources.ApplyResources(this.txtMoneda, "txtMoneda");
            this.txtMoneda.Name = "txtMoneda";
            // 
            // registro
            // 
            this.registro.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.registro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.registro, "registro");
            this.registro.Name = "registro";
            this.registro.RowHeadersVisible = false;
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // PetNote
            // 
            resources.ApplyResources(this.PetNote, "PetNote");
            this.PetNote.Name = "PetNote";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // txtFP
            // 
            resources.ApplyResources(this.txtFP, "txtFP");
            this.txtFP.Name = "txtFP";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // txtNota
            // 
            resources.ApplyResources(this.txtNota, "txtNota");
            this.txtNota.Name = "txtNota";
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToOrderColumns = true;
            this.lista.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Productos,
            this.Cantidad,
            this.Preci,
            this.Descuent,
            this.Import,
            this.Inv,
            this.Servicio,
            this.Eliminar});
            resources.ApplyResources(this.lista, "lista");
            this.lista.Name = "lista";
            this.lista.RowHeadersVisible = false;
            this.lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick_1);
            this.lista.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_CellValueChanged);
            // 
            // ID
            // 
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            // 
            // Productos
            // 
            this.Productos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Productos, "Productos");
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            // 
            // Cantidad
            // 
            resources.ApplyResources(this.Cantidad, "Cantidad");
            this.Cantidad.Name = "Cantidad";
            // 
            // Preci
            // 
            this.Preci.Name = "Preci";
            // 
            // Descuent
            // 
            resources.ApplyResources(this.Descuent, "Descuent");
            this.Descuent.Name = "Descuent";
            // 
            // Import
            // 
            resources.ApplyResources(this.Import, "Import");
            this.Import.Name = "Import";
            this.Import.ReadOnly = true;
            // 
            // Inv
            // 
            this.Inv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.Inv, "Inv");
            this.Inv.Name = "Inv";
            this.Inv.ReadOnly = true;
            // 
            // Servicio
            // 
            this.Servicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.Servicio, "Servicio");
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            this.Servicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Servicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.Eliminar, "Eliminar");
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txtImporte
            // 
            resources.ApplyResources(this.txtImporte, "txtImporte");
            this.txtImporte.Name = "txtImporte";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // txtDescuento
            // 
            resources.ApplyResources(this.txtDescuento, "txtDescuento");
            this.txtDescuento.Name = "txtDescuento";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtPrecio
            // 
            resources.ApplyResources(this.txtPrecio, "txtPrecio");
            this.txtPrecio.Name = "txtPrecio";
            // 
            // txtUM
            // 
            resources.ApplyResources(this.txtUM, "txtUM");
            this.txtUM.Name = "txtUM";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtCantidad
            // 
            resources.ApplyResources(this.txtCantidad, "txtCantidad");
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged_1);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtProductos
            // 
            resources.ApplyResources(this.txtProductos, "txtProductos");
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.TextChanged += new System.EventHandler(this.txtProductos_TextChanged_2);
            this.txtProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductos_KeyDown);
            // 
            // DangerPetIndicator
            // 
            this.DangerPetIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.DangerPetIndicator.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.DangerPetIndicator.Checked = false;
            this.DangerPetIndicator.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.DangerPetIndicator, "DangerPetIndicator");
            this.DangerPetIndicator.ForeColor = System.Drawing.Color.White;
            this.DangerPetIndicator.Name = "DangerPetIndicator";
            this.DangerPetIndicator.Tag = "v";
            // 
            // DangerPetLabel
            // 
            resources.ApplyResources(this.DangerPetLabel, "DangerPetLabel");
            this.DangerPetLabel.Name = "DangerPetLabel";
            // 
            // petAddRegister
            // 
            this.petAddRegister.ActiveBorderThickness = 1;
            this.petAddRegister.ActiveCornerRadius = 20;
            this.petAddRegister.ActiveFillColor = System.Drawing.Color.White;
            this.petAddRegister.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.petAddRegister.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.petAddRegister.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.petAddRegister, "petAddRegister");
            this.petAddRegister.ButtonText = "Agregar Registro";
            this.petAddRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.petAddRegister.ForeColor = System.Drawing.Color.SeaGreen;
            this.petAddRegister.IdleBorderThickness = 1;
            this.petAddRegister.IdleCornerRadius = 20;
            this.petAddRegister.IdleFillColor = System.Drawing.Color.White;
            this.petAddRegister.IdleForecolor = System.Drawing.Color.Gray;
            this.petAddRegister.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.petAddRegister.Name = "petAddRegister";
            this.petAddRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.petAddRegister.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuGradientPanel1
            // 
            resources.ApplyResources(this.bunifuGradientPanel1, "bunifuGradientPanel1");
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bunifuTextbox1, "bunifuTextbox1");
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.text = "";
            this.bunifuTextbox1.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            // 
            // AgregarUsuario
            // 
            this.AgregarUsuario.ActiveBorderThickness = 1;
            this.AgregarUsuario.ActiveCornerRadius = 20;
            this.AgregarUsuario.ActiveFillColor = System.Drawing.Color.White;
            this.AgregarUsuario.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.AgregarUsuario.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.AgregarUsuario.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.AgregarUsuario, "AgregarUsuario");
            this.AgregarUsuario.ButtonText = "Agregar Cliente";
            this.AgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarUsuario.ForeColor = System.Drawing.Color.SeaGreen;
            this.AgregarUsuario.IdleBorderThickness = 1;
            this.AgregarUsuario.IdleCornerRadius = 20;
            this.AgregarUsuario.IdleFillColor = System.Drawing.Color.White;
            this.AgregarUsuario.IdleForecolor = System.Drawing.Color.Gray;
            this.AgregarUsuario.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.AgregarUsuario.Name = "AgregarUsuario";
            this.AgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AgregarUsuario.Click += new System.EventHandler(this.AgregarUsuario_Click);
            // 
            // AgregarMascota
            // 
            this.AgregarMascota.ActiveBorderThickness = 1;
            this.AgregarMascota.ActiveCornerRadius = 20;
            this.AgregarMascota.ActiveFillColor = System.Drawing.Color.White;
            this.AgregarMascota.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.AgregarMascota.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.AgregarMascota.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.AgregarMascota, "AgregarMascota");
            this.AgregarMascota.ButtonText = "Agregar Mascota";
            this.AgregarMascota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarMascota.ForeColor = System.Drawing.Color.SeaGreen;
            this.AgregarMascota.IdleBorderThickness = 1;
            this.AgregarMascota.IdleCornerRadius = 20;
            this.AgregarMascota.IdleFillColor = System.Drawing.Color.White;
            this.AgregarMascota.IdleForecolor = System.Drawing.Color.Gray;
            this.AgregarMascota.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.AgregarMascota.Name = "AgregarMascota";
            this.AgregarMascota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AgregarMascota.Click += new System.EventHandler(this.AgregarMascota_Click);
            // 
            // AgregarProducto
            // 
            this.AgregarProducto.ActiveBorderThickness = 1;
            this.AgregarProducto.ActiveCornerRadius = 20;
            this.AgregarProducto.ActiveFillColor = System.Drawing.Color.White;
            this.AgregarProducto.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.AgregarProducto.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.AgregarProducto.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.AgregarProducto, "AgregarProducto");
            this.AgregarProducto.ButtonText = "Agregar Producto";
            this.AgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarProducto.ForeColor = System.Drawing.Color.SeaGreen;
            this.AgregarProducto.IdleBorderThickness = 1;
            this.AgregarProducto.IdleCornerRadius = 20;
            this.AgregarProducto.IdleFillColor = System.Drawing.Color.White;
            this.AgregarProducto.IdleForecolor = System.Drawing.Color.Gray;
            this.AgregarProducto.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.AgregarProducto.Name = "AgregarProducto";
            this.AgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AgregarProducto.Click += new System.EventHandler(this.AgregarProducto_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ActiveBorderThickness = 1;
            this.btnAgregar.ActiveCornerRadius = 20;
            this.btnAgregar.ActiveFillColor = System.Drawing.Color.White;
            this.btnAgregar.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.ButtonText = "Agregar al Carrito";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.IdleBorderThickness = 1;
            this.btnAgregar.IdleCornerRadius = 20;
            this.btnAgregar.IdleFillColor = System.Drawing.Color.White;
            this.btnAgregar.IdleForecolor = System.Drawing.Color.Gray;
            this.btnAgregar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // tblClientesBindingSource
            // 
            this.tblClientesBindingSource.DataMember = "tblClientes";
            // 
            // pagar
            // 
            this.pagar.ActiveBorderThickness = 1;
            this.pagar.ActiveCornerRadius = 40;
            this.pagar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.pagar.ActiveForecolor = System.Drawing.Color.White;
            this.pagar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.pagar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pagar, "pagar");
            this.pagar.ButtonText = "PAGAR";
            this.pagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pagar.ForeColor = System.Drawing.Color.SeaGreen;
            this.pagar.IdleBorderThickness = 1;
            this.pagar.IdleCornerRadius = 20;
            this.pagar.IdleFillColor = System.Drawing.Color.White;
            this.pagar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.pagar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.pagar.Name = "pagar";
            this.pagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pagar.Click += new System.EventHandler(this.pagar_Click);
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.statusLabel.Name = "statusLabel";
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.totalLabel, "totalLabel");
            this.totalLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.totalLabel.Name = "totalLabel";
            // 
            // navigationBar1
            // 
            resources.ApplyResources(this.navigationBar1, "navigationBar1");
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Load += new System.EventHandler(this.navigationBar1_Load);
            // 
            // Venta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pagar);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.DangerPetLabel);
            this.Controls.Add(this.DangerPetIndicator);
            this.Controls.Add(this.petAddRegister);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtFP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtUM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.PetNote);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuCheckbox4);
            this.Controls.Add(this.AgregarProducto);
            this.Controls.Add(this.AgregarMascota);
            this.Controls.Add(this.AgregarUsuario);
            this.Controls.Add(this.mascotas);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.clientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.celularCB);
            this.Controls.Add(this.telefonoCB);
            this.Controls.Add(this.clienteCB);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCheckbox clienteCB;
        private Bunifu.Framework.UI.BunifuCheckbox telefonoCB;
        private Bunifu.Framework.UI.BunifuCheckbox celularCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tblClientesBindingSource;
        private System.Windows.Forms.DataGridView clientes;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.DataGridView mascotas;
        private Bunifu.Framework.UI.BunifuThinButton2 AgregarUsuario;
        private Bunifu.Framework.UI.BunifuThinButton2 AgregarMascota;
        private Bunifu.Framework.UI.BunifuThinButton2 AgregarProducto;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.DataGridView registro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox PetNote;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.DataGridView lista;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtUM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProductos;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 petAddRegister;
        private Bunifu.Framework.UI.BunifuCheckbox DangerPetIndicator;
        private System.Windows.Forms.Label DangerPetLabel;
        private NavigationBar.NavigationBar navigationBar1;
        private Bunifu.Framework.UI.BunifuThinButton2 pagar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Import;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Servicio;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}