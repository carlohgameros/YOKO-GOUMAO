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
using YOKO.Helpers;

namespace YOKO
{
    public partial class AltasSecundarias : Form
    {
        SQL sqlHelper = new SQL();
        DataSet sDs = new DataSet();
        DataTable sTable = new DataTable();
        SqlConnection conn = new SqlConnection();
        SqlCommand sCommand = new SqlCommand();
        SqlDataAdapter sAdapter = new SqlDataAdapter();
        SqlCommandBuilder sBuilder = new SqlCommandBuilder();
        AutoCompleteStringCollection namesCollection2 = new AutoCompleteStringCollection();

        string newName = "";
        string newTel = "0";
        string newCel = "0";
        string newMail = "";

        string cliente_id = 0.ToString();
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
            newName = btn1Nombre.Text;

            string query = "SELECT * FROM tblClientes where NombreComercial like '%" + btn1Nombre.Text + "%'";
            AutoCompleter.FillDataGrid(dataGridView1, query, "NombreComercial");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if (btn1Nombre.Text.Trim() == "")
            {
                //notifyIcon1.ShowBalloonTip(1000, "Error en el formulario", "Se necesita al menos el nombre", ToolTipIcon.Info);
            }
            else
            {
                string query = "insert into tblClientes values ('" + newName + "', " + newCel + ", " + newTel + ", '" + newMail + "', null, getdate(), 1)";

                if (sqlHelper.ExecuteSQLCommand(query))
                {
                    Notifications.NotificationsCenter.notifyIcon.ShowBalloonTip(1000, "¡Usuario " + btn1Nombre.Text + " Agregado!", "¡Bienvenido, " + btn1Nombre.Text + " a Goummao!", ToolTipIcon.Info);
                }
                else
                {
                    Notifications.NotificationsCenter.ShowErrorMessageForConection();
                }
                
                GetClienteID();
                Limpiar();
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
            if (txtAsignar.Text == "" || txtClienteID.Text == "" || txt1MascotaNombre.Text == "" || txt2MascotaRaza.Text == "" || txt3MascotaSexo.Text == "")
            {
                Notifications.NotificationsCenter.notifyIcon.ShowBalloonTip(1000, "Error en el formulario", "Se necesita al menos el nombre", ToolTipIcon.Info);
            }
            else
            { 
                var years = txt4MascotaAños.Text == "" ? "0" : "0";
                var month = txt5MascotaMes.Text == "" ? "0" : "0";
                string query = "insert into tblClientePets values ('" + txtClienteID.Text + "','" + txt1MascotaNombre.Text.ToUpper() + "', " + getBreed() + ", " + getPetSex() + ", " + years + ", '" + month + "', 0, null)";
                
                if (sqlHelper.ExecuteSQLCommand(query))
                {
                    Notifications.NotificationsCenter.notifyIcon.ShowBalloonTip(1000, "¡Mascota " + txt1MascotaNombre.Text + " Agregada!", "Asigando a " + txtAsignar.Text + " con éxito.", ToolTipIcon.Info);
                }
                else
                {
                    Notifications.NotificationsCenter.ShowErrorMessageForConection();
                }

                GetClienteID();
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
            try { txtClienteID.Text = sCommand.ExecuteScalar().ToString(); } catch { }
            conn.Close();
        }

        private void navigationBar1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
        }

        private void btn3Celular_OnValueChanged(object sender, EventArgs e)
        {
            newCel = btn3Celular.Text;
        }

        private void btn2Telefono_OnValueChanged(object sender, EventArgs e)
        {
            newTel = btn2Telefono.Text;
        }

        private void btn4Email_OnValueChanged(object sender, EventArgs e)
        {
            newMail = btn4Email.Text;
        }

        private string getBreed()
        {
            string query = "SELECT TOP 1 RazaID FROM tblRazas where Raza like '%" + txt2MascotaRaza.Text + "%'";
            var result = sqlHelper.getEquivalent(query);

            if (result.Key)
            {
                return result.Value;
            }
            else
            {
                return "0";
            }
        }

        private string getPetSex()
        {
            string query = "SELECT TOP 1 [SexoID] FROM tblPetSexo where SexoD like '%" + txt3MascotaSexo.Text + "%'";
            var result = sqlHelper.getEquivalent(query);

            if (result.Key)
            {
                return result.Value;
            }
            else
            {
                return "0";
            }
        }
    }
}
