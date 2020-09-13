using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using YOKO.Helpers;
using YOKO.Models;

namespace YOKO
{
    public partial class Productos : Form
    {
        SQL sqlHelper = new SQL();
        SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
        private int currentIDSelected = 0;

        private const float V = 10.00F;

        public Productos()
        {
            InitializeComponent();
            
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            FillDataGrid();
            BaseTableDesiner.SetDefaultStyle(dataGridView1);
            
            if (cb1tipo.Text == "PRODUCTOS")
            {
                cb3r.Text = "No agregar Responsiva";
            }
            else
            {
                cb3r.Text = "Agregar Responsiva";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentIDSelected = int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ProdID"].Value.ToString());
                string responsive = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["Responsiva"].Value.ToString();
                
                if (IsService(responsive))
                {
                    handleServiceSelected();
                }
                else
                {
                    handleProductSelected();
                }
            }
            catch(Exception exception) {
                Notifications.NotificationsCenter.ShowErrorMessageForException(exception);
            }
        }

        private bool IsService(string id)
        {
            return id == "1";
        }

        private void handleProductSelected()
        {
            var productSelected = new ProductItem(
                int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ProdID"].Value.ToString()),
                dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["Producto"].Value.ToString(),
                decimal.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["Precio"].Value.ToString()),
                1,
                int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["Existencia"].Value.ToString()),
                false,
                false
                );

            cb1tipo.Text = "PRODUCTO";
            txt1Nombre.Text = productSelected.name;
            txt2Precio.Text = String.Format("{0:0.00}", productSelected.price.ToString());
            cb2um.Text = "Pieza";
            txt3Stock.Text = productSelected.stock.ToString();
            txt3Stock.Enabled = true;
            cb3r.Text = "No agregar Responsiva";
        }

        private void handleServiceSelected()
        {
            var serviceSelected = new Service(
                int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ProdID"].Value.ToString()),
                dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["Producto"].Value.ToString(),
                0,
                0,
                decimal.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["Precio"].Value.ToString())
                );

            cb1tipo.Text = "PRODUCTO";
            txt1Nombre.Text = serviceSelected.description;
            txt2Precio.Text = serviceSelected.price.ToString();
            cb2um.Text = "Pieza";
            txt3Stock.Text = "No aplica";
            txt3Stock.Enabled = false;
            cb3r.Text = "Agregar Responsiva";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            float precio;
            var aplica = float.TryParse(txt2Precio.Text, out precio);
            txt2Precio.Text = (precio + V).ToString() + ".00";
            if ((precio - 10) >= 0)
            {
                downLabel.ForeColor = Color.FromArgb(109, 109, 109);
            }
        }

        private void cb1tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb1tipo.Text == "PRODUCTOS")
            {
                cb3r.Text = "No agregar Responsiva";
            }
            else
            {
                cb3r.Text = "Agregar Responsiva";
            }
            
        }

        private void txt2Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && txt2Precio.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
            float precio;
            var aplica = float.TryParse(txt2Precio.Text, out precio);
            precio -= 10;
            if (precio > 0)
            {
                txt2Precio.Text = precio.ToString() + ".00";
            } 
            else
            {
                downLabel.ForeColor = Color.Red;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txt1Nombre.Text == "" || txt2Precio.Text == "") return;
            
            try
            {
                AddOrUpdateProduct(currentIDSelected.ToString(), txt1Nombre.Text);
                Notifications.NotificationsCenter.ShowSucessMessage("Elemento guardado", "El elemento se actualizo en la base de datos.");
                RefreshForm();
            }
            catch(Exception exception)
            {
                Notifications.NotificationsCenter.ShowErrorMessageForException(exception);
            }
        }

        private void AddOrUpdateProduct(string id, string name)
        {
            var checkQuery = "select * from tblProductos where ProdID = " + id + " and Producto = '" + name + "'";
            if (sqlHelper.MultipleRecords(checkQuery))
            {

                var query = "UPDATE tblProductos SET " +GetName() + GetPrice() + GetStock() + GetResponsive() + "[FReg] = GETDATE() WHERE ProdID = " + id + " and Producto = '" + name + "'";
                sqlHelper.UpdateProduct(query);
            }
            else
            {
                var query = "insert into tblProductos values(" + getType() + ", '" + txt1Nombre.Text + "', " + txt2Precio.Text + ", '0', " + getUM() + ", 1, " + txt3Stock.Text + ", " + getResposive() + ", " + getStockControl() + ", 'Jorge Galvan', GETDATE(), 'A')";
                sqlHelper.AddProduct(query);
            }
        }

        private string GetPrice()
        {
            var newPrice = 0.00;
            var isNewPriceValid = double.TryParse(txt2Precio.Text, out newPrice);
            return isNewPriceValid ? ("[Precio] = " + newPrice + ", ") : "";
        }

        private string GetStock()
        { 
            var newPrice = 0;
            var isNewPriceValid = int.TryParse(txt3Stock.Text, out newPrice);
            return isNewPriceValid? ("[Existencia] =" + newPrice + ", ") : "";
        }

        private string GetResponsive()
        {
            return cb3r.Text == "AgregarResponsiva" ? "[Responsiva] = 1 ," : "[Responsiva] = 0 ,"; 
        }

        private string GetName()
        {
            return "[Producto] ='" + txt1Nombre.Text + "', ";
        }

        private void RefreshForm()
        {
            clearDataGrid();
            FillDataGrid();
        }

        private void clearDataGrid()
        {
            DataTable DT = (DataTable)dataGridView1.DataSource;
            if (DT != null)
            {
                dataGridView1.DataSource = null;
                clearDataGrid();
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void txt2Precio_Click(object sender, EventArgs e)
        {
            
        }

        private void txt2Precio_Leave(object sender, EventArgs e)
        {
            var precio = float.Parse(txt2Precio.Text);
            //if (precio % 0 == 0)
            
            txt2Precio.Text = precio.ToString("n2");
        }

        private void Productos_Paint(object sender, PaintEventArgs e) {}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt1Nombre_Click(object sender, EventArgs e)
        {
            if (txt1Nombre.Text != "")
            {
                AutoCompleter.FillDataGrid(dataGridView1, "SELECT [ProdID] ,[Producto] ,[Precio] ,[Moneda] ,[Existencia] ,[Responsiva] ,[ControlaExist] ,[UReg] ,[FReg] ,[Estatus] FROM tblProductos where Producto like '%" + txt1Nombre.Text + "%'", "Producto");
            }
        }
        
        private void FillDataGrid()
        {
            AutoCompleter.FillDataGrid(dataGridView1, "SELECT [ProdID] ,[Producto] ,[Precio] ,[Moneda] ,[Existencia] ,[Responsiva] ,[ControlaExist] ,[UReg] ,[FReg] ,[Estatus] FROM tblProductos", "Producto");
        }

        private string getType() => cb1tipo.Text == "SERVICIO" ? "1" : "3";
        private string getResposive() => cb3r.Text == "Agregar Responsiva" ? "1":"0";
        private string getStockControl() => cb3r.Text == "Agregar Responsiva" ? "0" : "1";

        private string getUM()
        {
            switch (cb2um.Text)
            {
                case "PIEZA":
                    return "1";

                case "CAJA":
                    return "3";

                case "NO APLICA":
                    return "3";

                default: return "0";
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
