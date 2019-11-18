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

namespace YOKO
{
    public partial class Productos : Form
    {
        SQL sqlHelper = new SQL();
        SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
        //SqlConnection con1 = new SqlConnection(

        private const float V = 10.00F;

        public Productos()
        {
            InitializeComponent();
            
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            FillDataGrid();

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

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

            string query = "insert into tblProductos values("+getType()+", '"+txt1Nombre.Text+"', "+txt2Precio.Text+", '0', "+getUM()+", 1, "+txt3Stock.Text+", "+getResposive()+", "+getStockControl()+", 'Jorge Galvan', GETDATE(), 'A')";
            
            if (sqlHelper.ExecuteSQLCommand(query))
            {
                Notifications.NotificationsCenter.notifyIcon.ShowBalloonTip(1000, "¡Producto Agregado!", "El producto fue registrado con éxito.", ToolTipIcon.Info);
            }
            else
            {
                Notifications.NotificationsCenter.ShowErrorMessageForConection();
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
            if (txt1Nombre.Text == null) FillDataGrid();
            AutoCompleter.FillDataGrid(dataGridView1, "SELECT [ProdID] ,[Producto] ,[Precio] ,[Moneda] ,[Existencia] ,[Responsiva] ,[ControlaExist] ,[UReg] ,[FReg] ,[Estatus] FROM tblProductos where Producto like '%" + txt1Nombre.Text + "%'", "Producto");
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
    }
}
