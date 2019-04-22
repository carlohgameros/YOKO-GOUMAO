using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reactive.Linq;
using System.Data.SqlClient;
using System.Reactive;

namespace YOKO
{
    public partial class Tickets : Form
    {
        Timer timer = new Timer();
        SqlConnection conn = new SqlConnection();
        String str, clienteID, vendedor;
        DateTime inicio, final;

        public Tickets()
        {
            conn.ConnectionString = ConnectionString.connectionString;
            InitializeComponent();
            InitializeReactiveComponents();
            str = "";
        }

        public void InitializeReactiveComponents()
        {
            // TextFields
            var nombre = nombreField.Text;
            var fecha = fechaField.Text;
            var vendedor = vendedorField.Text;
           

            IObservable<char> nombreRx = nombre.ToObservable();
            IObservable<char> fechaRx = fecha.ToObservable();
            IObservable<char> vendedorRx = vendedor.ToObservable();
        

            // Checkbox's
            var nombreCB = nombreCheckbox.Enabled;
            var fechaCB = fechaCheckbox.Enabled;
            var vendedorCB = vendedorCheckbox.Enabled;
        


            IObservable<char> nombreCBRx = nombreCB.ToString().ToObservable();
            IObservable<char> fechaCBRx = fechaCB.ToString().ToObservable();
            IObservable<char> vendedorCBRx = vendedorCB.ToString().ToObservable();
            
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            this.tblFacturasTableAdapter.Fill(this.goumaoDBDataSet.tblFacturas);
            contadorLabel.Text = this.goumaoDBDataSet.tblFacturas.Count.ToString() + " Registros.";

            ticketsDataGrid.BorderStyle = BorderStyle.None;
            ticketsDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ticketsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ticketsDataGrid.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            ticketsDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            ticketsDataGrid.EnableHeadersVisualStyles = false;
            ticketsDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ticketsDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ticketsDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            clientesResultadosDataGrid.BorderStyle = BorderStyle.None;
            clientesResultadosDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            clientesResultadosDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            clientesResultadosDataGrid.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            clientesResultadosDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            clientesResultadosDataGrid.EnableHeadersVisualStyles = false;
            clientesResultadosDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            clientesResultadosDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            clientesResultadosDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            vendedoresDataGrid.BorderStyle = BorderStyle.None;
            vendedoresDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            vendedoresDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            vendedoresDataGrid.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            vendedoresDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            vendedoresDataGrid.EnableHeadersVisualStyles = false;
            vendedoresDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            vendedoresDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            vendedoresDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nombreCB = nombreCheckbox.Checked && clienteID != null ? true : false;
            var fechaCB = fechaField.Text.Length > 0 || fechafinalField.Text.Length > 0 && fechaCheckbox.Checked ? true : false;
            var vendedorCB = vendedorCheckbox.Checked && vendedor != null ? true : false;
            var construir = nombreCB || fechaCB || vendedorCB;

            var nombreTabla = "FClienteID";
            var fechaTabla = "FEchaFactura";
            var vendedorTabla = "FUReg";
            // Constructor SQL
            string sql = "SELECT * FROM tblFacturas";
            sql = construir ? sql + " WHERE " : sql;
            sql = nombreCB ? sql.SqlIgual(nombreTabla, clienteID) : sql;
            sql = vendedorCB ? sql.SqlIgual(vendedorTabla, vendedorField.Text) + "": sql;
            sql = fechaCB ? fechaSQLCall(sql, fechaField.Text, fechafinalField.Text) : sql;

            MessageBox.Show(sql);
{
                conn.Open();   
                SqlCommand sCommand = new SqlCommand(sql, conn);
                SqlDataAdapter sAdapter = new SqlDataAdapter(sCommand);
                SqlCommandBuilder sBuilder = new SqlCommandBuilder(sAdapter);
                DataSet sDs = new DataSet();
                sAdapter.Fill(sDs, "Factura");
                DataTable sTable = sDs.Tables["Factura"];
                ticketsDataGrid.DataSource = sTable.Rows.Count == 0 ? null : sDs.Tables["Factura"];
                ticketsDataGrid.ReadOnly = true;
                ticketsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
            }

        }

        private string fechaSQLCall(string sql, string inicio, string final) 
        {
            DateTime inicial = DateTime.Parse(inicio);
            //inicial.toda;
            DateTime finall = DateTime.Parse(final);
            if (inicio == final || final == "")
            {
                return sql += " FechaFactura = '" + inicio + "'";
            }
            else if (inicial < finall)
            {
                return sql += " FechaFactura >= '" + inicio + "' and FechaFactura <= '" + final + "'";
            }
            else
            {
                return null;
            }
        }

