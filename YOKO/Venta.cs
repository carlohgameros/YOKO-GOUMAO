using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using YOKO.enums;
using YOKO.Helpers;
using YOKO.Interfaces;
using YOKO.Models;
using YOKO.Notifications;
using YOKO.Service_Additional_Information;
using YOKO.ViewModels;


namespace YOKO
{
    public partial class Venta : Form, ITicketHelper, IServiceInformationAdded
    {
        private SQL sqlHelper = new SQL();
        private SqlCommand sCommand;
        private SqlDataAdapter sAdapter;
        private SqlCommandBuilder sBuilder;
        private DataSet sDs;
        private DataTable sTable;
        private SqlCommand sCommand2;
        private SqlDataAdapter sAdapter2;
        private SqlCommandBuilder sBuilder2;
        private DataSet sDs2;
        private DataTable sTable2;
        private SqlConnection conn = new SqlConnection();
        private ProductItem selectedProduct;
        private Seller seller = new Seller();
        private List<ProductItem> products = new List<ProductItem>();
        private List<Service> services = new List<Service>();
        private SettingsHelper settingsHelper;
        private ExchangePrice exchangePrice;

        private string campo = "NombreComercial";
        private string UMe;
        private string Valor;
        private string petID;
        private double total = 0.00;


        public Venta()
        {
            InitializeComponent();
            conn.ConnectionString = ConnectionString.connectionString;
            DateTimePicker metroDateTime1 = new DateTimePicker
            {
                Value = DateTime.Now
            };
            AutoCompleter.SetTextboxAutoComplete(txtProductos, "SELECT * FROM tblProductos", "Producto");
            settingsHelper = SettingsHelper.getInstance();
            exchangePrice = new ExchangePrice();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "NO ESTATUS";
            conn.ConnectionString = ConnectionString.connectionString;
            BaseTableDesiner.SetDefaultStyle(clientes);
            BaseTableDesiner.SetDefaultStyle(mascotas);
            BaseTableDesiner.SetDefaultStyle(lista);
            BaseTableDesiner.SetDefaultStyle(registro);
            txtCantidad.Text = "1";
            txtDescuento.Text = "0";
            textBox2.Enabled = false;
            textBox2.Text = sqlHelper.getSellsCount().ToString();
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
                string clientID = clientes.Rows[clientes.SelectedRows[0].Index].Cells["ClienteID"].Value.ToString();
                string clientName = clientes.Rows[clientes.SelectedRows[0].Index].Cells["NombreComercial"].Value.ToString();
                string clientPhone = clientes.Rows[clientes.SelectedRows[0].Index].Cells["Cel"].Value.ToString();
                string clientAlternative = clientes.Rows[clientes.SelectedRows[0].Index].Cells["Tel"].Value.ToString();
                string clientEmail = clientes.Rows[clientes.SelectedRows[0].Index].Cells["Email"].Value.ToString();
                Client newCurentClient = new Client(clientID, clientName, clientPhone, clientAlternative, clientEmail);
                CurrentClient.SetCurrentClient(newCurentClient);
            }
            catch { }
            MascotaCliente();
            clientes.Columns[0].Visible = false;
        }

        private void SetNewCurrentClient(Client newCurrentClient)
        {
            CurrentClient.SetCurrentClient(newCurrentClient);
        }

