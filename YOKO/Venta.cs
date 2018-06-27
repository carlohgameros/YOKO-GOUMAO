using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YOKO
{
    public partial class Venta : Form
    {
        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet sDs;
        DataTable sTable;
        SqlCommand sCommand2;
        SqlDataAdapter sAdapter2;
        SqlCommandBuilder sBuilder2;
        DataSet sDs2;
        DataTable sTable2;
        SqlConnection conn = new SqlConnection();
        WebBrowser navegador = new WebBrowser();
        WebBrowser navegador2 = new WebBrowser();
        String a, b;
        String str;
        String UMe;
        Decimal suma;
        String Valor;
        Decimal Dolar;
        Decimal Euro;
        

        public Venta()
        {
            InitializeComponent();
            conn.ConnectionString = "Data Source=DESKTOP-5ON2GLQ;Initial Catalog=GoumaoDB;Integrated Security=True";
            DateTimePicker metroDateTime1 = new DateTimePicker();
            metroDateTime1.Value = DateTime.Now;
            str = "0";
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection namesCollection2 = new AutoCompleteStringCollection();
            using (conn)
            {
                conn.Open();
                String query2 = "SELECT * FROM tblProductos";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataReader rr2 = cmd2.ExecuteReader();
                rr2.Read();
                while (rr2.Read())
                    namesCollection2.Add(rr2["Producto"].ToString());
                rr2.Close();
                txtProductos.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtProductos.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtProductos.AutoCompleteCustomSource = namesCollection2;
                conn.Close();
            }
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=DESKTOP-5ON2GLQ;Initial Catalog=GoumaoDB;Integrated Security=True";
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            txtCantidad.Text = "1";
            txtDescuento.Text = "0";
            textBox2.Enabled = false;
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT top 1 Factura FROM tblFacturas order by Factura desc", conn);
            textBox2.Text = (int.Parse(s: command.ExecuteScalar().ToString()) + 1).ToString();
            conn.Close();
            navegador.ScriptErrorsSuppressed = true;
            navegador.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.cargar_datos);
            navegador.Navigate("http://www.lacasadecambio.com/");
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            
            conn.Open();
            string sql = "SELECT * FROM tblClientes where NombreComercial like '%" + bunifuTextbox1.text + "%'";
            sCommand = new SqlCommand(sql, conn);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "NombreComercial");
            sTable = sDs.Tables["NombreComercial"];
            dataGridView1.DataSource = sDs.Tables["NombreComercial"];
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            conn.Close();
            try
            {
                str = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ClienteID"].Value.ToString();
            } catch {} MascotaCliente();
            dataGridView1.Columns[0].Visible = false;
        }

        private void MascotaCliente()
        {
            conn.Open();
            string sql = "select * from tblClientePets where ClienteID = " + str;
            sCommand2 = new SqlCommand(sql, conn);
            sAdapter2 = new SqlDataAdapter(sCommand2);
            sBuilder2 = new SqlCommandBuilder(sAdapter2);
            sDs2 = new DataSet();
            sAdapter2.Fill(sDs2, "ClienteID");
            sTable2 = sDs2.Tables["ClieteID"];
            dataGridView2.DataSource = sDs2.Tables["ClienteID"];
            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                str = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ClienteID"].Value.ToString();
            } catch {} MascotaCliente();
        }

        public void cargar_datos(object sender, EventArgs e)
        {
            a = navegador.Document.GetElementById("tipocambio").InnerText;
            a = a.Replace("PROMEDIO EN CASAS DE CAMBIO", "");
            a = a.Replace("VENTA", System.Environment.NewLine + "VENTA");
            notifyIcon1.ShowBalloonTip(1000, "PROMEDIO EN CASAS DE CAMBIO", a, ToolTipIcon.Info);
            //a = a.Replace("COMPRA", "");
            String valorDolar = a.Substring(0, 3);
            MessageBox.Show(valorDolar);
        }

        public void cargar_datos2(object sender, EventArgs e)
        {
            b = navegador2.Document.GetElementById("exchange-main-description").InnerText;
            notifyIcon1.ShowBalloonTip(1000, "PROMEDIO EN CASAS DE CAMBIO", b, ToolTipIcon.Info);
        }

        private void notifyIcon1_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("http://www.lacasadecambio.com/");
        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e) => System.Diagnostics.Process.Start("http://www.lacasadecambio.com/");
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void txtProductos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double b = double.Parse(txtCantidad.Text) * double.Parse(txtPrecio.Text);
                txtImporte.Text = b.ToString();
            } catch { txtImporte.Text = "0"; }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n = dataGridView3.Rows.Add();
            dataGridView3.Rows[n].Cells[0].Value = txtProductos.Text;
            dataGridView3.Rows[n].Cells[1].Value = txtCantidad.Text + " " + txtUM.Text;
            dataGridView3.Rows[n].Cells[2].Value = "$" + Math.Round(decimal.Parse(txtPrecio.Text), 2);
            dataGridView3.Rows[n].Cells[3].Value = txtDescuento.Text + "%";
            dataGridView3.Rows[n].Cells[4].Value = "$" + int.Parse(txtCantidad.Text) * Math.Round((1 - (decimal.Parse(txtDescuento.Text) / 100)) * decimal.Parse(txtPrecio.Text), 2);
            suma = 0;
            Valor = "";
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                Valor = row.Cells[4].Value.ToString();
                Valor= Valor.Replace("$", " ");
                suma += decimal.Parse(Valor.ToString());
            }
            btnPagar.Text = "$" + suma.ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int columna = int.Parse(e.RowIndex.ToString());
                dataGridView3.Rows.RemoveAt(columna);
                suma = 0;
                Valor = "";
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    Valor = row.Cells[4].Value.ToString();
                    Valor = Valor.Replace("$", " ");
                    suma += decimal.Parse(Valor.ToString());
                }
                btnPagar.Text = "$" + suma.ToString();
            } catch { }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtCantidad.Text) >= 2 && UMe.Length > 0)
                {
                    txtUM.Text = UMe + "s";
                }
                txtImporte.Text = "$" + int.Parse(txtCantidad.Text) * Math.Round((1 - (decimal.Parse(txtDescuento.Text) / 100)) * decimal.Parse(txtPrecio.Text), 2);
            } catch { txtUM.Text = UMe; }
        }
        
        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtImporte.Text = "$" + int.Parse(txtCantidad.Text) * Math.Round((1 - (decimal.Parse(txtDescuento.Text) / 100)) * decimal.Parse(txtPrecio.Text), 2);
            } catch { }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtImporte.Text = "$" + int.Parse(txtCantidad.Text) * Math.Round((1 - (decimal.Parse(txtDescuento.Text) / 100)) * decimal.Parse(txtPrecio.Text), 2);
            } catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "DOLARES" || textBox1.Text == "dOLARES" || textBox1.Text == "doLARES" || textBox1.Text == "dolares")
            {
                txtMoneda.Visible = true;
            }
            else
            {
                txtMoneda.Visible = false;
            }
        }

        private void txtProductos_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (conn)
                {
                    SqlCommand command = new SqlCommand("select * from tblProductos where Producto = '" + txtProductos.Text + "'", conn);
                    conn.Open();
                    SqlDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        txtPrecio.Text = Math.Round(decimal.Parse((read["Precio"].ToString())), 2).ToString();
                        int a = int.Parse(read["UM"].ToString());
                        switch (a)
                        {
                            case 1:
                                txtUM.Text = "Pieza";
                                UMe = "Pieza";
                                break;
                            case 2:
                                txtUM.Text = "Caja";
                                UMe = "Caja";
                                break;
                            case 3:
                                txtUM.Text = "Servicio";
                                UMe = "Servicio";
                                break;
                            default:
                                txtUM.Text = "";
                                UMe = "";
                                break;
                        }
                        txtCantidad.Text = 1.ToString();
                        txtDescuento.Text = 0.ToString();
                        txtImporte.Text = "$" + int.Parse(txtCantidad.Text) * Math.Round((1 - (decimal.Parse(txtDescuento.Text) / 100)) * decimal.Parse(txtPrecio.Text), 2);
                    }
                    read.Close();
                }
            }
        }
    }
}