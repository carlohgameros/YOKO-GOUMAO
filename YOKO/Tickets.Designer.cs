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
            this.fechaCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.vendedorCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.clientesResultadosDataGrid = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.vendedoresDataGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.vendedorAlert = new System.Windows.Forms.Label();
            this.clienteAlert = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.nombreField = new Bunifu.Framework.UI.BunifuTextbox();
            this.vendedorField = new Bunifu.Framework.UI.BunifuTextbox();
            this.fechafinalField = new Bunifu.Framework.UI.BunifuTextbox();
            this.fechaField = new Bunifu.Framework.UI.BunifuTextbox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.ticketsDataGrid.Location = new System.Drawing.Point(775, 0);
            this.ticketsDataGrid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ticketsDataGrid.Name = "ticketsDataGrid";
            this.ticketsDataGrid.RowHeadersVisible = false;
            this.ticketsDataGrid.Size = new System.Drawing.Size(604, 931);
            this.ticketsDataGrid.TabIndex = 64;
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
            this.buscarButton.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.buscarButton.ActiveForecolor = System.Drawing.Color.Black;
            this.buscarButton.ActiveLineColor = System.Drawing.Color.LightSeaGreen;
            this.buscarButton.BackColor = System.Drawing.Color.White;
            this.buscarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarButton.BackgroundImage")));
            this.buscarButton.ButtonText = "Buscar";
            this.buscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buscarButton.IdleBorderThickness = 5;
            this.buscarButton.IdleCornerRadius = 10;
            this.buscarButton.IdleFillColor = System.Drawing.Color.White;
            this.buscarButton.IdleForecolor = System.Drawing.Color.Black;
            this.buscarButton.IdleLineColor = System.Drawing.Color.LightSeaGreen;
            this.buscarButton.Location = new System.Drawing.Point(103, 737);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(8);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(555, 100);
            this.buscarButton.TabIndex = 80;
            this.buscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buscarButton.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nombreCheckbox
            // 
            this.nombreCheckbox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.nombreCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.nombreCheckbox.Checked = false;
            this.nombreCheckbox.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.nombreCheckbox.ForeColor = System.Drawing.Color.White;
            this.nombreCheckbox.Location = new System.Drawing.Point(69, 154);
            this.nombreCheckbox.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.nombreCheckbox.Name = "nombreCheckbox";
            this.nombreCheckbox.Size = new System.Drawing.Size(20, 20);
            this.nombreCheckbox.TabIndex = 81;
            this.nombreCheckbox.Tag = "v";
            // 
            // contadorLabel
            // 
            this.contadorLabel.AutoSize = true;
            this.contadorLabel.BackColor = System.Drawing.Color.Silver;
            this.contadorLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contadorLabel.Location = new System.Drawing.Point(997, 442);
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
            // fechaCheckbox
            // 
            this.fechaCheckbox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.fechaCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.fechaCheckbox.Checked = false;
            this.fechaCheckbox.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.fechaCheckbox.ForeColor = System.Drawing.Color.White;
            this.fechaCheckbox.Location = new System.Drawing.Point(69, 413);
            this.fechaCheckbox.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.fechaCheckbox.Name = "fechaCheckbox";
            this.fechaCheckbox.Size = new System.Drawing.Size(20, 20);
            this.fechaCheckbox.TabIndex = 85;
            this.fechaCheckbox.Tag = "v";
            // 
            // vendedorCheckbox
            // 
            this.vendedorCheckbox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.vendedorCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.vendedorCheckbox.Checked = false;
            this.vendedorCheckbox.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.vendedorCheckbox.ForeColor = System.Drawing.Color.White;
            this.vendedorCheckbox.Location = new System.Drawing.Point(69, 549);
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
            this.clientesResultadosDataGrid.Location = new System.Drawing.Point(103, 217);
            this.clientesResultadosDataGrid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clientesResultadosDataGrid.Name = "clientesResultadosDataGrid";
            this.clientesResultadosDataGrid.RowHeadersVisible = false;
            this.clientesResultadosDataGrid.Size = new System.Drawing.Size(555, 124);
            this.clientesResultadosDataGrid.TabIndex = 91;
            this.clientesResultadosDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesResultadosDataGrid_CellContentClick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 921);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(775, 10);
            this.bunifuGradientPanel1.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 93;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 30);
            this.label3.TabIndex = 94;
            this.label3.Text = "Fecha Inical";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 483);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(349, 401);
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
            this.vendedoresDataGrid.Location = new System.Drawing.Point(103, 612);
            this.vendedoresDataGrid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.vendedoresDataGrid.Name = "vendedoresDataGrid";
            this.vendedoresDataGrid.RowHeadersVisible = false;
            this.vendedoresDataGrid.Size = new System.Drawing.Size(555, 111);
            this.vendedoresDataGrid.TabIndex = 98;
            this.vendedoresDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendedoresDataGrid_CellContentClick);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(621, 401);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(25, 44);
            this.dateTimePicker2.TabIndex = 100;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // vendedorAlert
            // 
            this.vendedorAlert.AutoSize = true;
            this.vendedorAlert.BackColor = System.Drawing.Color.Silver;
            this.vendedorAlert.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedorAlert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vendedorAlert.Location = new System.Drawing.Point(258, 644);
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
            this.clienteAlert.Location = new System.Drawing.Point(258, 256);
            this.clienteAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clienteAlert.Name = "clienteAlert";
            this.clienteAlert.Size = new System.Drawing.Size(245, 46);
            this.clienteAlert.TabIndex = 102;
            this.clienteAlert.Text = "Sin resultados";
            this.clienteAlert.Visible = false;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(698, 921);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(680, 10);
            this.bunifuGradientPanel2.TabIndex = 93;
            // 
            // nombreField
            // 
            this.nombreField.BackColor = System.Drawing.Color.White;
            this.nombreField.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nombreField.BackgroundImage")));
            this.nombreField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nombreField.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreField.ForeColor = System.Drawing.Color.Black;
            this.nombreField.Icon = ((System.Drawing.Image)(resources.GetObject("nombreField.Icon")));
            this.nombreField.Location = new System.Drawing.Point(103, 124);
            this.nombreField.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nombreField.Name = "nombreField";
            this.nombreField.Size = new System.Drawing.Size(555, 81);
            this.nombreField.TabIndex = 104;
            this.nombreField.text = "";
            this.nombreField.OnTextChange += new System.EventHandler(this.nombreField_OnTextChange);
            // 
            // vendedorField
            // 
            this.vendedorField.BackColor = System.Drawing.Color.White;
            this.vendedorField.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vendedorField.BackgroundImage")));
            this.vendedorField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vendedorField.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedorField.ForeColor = System.Drawing.Color.Black;
            this.vendedorField.Icon = ((System.Drawing.Image)(resources.GetObject("vendedorField.Icon")));
            this.vendedorField.Location = new System.Drawing.Point(103, 519);
            this.vendedorField.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.vendedorField.Name = "vendedorField";
            this.vendedorField.Size = new System.Drawing.Size(555, 81);
            this.vendedorField.TabIndex = 105;
            this.vendedorField.text = "";
            this.vendedorField.OnTextChange += new System.EventHandler(this.vendedorField_OnTextChange);
            // 
            // fechafinalField
            // 
            this.fechafinalField.BackColor = System.Drawing.Color.White;
            this.fechafinalField.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fechafinalField.BackgroundImage")));
            this.fechafinalField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fechafinalField.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechafinalField.ForeColor = System.Drawing.Color.Black;
            this.fechafinalField.Icon = ((System.Drawing.Image)(resources.GetObject("fechafinalField.Icon")));
            this.fechafinalField.Location = new System.Drawing.Point(406, 383);
            this.fechafinalField.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fechafinalField.Name = "fechafinalField";
            this.fechafinalField.Size = new System.Drawing.Size(252, 81);
            this.fechafinalField.TabIndex = 106;
            this.fechafinalField.text = "";
            this.fechafinalField.OnTextChange += new System.EventHandler(this.fechafinalField_OnTextChange);
            this.fechafinalField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fechafinalField_MouseClick);
            // 
            // fechaField
            // 
            this.fechaField.BackColor = System.Drawing.Color.White;
            this.fechaField.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fechaField.BackgroundImage")));
            this.fechaField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fechaField.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaField.ForeColor = System.Drawing.Color.Black;
            this.fechaField.Icon = ((System.Drawing.Image)(resources.GetObject("fechaField.Icon")));
            this.fechaField.Location = new System.Drawing.Point(103, 383);
            this.fechaField.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fechaField.Name = "fechaField";
            this.fechaField.Size = new System.Drawing.Size(284, 81);
            this.fechaField.TabIndex = 107;
            this.fechaField.text = "";
            this.fechaField.OnTextChange += new System.EventHandler(this.fechaField_OnTextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 347);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 108;
            this.label1.Text = "Fecha Final";
            // 
            // navigationBar1
            // 
            this.navigationBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(775, 60);
            this.navigationBar1.TabIndex = 103;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 931);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vendedorField);
            this.Controls.Add(this.nombreField);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.navigationBar1);
            this.Controls.Add(this.clienteAlert);
            this.Controls.Add(this.vendedorAlert);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.vendedoresDataGrid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.clientesResultadosDataGrid);
            this.Controls.Add(this.vendedorCheckbox);
            this.Controls.Add(this.fechaCheckbox);
            this.Controls.Add(this.contadorLabel);
            this.Controls.Add(this.nombreCheckbox);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.ticketsDataGrid);
            this.Controls.Add(this.fechaField);
            this.Controls.Add(this.fechafinalField);
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
        private Bunifu.Framework.UI.BunifuCheckbox fechaCheckbox;
        private Bunifu.Framework.UI.BunifuCheckbox vendedorCheckbox;
        private System.Windows.Forms.DataGridView clientesResultadosDataGrid;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView vendedoresDataGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label vendedorAlert;
        private System.Windows.Forms.Label clienteAlert;
        private NavigationBar.NavigationBar navigationBar1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuTextbox nombreField;
        private Bunifu.Framework.UI.BunifuTextbox vendedorField;
        private Bunifu.Framework.UI.BunifuTextbox fechafinalField;
        private Bunifu.Framework.UI.BunifuTextbox fechaField;
        private System.Windows.Forms.Label label1;
    }
}