        private void MascotaCliente()
        {
            conn.Open();
            string sql = "select * from tblClientePets where ClienteID = " + CurrentClient.GetID();
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
                string clientID = clientes.Rows[clientes.SelectedRows[0].Index].Cells["ClienteID"].Value.ToString();
                string clientName = clientes.Rows[clientes.SelectedRows[0].Index].Cells["NombreComercial"].Value.ToString();
                string clientPhone = clientes.Rows[clientes.SelectedRows[0].Index].Cells["Cel"].Value.ToString();
                string clientAlternative = clientes.Rows[clientes.SelectedRows[0].Index].Cells["Tel"].Value.ToString();
                string clientEmail = clientes.Rows[clientes.SelectedRows[0].Index].Cells["Email"].Value.ToString();
                Client newCurentClient = new Client(clientID, clientName, clientPhone, clientAlternative, clientEmail);
                CurrentClient.SetCurrentClient(newCurentClient);
            }
            catch { }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = int.Parse(mascotas.Rows[mascotas.SelectedRows[0].Index].Cells["MascotaID"].Value.ToString());
                string name = mascotas.Rows[mascotas.SelectedRows[0].Index].Cells["Mascota"].Value.ToString();
                CurrentPet.SetCurrentPet(new CurrentPet(id, name, 0, ""));
                handlePetRegister();
                PetNote.Enabled = true;
            }
            catch (Exception ex)
            {
                NotificationsCenter.ShowErrorMessageForException(ex);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtProductos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double b = double.Parse(txtCantidad.Text) * double.Parse(txtPrecio.Text);
                txtImporte.Text = b.ToString();
            }
            catch { txtImporte.Text = "0"; }
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
            total = 0;
            Valor = "";
            foreach (DataGridViewRow row in lista.Rows)
            {
                Valor = row.Cells[5].Value.ToString();
                Valor = Valor.Replace("$", " ");
                total += double.Parse(Valor.ToString());
            }
            SetAmmount();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int columna = int.Parse(e.RowIndex.ToString());
                lista.Rows.RemoveAt(columna);
                total = 0;
                Valor = "";
                foreach (DataGridViewRow row in lista.Rows)
                {
                    Valor = row.Cells[5].Value.ToString();
                    Valor = Valor.Replace("$", " ");
                    total += double.Parse(Valor.ToString());
                }
                SetAmmount();
            }
            catch { }
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
            }
            catch { txtUM.Text = UMe; }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtImporte.Text = "$" + int.Parse(txtCantidad.Text) * Math.Round((1 - (decimal.Parse(txtDescuento.Text) / 100)) * decimal.Parse(txtPrecio.Text), 2);
            }
            catch { }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtImporte.Text = "$" + int.Parse(txtCantidad.Text) * Math.Round((1 - (decimal.Parse(txtDescuento.Text) / 100)) * decimal.Parse(txtPrecio.Text), 2);
            }
            catch { }
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

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int observationsColumn = 8;
            int deleteColumn = 9;

            try
            {
                if (e.ColumnIndex == observationsColumn)
                {
                    new ServiceAdditionalInformation(e.RowIndex, int.Parse(lista.Rows[e.RowIndex].Cells["ID"].Value.ToString()), this).Show();
                }
                else if (e.ColumnIndex == deleteColumn)
                {
                    int columna = int.Parse(e.RowIndex.ToString());
                    lista.Rows.RemoveAt(columna);
                    total = 0;
                    Valor = "";
                    foreach (DataGridViewRow row in lista.Rows)
                    {
                        Valor = row.Cells[4].Value.ToString();
                        Valor = Valor.Replace("$", " ");
                        total += double.Parse(Valor.ToString());
                    }
                    SetAmmount();
                }
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
                    txtPrecio.Text = Math.Round(decimal.Parse(read["Precio"].ToString()), 2).ToString();
                    int um = int.Parse(read["UM"].ToString());
                    switch (um)
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
                    decimal importe = int.Parse(txtCantidad.Text) * Math.Round((1 - (decimal.Parse(txtDescuento.Text) / 100)) * decimal.Parse(txtPrecio.Text), 2);
                    txtImporte.Text = "$" + importe;

                    int id = int.Parse(read["ProdID"].ToString());
                    int items = int.Parse(txtCantidad.Text);
                    string name = read["Producto"].ToString();
                    int stock = int.Parse(read["Existencia"].ToString());
                    bool isService = read["ControlaExist"].ToString() != "0";
                    bool isResponsive = read["ControlaExist"].ToString() != "0";

                    selectedProduct = new ProductItem(id, name, importe, items, stock, !isService, !isResponsive);
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
            lista.Rows[n].Cells[0].Value = selectedProduct.id;
            lista.Rows[n].Cells[1].Value = txtProductos.Text;
            lista.Rows[n].Cells[2].Value = txtCantidad.Text;
            lista.Rows[n].Cells[3].Value = "$" + Math.Round(decimal.Parse(txtPrecio.Text), 2);
            lista.Rows[n].Cells[4].Value = txtDescuento.Text + "%";
            lista.Rows[n].Cells[5].Value = int.Parse(txtCantidad.Text) * Math.Round((1 - (decimal.Parse(txtDescuento.Text) / 100)) * decimal.Parse(txtPrecio.Text), 2);
            lista.Rows[n].Cells[6].Value = selectedProduct.stock > 0 ? selectedProduct.stock.ToString() : "";
            lista.Rows[n].Cells[7].Value = selectedProduct.isService;
            lista.Rows[n].Cells["corte"].Value = selectedProduct.id = 171;
            total = 0;
            Valor = "";

            if (lista.Rows[n].Cells[6].Value.ToString() != "" && selectedProduct.stock < 10)
            {
                lista.Rows[n].Cells[6].Style.BackColor = Color.Yellow;
                if (selectedProduct.stock < 3)
                {
                    lista.Rows[n].Cells[6].Style.BackColor = Color.OrangeRed;
                    lista.Rows[n].Cells[6].Style.ForeColor = Color.White;
                }
            }

            foreach (DataGridViewRow row in lista.Rows)
            {
                Valor = row.Cells[5].Value.ToString();
                Valor = Valor.Replace("$", " ");
                total += double.Parse(Valor.ToString());
            }
            SetAmmount();
        }

        private void txtProductos_KeyDown_1(object sender, KeyEventArgs e)
        {
            //conn.Open();
            MessageBox.Show("");

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //string note = PetAddNote.Text;
            // add note to Server
        }

        private void handlePetRegister()
        {
            if (CurrentPet.GetID() != null)
            {
                if ((DataTable)registro.DataSource != null)
                {
                    registro.DataSource = null;
                    registro.Rows.Clear();
                }
                else
                {
                    registro.Rows.Clear();
                }
                sqlHelper.FillPetRegister(CurrentPet.GetID().Value, registro);

                DangerPetIndicator.Enabled = true;
                DangerPetIndicator.Checked = sqlHelper.IsDangerousPet(CurrentPet.GetID().Value);
            }
        }

        private void getPetsWithRegister(SqlCommand sqlCommand)
        {
            conn.ConnectionString = ConnectionString.connectionString;
            conn.Open();
            string sql = "select label from tblPetsRegistro where petId = '" + petID + "'";
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

            PetNote.Enabled = true;
            DangerPetIndicator.Enabled = true;
            registro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            HandlePetStatus();
        }

        private void handlePetsWithNoRegister()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConnectionString.connectionString;
                conn.Open();
                try
                {
                    SqlCommand command = new SqlCommand("insert into tblPetsRegistro values('" + CurrentPet.GetID() + "', 'Primer registro creado', 'Esta mascota ya empezó a generar historial.', 0, 'blanco', GETDATE(), GETDATE(), '" + CurrentClient.GetID() + "')", conn);

                    statusLabel.Text = "Registro comenzado";
                    command.ExecuteNonQuery();
                    //notificationsCenter.CreateDesktopNotification(title: "Primer registro creado", message: "Esta mascota ya empezó a generar historial.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    statusLabel.Text = "Error en el Registro";
                }
            }
        }

        private void clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string clientID = clientes.Rows[clientes.SelectedRows[0].Index].Cells["ClienteID"].Value.ToString();
                string clientName = clientes.Rows[clientes.SelectedRows[0].Index].Cells["NombreComercial"].Value.ToString();
                string clientPhone = clientes.Rows[clientes.SelectedRows[0].Index].Cells["Cel"].Value.ToString();
                string clientAlternative = clientes.Rows[clientes.SelectedRows[0].Index].Cells["Tel"].Value.ToString();
                string clientEmail = clientes.Rows[clientes.SelectedRows[0].Index].Cells["Email"].Value.ToString();
                Client newCurentClient = new Client(clientID, clientName, clientPhone, clientAlternative, clientEmail);
                CurrentClient.SetCurrentClient(newCurentClient);
                MascotaCliente();
            }
            catch { }
        }

        private void HandlePetStatus()
        {
            statusLabel.ForeColor = Color.SeaGreen;
            PetStatusEnum petStatus = sqlHelper.GetPetStatus(petID);
            switch (petStatus)
            {
                case PetStatusEnum.ErrorDeRegistro:
                    statusLabel.Text = "ERROR";
                    break;
                case PetStatusEnum.PocosRegistrosNegativos:
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "PELIGROSO";
                    break;
                case PetStatusEnum.RegistrosNegativos:
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "PELIGROSO";
                    break;
                case PetStatusEnum.SinRegistro:
                    statusLabel.Text = "SIN REGISTRO";
                    break;
                case PetStatusEnum.SinRegistrosNegativos:
                    statusLabel.Text = "ACEPTABLE";
                    break;
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private string setColorForNewRegiter()
        {
            return DangerPetIndicator.Checked == true ? "Rojo" : "Blanco";
        }

        private void pagar_Click(object sender, EventArgs e)
        {
            handlePay();
        }

        private void printTicket()
        {
            new TicketsHelper(this, products, services, sqlHelper.getSellsCount(), total).PrintTicket();
        }

        private void handlePay()
        {
            if (lista.Rows.Count == 0)
            {
                return;
            }
            pagar.Enabled = false;

            foreach (DataGridViewRow row in lista.Rows)
            {
                int id = int.Parse(row.Cells["ID"].Value.ToString());
                string product = row.Cells["Productos"].Value.ToString();
                int cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString());
                decimal precio = decimal.Parse(row.Cells["Import"].Value.ToString());
                int stock = 0;
                int.TryParse(row.Cells["Inv"].Value.ToString(), out stock);
                bool isService = bool.Parse(row.Cells["Servicio"].Value.ToString());

                if (!isService)
                {
                    ProductItem productItem = new ProductItem(id, product, precio, cantidad, stock, isService, isService);
                    products.Add(productItem);
                }
                else
                {
                    Service service = new Service(id, product, CurrentPet.GetID().HasValue ? CurrentPet.GetID().Value : 0, CurrentClient.GetID(), precio);
                    services.Add(service);
                }
            }
            
            printTicket();
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

        private void SetAmmount()
        {
            if (total <= 0)
            {
                totalLabel.Text = "$0.00";
            }

            if (settingsHelper.IsIvaActive())
            {
                var iva = 0.00;
                if (double.TryParse(settingsHelper.GetIVA().ToString(), out iva))
                {
                    total = ((iva / 100) + 1) * total;
                }
                
            }

            totalLabel.Text = "$" + total.ToString() + " | " + getPriceInDolar();
        }

        private string getPriceInDolar()
        {
            if (settingsHelper.ShouldCheckDolarUpdates())
            {
                return "$ " + String.Format("{0:0.00}", (total / exchangePrice.GetDolarPrice()));
            } else
            {
                return "$ " + String.Format("{0:0.00}", (total / settingsHelper.GetDolar()));
            }
        }

        public void ErrorPrinting(Exception exception)
        {
            NotificationsCenter.ShowErrorMessageForException(exception);
            pagar.Enabled = true;
        }

        public void SuccessPrinting()
        {
            NotificationsCenter.ShowSucessMessage("Imprimiendo Ticket", "Revisa la impresora");
            RefreshForm();
            pagar.Enabled = true;
        }

        public void OnServiceInformationAdded(int index, string observaciones, int navaja)
        {
            lista.Rows[index].Cells["Navaja"].Value = navaja;
            lista.Rows[index].Cells["Observacion"].Value = observaciones;

            try
            {
                foreach (DataGridCell cell in lista.Rows[index].Cells)
                {
                    Console.WriteLine("Test for service");
                    Console.WriteLine(lista.Rows[index].Cells[cell.ColumnNumber].Value);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            lista.Rows.Clear();

            DataTable DT = (DataTable)clientes.DataSource;
            if (DT != null)
            {
                clientes.DataSource = null;
                RefreshForm();
            }
            else
            {
                clientes.Rows.Clear();
            }

            DT = (DataTable)mascotas.DataSource;
            if (DT != null)
            {
                mascotas.DataSource = null;
                RefreshForm();
            }
            else
            {
                mascotas.Rows.Clear();
            }

            DT = (DataTable)registro.DataSource;
            if (DT != null)
            {
                registro.DataSource = null;
                RefreshForm();
            }
            else
            {
                registro.Rows.Clear();
            }

            txtProductos.Text = "";
            bunifuTextbox1.text = "";

            products = new List<ProductItem>();
            services = new List<Service>();
        }

        private void petAddRegister_Click(object sender, EventArgs e)
        {
            if (PetNote.Text.Length == 0)
            {
                NotificationsCenter.ShowWarningMessage("Ingrese texto para el registo.");
            }

            try
            {
                var petRegister = new PetRegister(CurrentClient.GetID(), CurrentPet.GetID().Value, PetNote.Text, DateTime.Now, "Verde");
                if (sqlHelper.SavePetRegister(petRegister))
                {
                    NotificationsCenter.ShowSucessMessage("Registro guardado", "Los registros están actualizados en la base de datos.");
                } else
                {
                    NotificationsCenter.ShowErrorMessage("Error intentando guardar el registro.");
                }
            }
            catch (Exception exception)
            {
                NotificationsCenter.ShowErrorMessageForException(exception);
            }

        }

        private void DangerPetIndicator_OnChange(object sender, EventArgs e)
        {
            try
            {
                var petRegister = new PetRegister(CurrentClient.GetID(), CurrentPet.GetID().Value, DangerPetIndicator.Checked ? "Mascota marcada como peligrosa" : "Mascota marcada como no peligrosa", DateTime.Now, "Rojo");
                if (sqlHelper.SavePetRegister(petRegister))
                {
                    NotificationsCenter.ShowSucessMessage("Registro guardado", DangerPetIndicator.Checked ? "Mascota marcada como peligrosa" : "Mascota marcada como no peligrosa");
                }
                else
                {
                    NotificationsCenter.ShowErrorMessage("Error intentando guardar el registro.");
                }

                handlePetRegister();
            }
            catch (Exception exception)
            {
                NotificationsCenter.ShowErrorMessageForException(exception);
            }
        }
    }
}
