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
        SqlConnection conn = new SqlConnection();
        
        public Venta()
        {
            conn.ConnectionString = "Data Source=DESKTOP-5ON2GLQ;Initial Catalog=GoumaoDB;Integrated Security=True";
            InitializeComponent();

            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            using (conn)
            {
                conn.Open();
                String query = "select NombreComercial from tblClientes where NombreComercial like '%" + textBox1.Text + "%'";
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
            }

        }

        private void Venta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goumaoDBDataSet.tblClientes' table. You can move, or remove it, as needed.
            this.tblClientesTableAdapter.Fill(this.goumaoDBDataSet.tblClientes);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblClientesTableAdapter.FillBy(this.goumaoDBDataSet.tblClientes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bunifuTextbox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=DESKTOP-5ON2GLQ;Initial Catalog=GoumaoDB;Integrated Security=True";

            conn.Open();
            string sql = "SELECT * FROM tblClientes where NombreComercial = '" + textBox1.Text + "'";
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
        }
    }
}
