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
        string a, b;
        string str;

        public Venta()
        {
            InitializeComponent();
            DateTimePicker metroDateTime1 = new DateTimePicker();
            metroDateTime1.Value = DateTime.Now;
            str = "0";
            conn.ConnectionString = "Data Source=DESKTOP-5ON2GLQ;Initial Catalog=GoumaoDB;Integrated Security=True";
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            /*using (conn)
            {
                conn.Open();
                String query = "select NombreComercial from tblClientes where NombreComercial like '%" + metroTextBox1.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rr = cmd.ExecuteReader();
                rr.Read();
                while (rr.Read())
                    namesCollection.Add(rr["NombreComercial"].ToString());
                rr.Close();
                textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox1.AutoCompleteCustomSource = namesCollection;
                conn.Close();
            }*/
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            conn.ConnectionString = "Data Source=DESKTOP-5ON2GLQ;Initial Catalog=GoumaoDB;Integrated Security=True";
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
            conn.ConnectionString = "Data Source=DESKTOP-5ON2GLQ;Initial Catalog=GoumaoDB;Integrated Security=True";

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
            }
            catch {}
            MascotaCliente();
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
            }
            catch {}
            MascotaCliente();
        }

        public void cargar_datos(object sender, EventArgs e)
        {
            a = navegador.Document.GetElementById("tipocambio").InnerText;
            a = a.Replace("PROMEDIO EN CASAS DE CAMBIO", "");
            a = a.Replace("VENTA", System.Environment.NewLine + "VENTA");
            notifyIcon1.ShowBalloonTip(1000, "PROMEDIO EN CASAS DE CAMBIO", a, ToolTipIcon.Info);
        }

        public void cargar_datos2(object sender, EventArgs e)
        {
            b = navegador2.Document.GetElementById("exchange-main-description").InnerText;
            notifyIcon1.ShowBalloonTip(1000, "PROMEDIO EN CASAS DE CAMBIO", b, ToolTipIcon.Info);
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.lacasadecambio.com/");
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e) => System.Diagnostics.Process.Start("http://www.lacasadecambio.com/");
    }
}
