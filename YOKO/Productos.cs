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

namespace YOKO
{
    public partial class Productos : Form
    {
        SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
        //SqlConnection con1 = new SqlConnection(

        private const float V = 10.00F;

        public Productos()
        {
            InitializeComponent();
            
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goumaoDBDataSet4.tblUM' table. You can move, or remove it, as needed.
            //this.tblUMTableAdapter.Fill(this.goumaoDBDataSet4.tblUM);

            // TODO: This line of code loads data into the 'goumaoDBDataSet4.tblCategoria' table. You can move, or remove it, as needed.
            //this.tblCategoriaTableAdapter.Fill(this.goumaoDBDataSet4.tblCategoria);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            // TODO: This line of code loads data into the 'goumaoDBDataSet4.tblProductos' table. You can move, or remove it, as needed.
            //this.tblProductosTableAdapter.Fill(this.goumaoDBDataSet4.tblProductos);
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
            MessageBox.Show("");
            //if () { }
            /*conn.Open();
            int tipo, UM, Responsiva;
            String tipoText = cb1tipo.Text, UMText = cb2um.Text, ResponsivaText = cb3r.Text;
            switch (tipoText)
                case "Prodcutos":

                SqlCommand sqlCommand = new SqlCommand("insert into tblProductos values(3, 'test', 1.00, 0, 3, 1, 1, 1, 0, 'Jorge Galvan', GETDATE(), 'A')", conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();*/
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
    }
}
