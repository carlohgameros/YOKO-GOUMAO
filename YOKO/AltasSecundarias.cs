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
    public partial class AltasSecundarias : Form
    {
        DataSet sDs = new DataSet();
        DataTable sTable = new DataTable();
        SqlConnection conn = new SqlConnection();
        SqlCommand sCommand = new SqlCommand();
        SqlDataAdapter sAdapter = new SqlDataAdapter();
        SqlCommandBuilder sBuilder = new SqlCommandBuilder();
        AutoCompleteStringCollection namesCollection2 = new AutoCompleteStringCollection();
        String str;
        String vendedor_a;
        String cliente_id=0.ToString();
        //String vendedor
        public AltasSecundarias()
        {
            InitializeComponent();//vendedor_a = vendedor;
            conn.ConnectionString = ConnectionString.connectionString;
        }

        private void AltasSecundarias_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = ConnectionString.connectionString;
            using (conn)
            {
                conn.Open();
                String query2 = "SELECT NombreComercial FROM tblClientes";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataReader rr2 = cmd2.ExecuteReader();
                rr2.Read();
                while (rr2.Read())
                    namesCollection2.Add(rr2["NombreComercial"].ToString());
                rr2.Close();
                txtAsignar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtAsignar.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtAsignar.AutoCompleteCustomSource = namesCollection2;
                conn.Close();
            }
            

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            // TODO: This line of code loads data into the 'goumaoDBDataSet1.tblRazas' table. You can move, or remove it, as needed.
            //DATASET RAZAS

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            /*conn.Open();
            string sql = "SELECT * FROM tblRazas where Raza like '%" + bunifuMetroTextbox1.Text + "%'";
            sCommand = new SqlCommand(sql, conn);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "Raza");
            sTable = sDs.Tables["Raza"];
            dataGridView1.DataSource = sDs.Tables["Raza"];
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            conn.Close();
            try
            {
                str = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["Raza"].Value.ToString();
            }
            catch { } */
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            conn.ConnectionString = ConnectionString.connectionString;
            conn.Open();
            string sql = "SELECT * FROM tblClientes where NombreComercial like '%" + btn1Nombre.Text + "%'";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            conn.ConnectionString = ConnectionString.connectionString;
            if (btn1Nombre.Text == "")
            {
                //notifyIcon1.ShowBalloonTip(1000, "Error en el formulario", "Se necesita al menos el nombre", ToolTipIcon.Info);
            }
            else
            {
                if (btn2Telefono.Text == "" || btn2Telefono.Text == " ")
                {
                    btn2Telefono.Text = 0.ToString();
                }
                if (btn3Celular.Text == "" || btn3Celular.Text == " ")
                {
                    btn3Celular.Text = 0.ToString();
                }
                if (btn4Email.Text == "" || btn4Email.Text == " ")
                {
                    btn4Email.Text = 0.ToString();
                }
                else
                {
                    conn.Open();
                    string sql = "insert into tblClientes values ('" + btn1Nombre.Text.ToUpper() + "', " + btn2Telefono.Text + ", " + btn3Celular.Text + ", '" + btn4Email.Text + "', '" + vendedor_a + "', getdate())";
                    sCommand = new SqlCommand(sql, conn);
                    try
                    {
                        sCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString() + "" + ex); }
                    GetClienteID();
                    conn.Close();
                    Limpiar();
                    //notifyIcon1.ShowBalloonTip(1000, "¡Usuario " + btn1Nombre.Text + " Agregado!", "¡Bienvenido, " + btn1Nombre.Text + " a Goummao!", ToolTipIcon.Info);
                }
                
            }
        }

        private void GetClienteID()
        {
            //select * from tblClientes WHERE NombreComercial = 'JORGE GALVAN' AND Cel='338 46 92' AND Tel='975 18 71' AND Email = 'jorgegalvanruiz@hotmail.com'
            
        }

        private void Limpiar()
        {
            btn1Nombre.Text = "";
            btn2Telefono.Text = "";
            btn3Celular.Text = "";
            btn4Email.Text = "";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //DATASET CLIENTES
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //DATASET CLIENTES
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //DATASET CLIENTES
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //DATASET CLIENTES
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = ConnectionString.connectionString;

            if (txtAsignar.Text == "" || txtClienteID.Text == "" || txt1MascotaNombre.Text == "" || txt2MascotaRaza.Text == "" || txt3MascotaSexo.Text == "" || txt4MascotaAños.Text == "" || txt5MascotaMes.Text == "")
            {
                //notifyIcon1.ShowBalloonTip(1000, "Error en el formulario", "Falta llenar al menos un campo", ToolTipIcon.Info);
            } else {
                conn.Open();
                string sql = "insert into tblClientePets values ('" + txtClienteID.Text + "','" + txt1MascotaNombre.Text.ToUpper() + "', " + txt2MascotaRaza.Text + ", " + txt3MascotaSexo.Text + ", " + txt4MascotaAños.Text + ", '" + txt5MascotaMes.Text + "', 0 )";
                sCommand = new SqlCommand(sql, conn);
                try
                {
                    sCommand.ExecuteNonQuery();
                    //notifyIcon1.ShowBalloonTip(1000, "¡Mascota " + txt1MascotaNombre.Text + " Agregada!", "Asigando a " + txtAsignar.Text + " con éxito.", ToolTipIcon.Info);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                conn.Close();
                Limpiar();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtClienteID.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ClienteID"].Value.ToString();
                txtAsignar.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["NombreComercial"].Value.ToString();
            }
            catch { }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.ConnectionString = ConnectionString.connectionString;
            conn.Open();
            string sql = "SELECT * FROM tblClientes where NombreComercial like '%" + txtAsignar.Text + "%'";
            sCommand = new SqlCommand(sql, conn);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "NombreComercial");
            sTable = sDs.Tables["NombreComercial"];
            dataGridView1.DataSource = sDs.Tables["NombreComercial"];
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sqlID = "SELECT ClienteID FROM tblClientes where NombreComercial like '%" + txtAsignar.Text + "%'";
            sCommand = new SqlCommand(sqlID, conn);
            txtClienteID.Text = sCommand.ExecuteScalar().ToString();
            conn.Close();
        }
    }
}
