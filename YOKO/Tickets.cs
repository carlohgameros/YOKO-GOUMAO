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
using Bunifu.Framework.UI;
using YOKO.Helpers;
using YOKO.Resources;

namespace YOKO
{
    public partial class Tickets : Form
    {
        Timer timer = new Timer();
        String str, clienteID, vendedor;
        DateTime inicio, final;
        SQL sqlHelper;

        public Tickets()
        {
            InitializeComponent();
            InitializeReactiveComponents();
            str = "";
            sqlHelper = new SQL();
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
            sqlHelper.fillTicketsList(Constants.ticketsList, ticketsDataGrid);
            contadorLabel.Text = this.goumaoDBDataSet.tblFacturas.Count.ToString() + " Registros.";

            var editBoxes = new List<BunifuTextbox>() { nombreField, fechaField, fechafinalField, vendedorField };
            foreach (BunifuTextbox textBox in editBoxes)
            {
                textBox._TextBox.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            }

            var dataGrids = new List<DataGridView>() { ticketsDataGrid, clientesResultadosDataGrid, vendedoresDataGrid };
            foreach (DataGridView dataGridView in dataGrids)
            {
                BaseTableDesiner.SetDefaultStyle(dataGridView);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nombreCB = nombreCheckbox.Checked && clienteID != null;
            var fechaCB = fechaField.Text.Length > 0 || fechafinalField.Text.Length > 0 && fechaCheckbox.Checked;
            var vendedorCB = vendedorCheckbox.Checked && vendedor != null;
            var construir = nombreCB || fechaCB || vendedorCB;

            var nombreTabla = "FClienteID";
            var fechaTabla = "FEchaFactura";
            var vendedorTabla = "FUReg";

            var sql = "SELECT * FROM tblFacturas";
            sql = construir ? sql + " WHERE " : sql;
            sql = nombreCB ? sql.SqlIgual(nombreTabla, clienteID) : sql;
            sql = nombreCB && vendedorCB ? sql + " and " : sql;
            sql = vendedorCB ? sql.SqlLike(vendedorTabla, vendedorField._TextBox.Text) + "": sql;
            sql = (nombreCB || vendedorCB) && fechaCB ? sql + " and " : sql;
            sql = fechaCB ? fechaSQLCall(sql, fechaField._TextBox.Text, fechafinalField._TextBox.Text) : sql;

            ticketsDataGrid.DataSource = null;
            clearDataGrid(ticketsDataGrid);
            contadorLabel.Visible = true;

            try
            {
                contadorLabel.Visible = false;
                sqlHelper.fillTicketsList(sql, ticketsDataGrid);
            }
            catch(Exception exception)
            {
                Notifications.NotificationsCenter.ShowErrorMessageForException(exception);
            }
        }

        private string fechaSQLCall(string sql, string inicio, string final) 
        {
            var inicial = DateTime.Parse(inicio);
            var finall = DateTime.Parse(final);

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
                return sql;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fechaField._TextBox.Text = dateTimePicker1.Value.ToShortDateString();
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

        private void nombreField_OnTextChange(object sender, EventArgs e)
        {
            var currentText = nombreField._TextBox.Text;
            var isValid = currentText.Trim().Length > 0;
            clienteAlert.Visible = !isValid;
            
            if (isValid)
            {
                sqlHelper.fillContactList(currentText, clientesResultadosDataGrid);    
            }
            else
            {
                clearDataGrid(clientesResultadosDataGrid);
            } 
        }

        private void clearDataGrid(DataGridView dataGrid)
        {
            DataTable DT = (DataTable)dataGrid.DataSource;
            if (DT != null)
            {
                dataGrid.DataSource = null;
                clearDataGrid(dataGrid);
            }
            else
            {
                dataGrid.Rows.Clear();
            }
        }

        private void fechaField_OnTextChange(object sender, EventArgs e)
        {
            var dateTime = new DateTime();
            fechaCheckbox.Checked = DateTime.TryParse(fechaField._TextBox.Text, out dateTime) && DateTime.TryParse(fechafinalField._TextBox.Text, out dateTime);
        }

        private void fechafinalField_OnTextChange(object sender, EventArgs e)
        {
            var dateTime = new DateTime();
            fechaCheckbox.Checked = DateTime.TryParse(fechaField._TextBox.Text, out dateTime) && DateTime.TryParse(fechafinalField._TextBox.Text, out dateTime);
        }

        private void vendedorField_OnTextChange(object sender, EventArgs e)
        {
            var currentText = vendedorField._TextBox.Text;
            var isValid = currentText.Trim().Length > 0;
            clienteAlert.Visible = !isValid;

            if (isValid)
            {
                sqlHelper.fillUsersList(currentText, vendedoresDataGrid);
            }
            else
            {
                clearDataGrid(vendedoresDataGrid);
            }
        }

        private void fechafinalField_MouseClick(object sender, MouseEventArgs e)
        {
            dateTimePicker2.Show();
        }

        private void clientesResultadosDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clienteID = clientesResultadosDataGrid.Rows[clientesResultadosDataGrid.SelectedRows[0].Index].Cells["ClienteID"].Value.ToString();
                nombreCheckbox.Checked = clienteID != null && clienteID != "";
            }
            catch { }
        }

        private void vendedoresDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vendedor = vendedoresDataGrid.Rows[vendedoresDataGrid.SelectedRows[0].Index].Cells["UsrName"].Value.ToString();
                vendedorCheckbox.Checked = vendedor != null && vendedor != "";
            }
            catch { }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            fechafinalField._TextBox.Text = dateTimePicker2.Value.ToShortDateString();
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
    }
}