        private void nombreCheckbox_OnChange(object sender, EventArgs e)
        {
            
        }

        private void nombreField_OnValueChanged(object sender, EventArgs e)
        {
            if (nombreField.Text.Length > 0)
            {
                nombreCheckbox.Checked = true;
                conn.Open();
                string sql = "SELECT * FROM tblClientes where NombreComercial like '%" + nombreField.Text + "%'";
                SqlCommand sCommand = new SqlCommand(sql, conn);
                SqlDataAdapter sAdapter = new SqlDataAdapter(sCommand);
                SqlCommandBuilder sBuilder = new SqlCommandBuilder(sAdapter);
                DataSet sDs = new DataSet();
                sAdapter.Fill(sDs, "NombreComercial");
                DataTable sTable = sDs.Tables["NombreComercial"];
                clientesResultadosDataGrid.DataSource = sTable.Rows.Count == 0 ? null : sDs.Tables["NombreComercial"];
                clienteAlert.Visible = sTable.Rows.Count == 0;
                nombreCheckbox.Checked = sTable.Rows.Count != 0;
                clientesResultadosDataGrid.ReadOnly = true;
                clientesResultadosDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
                try
                {
                    clienteID = clientesResultadosDataGrid.Rows[clientesResultadosDataGrid.SelectedRows[0].Index].Cells["ClienteID"].Value.ToString();
                }
                catch { }
                clientesResultadosDataGrid.Columns[0].Visible = false;
            }
            else
            {
                nombreCheckbox.Checked = false;
                clientesResultadosDataGrid.DataSource = null;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fechaField.Text = dateTimePicker1.Value.ToShortDateString();
            fechaCheckbox.Checked = true;
        }

        private void dateTimePicker1_MouseHover(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            Console.WriteLine("testing hover");
        }

        private void fechaField_OnValueChanged(object sender, EventArgs e)
        {
            if (fechaField.Text.Length > 0 || fechaField.Text.Length > 0)
            {
                fechaCheckbox.Checked = true;
                if (fechafinalField.Text.Length > 0)
                {
                    DateTime time = DateTime.Parse(fechaField.Text);
                    DateTime timef = DateTime.Parse(fechafinalField.Text);
                    if (time > timef)
                    {
                        fechafinalField.Text = time.ToShortDateString();
                    }
                }
                
            }
            else
            {
                fechaCheckbox.Checked = false;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            fechafinalField.Text = dateTimePicker2.Value.ToShortDateString();
            fechaCheckbox.Checked = true;
        }

        private void fechafinalField_OnValueChanged(object sender, EventArgs e)
        {
            if (fechaField.Text.Length > 0 || fechaField.Text.Length > 0)
            {
                fechaCheckbox.Checked = true;
                if (fechaField.Text.Length > 0)
                {
                    DateTime time = DateTime.Parse(fechaField.Text);
                    DateTime timef = DateTime.Parse(fechafinalField.Text);
                    if (timef < time)
                    {
                        fechaField.Text = timef.ToShortDateString();
                    }
                }

            }
            else
            {
                fechaCheckbox.Checked = false;
            }
        }

        private void vendedorField_OnValueChanged(object sender, EventArgs e)
        {
            if (vendedorField.Text.Length > 0)
            {
                conn.Open();
                string sql = "SELECT UsrName, UsrType, Email FROM tblUsers where UsrName like '%" + vendedorField.Text + "%'";
                SqlCommand sCommand = new SqlCommand(sql, conn);
                SqlDataAdapter sAdapter = new SqlDataAdapter(sCommand);
                SqlCommandBuilder sBuilder = new SqlCommandBuilder(sAdapter);
                DataSet sDs = new DataSet();
                sAdapter.Fill(sDs, "UsrName");
                DataTable sTable = sDs.Tables["UsrName"];
                vendedoresDataGrid.DataSource = sTable.Rows.Count == 0 ? null : sDs.Tables["UsrName"];
                vendedorAlert.Visible = sTable.Rows.Count == 0;
                vendedorCheckbox.Checked = sTable.Rows.Count != 0;
                vendedoresDataGrid.ReadOnly = true;
                vendedoresDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
                try
                {
                    str = vendedoresDataGrid.Rows[vendedoresDataGrid.SelectedRows[0].Index].Cells["UsrName"].Value.ToString();
                }
                catch { }
            }
            else
            {
                vendedorCheckbox.Checked = false;
                vendedoresDataGrid.DataSource = null;
            }
        }
    }
}