using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using YOKO.enums;
using YOKO.Helpers;
using YOKO.Notifications;
using System.Linq;

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
        Object usuarioSelecto;
        Object mascotaSelecta;

        string campo = "NombreComercial";
        string a, b;
        string clienteID;
        string UMe;
        decimal suma;
        string Valor;
        decimal Dolar;
        decimal Euro;
        string vendedor_a;
        string mascotaSelectaId;
        int posY = 0;
        int posX = 0;
        int petStatus;

        public Venta(String vendedor)
        {
            InitializeComponent();
            vendedor_a = vendedor;
            conn.ConnectionString = ConnectionString.connectionString;
            DateTimePicker metroDateTime1 = new DateTimePicker();
            metroDateTime1.Value = DateTime.Now;
            clienteID = "0";
            AutoCompleter.SetTextboxAutoComplete(txtProductos, "SELECT * FROM tblProductos", "Producto");
            petStatus = 0;
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "NO ESTATUS";
            CenterStatusLabel();
            conn.ConnectionString = ConnectionString.connectionString;
            BaseTableDesiner.SetDefaultStyle(clientes);
            BaseTableDesiner.SetDefaultStyle(mascotas);
            BaseTableDesiner.SetDefaultStyle(lista);
            BaseTableDesiner.SetDefaultStyle(registro);
            txtCantidad.Text = "1";
            txtDescuento.Text = "0";
            textBox2.Enabled = false;

            conn.Open();
            SqlCommand command = new SqlCommand("SELECT top 1 Factura FROM tblFacturas order by Factura desc", conn);
            textBox2.Text = (int.Parse(s: command.ExecuteScalar().ToString()) + 1).ToString();
            conn.Close();

            //NotificationsCenter.notifyIcon.ShowBalloonTip(1000, "1", "2", ToolTipIcon.Info);
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT * FROM tblClientes where " + campo + " like '%" + bunifuTextbox1.text + "%'";
            sCommand = new SqlCommand(sql, conn);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "NombreComercial");
            sTable = sDs.Tables["NombreComercial"];
            clientes.DataSource = sDs.Tables["NombreComercial"];
            clientes.ReadOnly = true;
            clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            conn.Close();
            try
            {
                clienteID = clientes.Rows[clientes.SelectedRows[0].Index].Cells["ClienteID"].Value.ToString();
            } catch {}
            MascotaCliente();
            clientes.Columns[0].Visible = false;
        }

        private void MascotaCliente()
        {
            conn.Open();
            string sql = "select * from tblClientePets where ClienteID = " + clienteID;
            sCommand2 = new SqlCommand(sql, conn);
            sAdapter2 = new SqlDataAdapter(sCommand2);
            sBuilder2 = new SqlCommandBuilder(sAdapter2);
            sDs2 = new DataSet();
            sAdapter2.Fill(sDs2, "ClienteID");
            sTable2 = sDs2.Tables["ClieteID"];
            mascotas.DataSource = sDs2.Tables["ClienteID"];
            mascotas.ReadOnly = true;
            mascotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clienteID = clientes.Rows[clientes.SelectedRows[0].Index].Cells["ClienteID"].Value.ToString();
            } catch {}
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mascotaSelectaId = mascotas.Rows[mascotas.SelectedRows[0].Index].Cells["MascotaID"].Value.ToString();
                handlePetRegister();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

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
            if (txtDescuento.Text == "") { txtDescuento.Text = 0.ToString(); }
            if (txtCantidad.Text == "") { txtCantidad.Text = 1.ToString(); }
            int n = lista.Rows.Add();
            lista.Rows[n].Cells[1].Value = txtProductos.Text;
            lista.Rows[n].Cells[2].Value = txtCantidad.Text + " " + txtUM.Text;
            lista.Rows[n].Cells[3].Value = "$" + Math.Round(decimal.Parse(txtPrecio.Text), 2);
            lista.Rows[n].Cells[4].Value = txtDescuento.Text + "%";
            lista.Rows[n].Cells[5].Value = "$" + int.Parse(txtCantidad.Text) * Math.Round((1 - (decimal.Parse(txtDescuento.Text) / 100)) * decimal.Parse(txtPrecio.Text), 2);
            suma = 0;
            Valor = "";
            foreach (DataGridViewRow row in lista.Rows)
            {
                Valor = row.Cells[5].Value.ToString();
                Valor= Valor.Replace("$", " ");
                suma += decimal.Parse(Valor.ToString());
            }
            pagar.Text = "$" + suma.ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int columna = int.Parse(e.RowIndex.ToString());
                lista.Rows.RemoveAt(columna);
                suma = 0;
                Valor = "";
                foreach (DataGridViewRow row in lista.Rows)
                {
                    Valor = row.Cells[5].Value.ToString();
                    Valor = Valor.Replace("$", " ");
                    suma += decimal.Parse(Valor.ToString());
                }
                pagar.Text = "$" + suma.ToString();
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
            if (textBox1.Text.Trim().ToUpper() == "DOLARES")
            {
                txtMoneda.Visible = true;
            }
            else
            {
                txtMoneda.Visible = false;
            }
        }

        private void AgregarUsuario_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<AltasSecundarias>().Count() == 1)
            {
                Application.OpenForms.OfType<AltasSecundarias>().First().WindowState = FormWindowState.Normal;
            }
            else
            {
                AltasSecundarias altasSecundarias = new AltasSecundarias();
                altasSecundarias.Show();
            }
        }

        private void txtProductos_TextChanged_1(object sender, EventArgs e)
        {
            // Aquí
        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int columna = int.Parse(e.RowIndex.ToString());
                lista.Rows.RemoveAt(columna);
                suma = 0;
                Valor = "";
                foreach (DataGridViewRow row in lista.Rows)
                {
                    Valor = row.Cells[4].Value.ToString();
                    Valor = Valor.Replace("$", " ");
                    suma += decimal.Parse(Valor.ToString());
                }
                pagar.Text = "$" + suma.ToString();
            }
            catch { }
        }

        private void txtProductos_KeyDown(object sender, KeyEventArgs e)
        {
            conn.Open();
            if (e.KeyCode == Keys.Enter)
            {
                SqlCommand command = new SqlCommand("select * from tblProductos where Producto = '" + txtProductos.Text + "'", conn);

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
                //read.Close();           
            }
            conn.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtDescuento.Text == "") { txtDescuento.Text = 0.ToString(); }
            if (txtCantidad.Text == "") { txtCantidad.Text = 1.ToString(); }
            int n = lista.Rows.Add();
            lista.Rows[n].Cells[1].Value = txtProductos.Text;
            lista.Rows[n].Cells[2].Value = txtCantidad.Text + " " + txtUM.Text;
            lista.Rows[n].Cells[3].Value = "$" + Math.Round(decimal.Parse(txtPrecio.Text), 2);
            lista.Rows[n].Cells[4].Value = txtDescuento.Text + "%";
            lista.Rows[n].Cells[5].Value = "$" + int.Parse(txtCantidad.Text) * Math.Round((1 - (decimal.Parse(txtDescuento.Text) / 100)) * decimal.Parse(txtPrecio.Text), 2);
            suma = 0;
            Valor = "";
            foreach (DataGridViewRow row in lista.Rows)
            {
                Valor = row.Cells[5].Value.ToString();
                Valor = Valor.Replace("$", " ");
                suma += decimal.Parse(Valor.ToString());
            }
            pagar.Text = "$" + suma.ToString();
        }

        private void txtProductos_KeyDown_1(object sender, KeyEventArgs e)
        {
            //conn.Open();
            MessageBox.Show("");
            
        }

        private void GetUser(object user)
        {
            this.usuarioSelecto = user;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //string note = PetAddNote.Text;
            // add note to Server
        }

        private void getPet(object pet)
        {
            this.mascotaSelecta = pet;
        }

        private void handlePetRegister()
        {
            object sResult;
            using (SqlConnection conn1 = new SqlConnection())
            {
                conn1.ConnectionString = ConnectionString.connectionString;
                conn1.Open();
                sCommand = new SqlCommand("select * from tblPetsRegistro where petId = '" + mascotaSelectaId + "'", conn1);
                sResult = sCommand.ExecuteScalar();
                conn1.Close();
            }

            
            if (sResult != null)
            {
                conn.ConnectionString = ConnectionString.connectionString;
                conn.Open();
                sCommand = new SqlCommand("select * from tblPetsRegistro where petId = '" + mascotaSelectaId + "'", conn);
                int result = int.Parse(sCommand.ExecuteScalar().ToString());
                conn.Close();
                if (result > 0)
                {
                    getPetsWithRegister(sCommand);
                }
                else
                {
                    handlePetsWithNoRegister();
                    petStatus = (int)PetStatusEnum.SinRegistro;
                }
            }
            else
            {
                handlePetsWithNoRegister();
                petStatus = (int)PetStatusEnum.SinRegistro;
            }
        }

        private void getPetsWithRegister(SqlCommand sqlCommand)
        {
            conn.ConnectionString = ConnectionString.connectionString;
            conn.Open();
            string sql = "select petId, label, color from tblPetsRegistro where petId = '" + mascotaSelectaId + "'";
            sCommand2 = new SqlCommand(sql, conn);
            sAdapter2 = new SqlDataAdapter(sCommand2);
            sBuilder2 = new SqlCommandBuilder(sAdapter2);
            sDs2 = new DataSet();
            sAdapter2.Fill(sDs2, "petId");
            sTable2 = sDs2.Tables["petId"];
            registro.DataSource = sDs2.Tables["petId"];
            registro.ReadOnly = true;
            registro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            conn.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (mascotaSelectaId != "" )
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    statusLabel.Text = "GUARDANDO";
                    CenterStatusLabel();
                    conn.ConnectionString = ConnectionString.connectionString;
                    conn.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand("insert into tblPetsRegistro values('" + mascotaSelectaId + "', 'Registro realizado desde YOKO.', '" + PetNote.Text.ToString() + ".', 0, '" + setColorForNewRegiter() + "', GETDATE(), GETDATE(), '" + clienteID + "')", conn);

                        this.statusLabel.Text = "Registro comenzado";
                        command.ExecuteNonQuery();
                        //notificationsCenter.CreateDesktopNotification(title: "Primer registro creado", message: "Esta mascota ya empezó a generar historial.");
                        statusLabel.Text = "REGISTRO COMPLETADO";
                        CenterStatusLabel();
                        string sql = "select * from tblPetsRegistro where petId = '" + mascotaSelectaId + "'";
                        sCommand2 = new SqlCommand(sql, conn);
                        getPetsWithRegister(sCommand2);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.statusLabel.Text = "Error en el Registro";
                        statusLabel.Text = "ERROR";
                        CenterStatusLabel();
                    }
                }
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void handlePetsWithNoRegister()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConnectionString.connectionString;
                conn.Open();
                try
                {
                    SqlCommand command = new SqlCommand("insert into tblPetsRegistro values('" + mascotaSelectaId + "', 'Primer registro creado', 'Esta mascota ya empezó a generar historial.', 0, 'blanco', GETDATE(), GETDATE(), '" + clienteID + "')", conn);
                    
                    this.statusLabel.Text = "Registro comenzado";
                    CenterStatusLabel();
                    command.ExecuteNonQuery();
                    //notificationsCenter.CreateDesktopNotification(title: "Primer registro creado", message: "Esta mascota ya empezó a generar historial.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.statusLabel.Text = "Error en el Registro";
                    CenterStatusLabel();
                }
            }
        }
        private void clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clienteID = clientes.Rows[clientes.SelectedRows[0].Index].Cells["ClienteID"].Value.ToString();
                MascotaCliente();
            }
            catch { }
        }

        private void HandlePetStatus()
        {
            switch (petStatus)
            {
                case (int) PetStatusEnum.ErrorDeRegistro:
                    statusLabel.Text = "ERROR";
                    break;
                case (int) PetStatusEnum.PocosRegistrosNegativos:
                    statusLabel.Text = "PELIGROSO";
                    break;
                case (int)PetStatusEnum.RegistrosNegativos:
                    statusLabel.Text = "PELIGROSO";
                    break;
                case (int)PetStatusEnum.SinRegistro:
                    statusLabel.Text = "SIN REGISTRO";
                    break;
                case (int)PetStatusEnum.SinRegistrosNegativos:
                    statusLabel.Text = "ACEPTABLE";
                    break;
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e) => Close();

        private void bunifuImageButton3_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private String setColorForNewRegiter() => DangerPetIndicator.Checked == true ? "Rojo" : "Blanco";

        private void pagar_Click(object sender, EventArgs e)
        {
            handlePay();
        }

        private void handlePay()
        {
            if (lista.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in lista.Rows)
                {
                    Valor = row.Cells[4].Value.ToString();
                    Valor = Valor.Replace("$", " ");
                    suma += decimal.Parse(Valor.ToString());
                }
            } 
        }

        private void lista_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Change occured.");
        }

        private void txtProductos_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void clienteCB_OnChange(object sender, EventArgs e)
        {
            campo = "NombreComercial";
            clienteCB.Checked = true;
            telefonoCB.Checked = false;
            celularCB.Checked = false;
        }

        private void telefonoCB_OnChange(object sender, EventArgs e)
        {
            campo = "Tel";
            clienteCB.Checked = false;
            telefonoCB.Checked = true;
            celularCB.Checked = false;
        }

        private void celularCB_OnChange(object sender, EventArgs e)
        {
            campo = "Cel";
            clienteCB.Checked = false;
            telefonoCB.Checked = false;
            celularCB.Checked = true;
        }

        private void mascotaCB_OnChange(object sender, EventArgs e)
        {

        }

        private void navigationBar1_Load(object sender, EventArgs e)
        {

        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Productos>().Count() == 1)
            {
                Application.OpenForms.OfType<Productos>().First().WindowState = FormWindowState.Normal;
            }
            else
            {
                Productos productos = new Productos();
                productos.Show();
            }
        }

        private void AgregarMascota_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AltasSecundarias>().Count() == 1)
            {
                Application.OpenForms.OfType<AltasSecundarias>().First().WindowState = FormWindowState.Normal;
            }
            else
            {
                AltasSecundarias altasSecundarias = new AltasSecundarias();
                altasSecundarias.Show();
            }
        }

        private void CenterStatusLabel() => statusLabel.Left = (statusPanel.Width / 2) - (statusLabel.Width / 2);
    }
}