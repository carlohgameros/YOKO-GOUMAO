namespace YOKO
{
    partial class Tickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tickets));
            this.ticketsDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fURegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFacturasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.goumaoDBDataSet = new YOKO.GoumaoDBDataSet();
            this.tblFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.nombreCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.contadorLabel = new System.Windows.Forms.Label();
            this.tblFacturasTableAdapter = new YOKO.GoumaoDBDataSetTableAdapters.tblFacturasTableAdapter();
            this.nombreField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.fechaField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.fechaCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.vendedorField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.vendedorCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.clientesResultadosDataGrid = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.vendedoresDataGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.fechafinalField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.vendedorAlert = new System.Windows.Forms.Label();
            this.clienteAlert = new System.Windows.Forms.Label();
            this.navigationBar1 = new YOKO.NavigationBar.NavigationBar();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFacturasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goumaoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesResultadosDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketsDataGrid
            // 
            this.ticketsDataGrid.AutoGenerateColumns = false;
            this.ticketsDataGrid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.ticketsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ticketsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.fURegDataGridViewTextBoxColumn,
            this.fEstatusDataGridViewTextBoxColumn});
            this.ticketsDataGrid.DataSource = this.tblFacturasBindingSource1;
            this.ticketsDataGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.ticketsDataGrid.Location = new System.Drawing.Point(698, 0);
            this.ticketsDataGrid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ticketsDataGrid.Name = "ticketsDataGrid";
            this.ticketsDataGrid.RowHeadersVisible = false;
            this.ticketsDataGrid.Size = new System.Drawing.Size(681, 931);
            this.ticketsDataGrid.TabIndex = 64;
            this.ticketsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FechaFactura";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FSubtotal";
            this.dataGridViewTextBoxColumn3.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FIVA";
            this.dataGridViewTextBoxColumn4.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FTotal";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // fURegDataGridViewTextBoxColumn
            // 
            this.fURegDataGridViewTextBoxColumn.DataPropertyName = "FUReg";
            this.fURegDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.fURegDataGridViewTextBoxColumn.Name = "fURegDataGridViewTextBoxColumn";
            // 
            // fEstatusDataGridViewTextBoxColumn
            // 
            this.fEstatusDataGridViewTextBoxColumn.DataPropertyName = "FEstatus";
            this.fEstatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.fEstatusDataGridViewTextBoxColumn.Name = "fEstatusDataGridViewTextBoxColumn";
            // 
            // tblFacturasBindingSource1
            // 
            this.tblFacturasBindingSource1.DataMember = "tblFacturas";
            this.tblFacturasBindingSource1.DataSource = this.goumaoDBDataSet;
            // 
            // goumaoDBDataSet
            // 
            this.goumaoDBDataSet.DataSetName = "GoumaoDBDataSet";
            this.goumaoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFacturasBindingSource
            // 
            this.tblFacturasBindingSource.DataMember = "tblFacturas";
            // 
            // buscarButton
            // 
            this.buscarButton.ActiveBorderThickness = 1;
            this.buscarButton.ActiveCornerRadius = 20;
            this.buscarButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buscarButton.ActiveForecolor = System.Drawing.Color.Black;
            this.buscarButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buscarButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buscarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarButton.BackgroundImage")));
            this.buscarButton.ButtonText = "Buscar";
            this.buscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buscarButton.IdleBorderThickness = 5;
            this.buscarButton.IdleCornerRadius = 10;
            this.buscarButton.IdleFillColor = System.Drawing.SystemColors.ControlLight;
            this.buscarButton.IdleForecolor = System.Drawing.Color.Gray;
            this.buscarButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buscarButton.Location = new System.Drawing.Point(51, 776);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(8);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(555, 100);
            this.buscarButton.TabIndex = 80;
            this.buscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buscarButton.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nombreCheckbox
            // 
            this.nombreCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.nombreCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.nombreCheckbox.Checked = false;
            this.nombreCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.nombreCheckbox.ForeColor = System.Drawing.Color.White;
            this.nombreCheckbox.Location = new System.Drawing.Point(18, 230);
            this.nombreCheckbox.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.nombreCheckbox.Name = "nombreCheckbox";
            this.nombreCheckbox.Size = new System.Drawing.Size(20, 20);
            this.nombreCheckbox.TabIndex = 81;
            this.nombreCheckbox.Tag = "v";
            this.nombreCheckbox.OnChange += new System.EventHandler(this.nombreCheckbox_OnChange);
            // 
            // contadorLabel
            // 
            this.contadorLabel.AutoSize = true;
            this.contadorLabel.BackColor = System.Drawing.Color.Silver;
            this.contadorLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contadorLabel.Location = new System.Drawing.Point(971, 470);
            this.contadorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contadorLabel.Name = "contadorLabel";
            this.contadorLabel.Size = new System.Drawing.Size(160, 46);
            this.contadorLabel.TabIndex = 83;
            this.contadorLabel.Text = "cantidad";
            // 
            // tblFacturasTableAdapter
            // 
            this.tblFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // nombreField
            // 
            this.nombreField.BorderColorFocused = System.Drawing.Color.Blue;
            this.nombreField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nombreField.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.nombreField.BorderThickness = 3;
            this.nombreField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nombreField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nombreField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nombreField.isPassword = false;
            this.nombreField.Location = new System.Drawing.Point(51, 212);
            this.nombreField.Margin = new System.Windows.Forms.Padding(6);
            this.nombreField.Name = "nombreField";
            this.nombreField.Size = new System.Drawing.Size(555, 68);
            this.nombreField.TabIndex = 84;
            this.nombreField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nombreField.OnValueChanged += new System.EventHandler(this.nombreField_OnValueChanged);
            // 
            // fechaField
            // 
            this.fechaField.BorderColorFocused = System.Drawing.Color.Blue;
            this.fechaField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fechaField.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.fechaField.BorderThickness = 3;
            this.fechaField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fechaField.Enabled = false;
            this.fechaField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fechaField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fechaField.isPassword = false;
            this.fechaField.Location = new System.Drawing.Point(51, 460);
            this.fechaField.Margin = new System.Windows.Forms.Padding(6);
            this.fechaField.Name = "fechaField";
            this.fechaField.Size = new System.Drawing.Size(272, 68);
            this.fechaField.TabIndex = 86;
            this.fechaField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fechaField.OnValueChanged += new System.EventHandler(this.fechaField_OnValueChanged);
            // 
            // fechaCheckbox
            // 
            this.fechaCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.fechaCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.fechaCheckbox.Checked = false;
            this.fechaCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.fechaCheckbox.ForeColor = System.Drawing.Color.White;
            this.fechaCheckbox.Location = new System.Drawing.Point(18, 478);
            this.fechaCheckbox.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.fechaCheckbox.Name = "fechaCheckbox";
            this.fechaCheckbox.Size = new System.Drawing.Size(20, 20);
            this.fechaCheckbox.TabIndex = 85;
            this.fechaCheckbox.Tag = "v";
            // 
            // vendedorField
            // 
            this.vendedorField.BorderColorFocused = System.Drawing.Color.Blue;
            this.vendedorField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vendedorField.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.vendedorField.BorderThickness = 3;
            this.vendedorField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vendedorField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.vendedorField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vendedorField.isPassword = false;
            this.vendedorField.Location = new System.Drawing.Point(51, 571);
            this.vendedorField.Margin = new System.Windows.Forms.Padding(6);
            this.vendedorField.Name = "vendedorField";
            this.vendedorField.Size = new System.Drawing.Size(555, 68);
            this.vendedorField.TabIndex = 88;
            this.vendedorField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.vendedorField.OnValueChanged += new System.EventHandler(this.vendedorField_OnValueChanged);
            // 
            // vendedorCheckbox
            // 
            this.vendedorCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.vendedorCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.vendedorCheckbox.Checked = false;
            this.vendedorCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.vendedorCheckbox.ForeColor = System.Drawing.Color.White;
            this.vendedorCheckbox.Location = new System.Drawing.Point(18, 589);
            this.vendedorCheckbox.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.vendedorCheckbox.Name = "vendedorCheckbox";
            this.vendedorCheckbox.Size = new System.Drawing.Size(20, 20);
            this.vendedorCheckbox.TabIndex = 87;
            this.vendedorCheckbox.Tag = "v";
            // 
            // clientesResultadosDataGrid
            // 
            this.clientesResultadosDataGrid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.clientesResultadosDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientesResultadosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesResultadosDataGrid.Location = new System.Drawing.Point(51, 292);
            this.clientesResultadosDataGrid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clientesResultadosDataGrid.Name = "clientesResultadosDataGrid";
            this.clientesResultadosDataGrid.RowHeadersVisible = false;
            this.clientesResultadosDataGrid.Size = new System.Drawing.Size(555, 124);
            this.clientesResultadosDataGrid.TabIndex = 91;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 919);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(698, 12);
            this.bunifuGradientPanel1.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 93;
            this.label2.Text = "Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 422);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 30);
            this.label3.TabIndex = 94;
            this.label3.Text = "Fecha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 534);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 30);
            this.label4.TabIndex = 95;
            this.label4.Text = "Vendedor";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 470);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(25, 44);
            this.dateTimePicker1.TabIndex = 97;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.MouseHover += new System.EventHandler(this.dateTimePicker1_MouseHover);
            // 
            // vendedoresDataGrid
            // 
            this.vendedoresDataGrid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.vendedoresDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendedoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendedoresDataGrid.Location = new System.Drawing.Point(51, 651);
            this.vendedoresDataGrid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.vendedoresDataGrid.Name = "vendedoresDataGrid";
            this.vendedoresDataGrid.RowHeadersVisible = false;
            this.vendedoresDataGrid.Size = new System.Drawing.Size(555, 111);
            this.vendedoresDataGrid.TabIndex = 98;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(570, 470);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(25, 44);
            this.dateTimePicker2.TabIndex = 100;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // fechafinalField
            // 
            this.fechafinalField.BorderColorFocused = System.Drawing.Color.Blue;
            this.fechafinalField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fechafinalField.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.fechafinalField.BorderThickness = 3;
            this.fechafinalField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fechafinalField.Enabled = false;
            this.fechafinalField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fechafinalField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fechafinalField.isPassword = false;
            this.fechafinalField.Location = new System.Drawing.Point(333, 460);
            this.fechafinalField.Margin = new System.Windows.Forms.Padding(6);
            this.fechafinalField.Name = "fechafinalField";
            this.fechafinalField.Size = new System.Drawing.Size(272, 68);
            this.fechafinalField.TabIndex = 99;
            this.fechafinalField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fechafinalField.OnValueChanged += new System.EventHandler(this.fechafinalField_OnValueChanged);
            // 
            // vendedorAlert
            // 
            this.vendedorAlert.AutoSize = true;
            this.vendedorAlert.BackColor = System.Drawing.Color.Silver;
            this.vendedorAlert.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedorAlert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vendedorAlert.Location = new System.Drawing.Point(212, 680);
            this.vendedorAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vendedorAlert.Name = "vendedorAlert";
            this.vendedorAlert.Size = new System.Drawing.Size(245, 46);
            this.vendedorAlert.TabIndex = 101;
            this.vendedorAlert.Text = "Sin resultados";
            this.vendedorAlert.Visible = false;
            // 
            // clienteAlert
            // 
            this.clienteAlert.AutoSize = true;
            this.clienteAlert.BackColor = System.Drawing.Color.Silver;
            this.clienteAlert.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteAlert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clienteAlert.Location = new System.Drawing.Point(212, 328);
            this.clienteAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clienteAlert.Name = "clienteAlert";
            this.clienteAlert.Size = new System.Drawing.Size(245, 46);
            this.clienteAlert.TabIndex = 102;
            this.clienteAlert.Text = "Sin resultados";
            this.clienteAlert.Visible = false;
            // 
            // navigationBar1
            // 
            this.navigationBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(698, 60);
            this.navigationBar1.TabIndex = 103;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1379, 931);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.clienteAlert);
            this.Controls.Add(this.vendedorAlert);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.fechafinalField);
            this.Controls.Add(this.vendedoresDataGrid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.clientesResultadosDataGrid);
            this.Controls.Add(this.vendedorField);
            this.Controls.Add(this.vendedorCheckbox);
            this.Controls.Add(this.fechaField);
            this.Controls.Add(this.fechaCheckbox);
            this.Controls.Add(this.nombreField);
            this.Controls.Add(this.contadorLabel);
            this.Controls.Add(this.nombreCheckbox);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.ticketsDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFacturasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goumaoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesResultadosDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ticketsDataGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 buscarButton;
        private System.Windows.Forms.BindingSource tblFacturasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSubtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIPagadoDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuCheckbox nombreCheckbox;
        private System.Windows.Forms.Label contadorLabel;
        private GoumaoDBDataSet goumaoDBDataSet;
        private System.Windows.Forms.BindingSource tblFacturasBindingSource1;
        private GoumaoDBDataSetTableAdapters.tblFacturasTableAdapter tblFacturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn fURegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEstatusDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuMetroTextbox nombreField;
        private Bunifu.Framework.UI.BunifuMetroTextbox fechaField;
        private Bunifu.Framework.UI.BunifuCheckbox fechaCheckbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox vendedorField;
        private Bunifu.Framework.UI.BunifuCheckbox vendedorCheckbox;
        private System.Windows.Forms.DataGridView clientesResultadosDataGrid;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView vendedoresDataGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Bunifu.Framework.UI.BunifuMetroTextbox fechafinalField;
        private System.Windows.Forms.Label vendedorAlert;
        private System.Windows.Forms.Label clienteAlert;
        private NavigationBar.NavigationBar navigationBar1;
    }
}