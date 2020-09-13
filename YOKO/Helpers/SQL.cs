using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using YOKO.enums;
using YOKO.Models;
using YOKO.Resources;

namespace YOKO.Helpers
{
    public class SQL
    {
        #region General
        public List<MailSubscription> GetDictionaryFromSQL(string query)
        {
            List<MailSubscription> mailSubscriptions = new List<MailSubscription>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MailSubscription subscriptions = new MailSubscription(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2));
                            mailSubscriptions.Add(subscriptions);
                        }
                    }
                }
            }

            return mailSubscriptions;
        }

        public bool ExecuteSQLCommand(string query)
        {
            bool success = false;

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        success = reader.RecordsAffected > 0;
                    }
                }
            }

            return success;
        }

        public KeyValuePair<bool, string> getEquivalent(string query)
        {
            KeyValuePair<bool, string> result = new KeyValuePair<bool, string>(false, "0");
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = new KeyValuePair<bool, string>(true, reader.GetInt32(0).ToString());
                        }
                    }
                }
                connection.Close();
            }

            return result;
        }

        public bool MultipleRecords(string query)
        {
            bool currentStatus = false;

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.FieldCount > 0)
                        {
                            currentStatus = true;
                        }
                    }
                }
                connection.Close();
            }

            return currentStatus;
        }

        #endregion General

        #region Pets request
        public PetStatusEnum GetPetStatus(string petID)
        {
            List<string> previousStatus = new List<string>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT TOP (1000) [color] FROM tblPetsRegistro where petId = " + petID, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            previousStatus.Add(reader.GetString(0));
                        }
                    }
                }
                connection.Close();
            }

            if (previousStatus.Count == 0)
            {
                return PetStatusEnum.SinRegistro;
            }

            foreach (string status in previousStatus)
            {
                if (status == "Rojo")
                {
                    return PetStatusEnum.RegistrosNegativos;
                }
            }

            return PetStatusEnum.SinRegistrosNegativos;
        }
        #endregion Pets request

        #region Products

        public void AddProduct(string query)
        {
            ExecuteSQLCommand(query);
        }

        public void UpdateProduct(string query)
        {
            ExecuteSQLCommand(query);
        }
        #endregion

        #region Services
        public List<Service> getCurrentServices()
        {
            List<Service> currentServices = new List<Service>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(Constants.currentServices, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //currentServices.Add(
                            //  reader.GetInt32(0),
                            //);
                        }
                    }
                }
                connection.Close();
            }

            return currentServices;
        }

        public void setCurrentStatus(int petID)
        {
            
        }
        #endregion

        #region Legal Information
        public DataTable getLegalInformation()
        {
            DataTable legalInformationDataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(Constants.legalServices, connection))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                    sqlDataAdapter.Fill(legalInformationDataTable);
                }
                connection.Close();
            }

            return legalInformationDataTable;
        }
        #endregion

        #region Sells
        public int getSellsCount()
        {
            var count = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(Constants.sellsCount, connection))
                {
                    count = int.Parse(s: command.ExecuteScalar().ToString()) + 1;
                }
                connection.Close();
            }

            return count;
        }
        #endregion

        #region Pet Register

        public List<PetRegister> GetPetRegister(int petID)
        { 
            var petRegister = new List<PetRegister>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(Constants.petRegister + petID + "'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            petRegister.Add(new PetRegister(reader.GetInt32(0), petID, reader.GetString(2), reader.GetDateTime(3), reader.GetString(4)));
                        }
                    }
                }
                connection.Close();
            }

            return petRegister;
        }

        public void FillPetRegister(int petID, DataGridView dataGrid)
        {
            using (var connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                var query = Constants.petRegisterOnlyData + petID + "' and description != ''";
                var adapter = new SqlDataAdapter(new SqlCommand(query, connection));
                using (var Builder = new SqlCommandBuilder(adapter))
                {
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet, "description");
                    
                    dataGrid.DataSource = dataSet.Tables["description"];
                    dataGrid.ReadOnly = true;
                    dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGrid.Columns[0].HeaderText = "Nota";
                    dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGrid.Columns[1].HeaderText = "Fecha";
                    
                }
                connection.Close();
            }
        }

        public bool SavePetRegister(PetRegister petRegister)
        {
            var query = "insert into tblPetRegister values (" + petRegister.ownerID + ", " + petRegister.petID + ", '" + petRegister.description + "', GETDATE(), '" + petRegister.status +"')";
            return ExecuteSQLCommand(query);
        }

        public bool IsDangerousPet(int petID)
        {
            bool isDangerous = false;
            foreach(PetRegister register in GetPetRegister(petID))
            {
                if (register.status == "Rojo")
                {
                    isDangerous = true;
                    break;
                }
            }

            return isDangerous;
        }

        #endregion

        #region Tickets
        public void fillTicketsList(string query, DataGridView dataGrid)
        {
            using (var connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                var adapter = new SqlDataAdapter(new SqlCommand(query, connection));
                using (var Builder = new SqlCommandBuilder(adapter))
                {
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet, "Factura");

                    dataGrid.DataSource = dataSet.Tables["Factura"];
                    dataGrid.ReadOnly = true;
                    dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                connection.Close();
            }
        }

        public void fillUsersList(string name, DataGridView dataGrid)
        {
            using (var connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                var query = Constants.usersList + name + "%'";
                var adapter = new SqlDataAdapter(new SqlCommand(query, connection));
                using (var Builder = new SqlCommandBuilder(adapter))
                {
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet, "UsrName");

                    dataGrid.DataSource = dataSet.Tables["UsrName"];
                    dataGrid.ReadOnly = true;
                    dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGrid.ColumnHeadersVisible = false;
                }
                connection.Close();
            }
        }

        public void fillContactList(string name, DataGridView dataGrid)
        {
            using (var connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                var query = Constants.clientList + name + "%'";
                var adapter = new SqlDataAdapter(new SqlCommand(query, connection));
                using (var Builder = new SqlCommandBuilder(adapter))
                {
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet, "NombreComercial");

                    dataGrid.DataSource = dataSet.Tables["NombreComercial"];
                    dataGrid.ReadOnly = true;
                    dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGrid.ColumnHeadersVisible = false;
                    dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                connection.Close();
            }
        }

        public bool saveTicketInformation(int factura, string clienteID, decimal total)
        {
            var newTotal = SettingsHelper.getInstance().isIVAActive ? (total + GetAmmountWithIVA(total)) : total;
            string query = "INSERT INTO tblFacturas VALUES ("+ factura + " , 1, GETDATE(), " + clienteID + " ,"+total+" ,"+GetAmmountWithIVA(total)+" ,"+newTotal+" ,'"+ToLetter(total)+"' ,GETDATE() ,1 ,'"+BasicData.GetSellerName()+"' ,GETDATE() ,'"+'.'+"' ,'"+total+"' ,'' ,3 ,1 ,'')";

            return ExecuteSQLCommand(query);
        }

        private decimal GetAmmountWithIVA(decimal ammount)
        {
            return ammount * ((SettingsHelper.getInstance().GetIVA() / 100));
        }

        private static string ToLetter(decimal value)
        {
            string num2Text; value = Math.Truncate(value);
            if (value == 0) num2Text = "CERO";
            else if (value == 1) num2Text = "UNO";
            else if (value == 2) num2Text = "DOS";
            else if (value == 3) num2Text = "TRES";
            else if (value == 4) num2Text = "CUATRO";
            else if (value == 5) num2Text = "CINCO";
            else if (value == 6) num2Text = "SEIS";
            else if (value == 7) num2Text = "SIETE";
            else if (value == 8) num2Text = "OCHO";
            else if (value == 9) num2Text = "NUEVE";
            else if (value == 10) num2Text = "DIEZ";
            else if (value == 11) num2Text = "ONCE";
            else if (value == 12) num2Text = "DOCE";
            else if (value == 13) num2Text = "TRECE";
            else if (value == 14) num2Text = "CATORCE";
            else if (value == 15) num2Text = "QUINCE";
            else if (value < 20) num2Text = "DIECI" + ToLetter(value - 10);
            else if (value == 20) num2Text = "VEINTE";
            else if (value < 30) num2Text = "VEINTI" + ToLetter(value - 20);
            else if (value == 30) num2Text = "TREINTA";
            else if (value == 40) num2Text = "CUARENTA";
            else if (value == 50) num2Text = "CINCUENTA";
            else if (value == 60) num2Text = "SESENTA";
            else if (value == 70) num2Text = "SETENTA";
            else if (value == 80) num2Text = "OCHENTA";
            else if (value == 90) num2Text = "NOVENTA";
            else if (value < 100) num2Text = ToLetter(Math.Truncate(value / 10) * 10) + " Y " + ToLetter(value % 10);
            else if (value == 100) num2Text = "CIEN";
            else if (value < 200) num2Text = "CIENTO " + ToLetter(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) num2Text = ToLetter(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) num2Text = "QUINIENTOS";
            else if (value == 700) num2Text = "SETECIENTOS";
            else if (value == 900) num2Text = "NOVECIENTOS";
            else if (value < 1000) num2Text = ToLetter(Math.Truncate(value / 100) * 100) + " " + ToLetter(value % 100);
            else if (value == 1000) num2Text = "MIL";
            else if (value < 2000) num2Text = "MIL " + ToLetter(value % 1000);
            else if (value < 1000000)
            {
                num2Text = ToLetter(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0)
                {
                    num2Text = num2Text + " " + ToLetter(value % 1000);
                }
            }
            else if (value == 1000000)
            {
                num2Text = "UN MILLON";
            }
            else if (value < 2000000)
            {
                num2Text = "UN MILLON " + ToLetter(value % 1000000);
            }
            else if (value < 1000000000000)
            {
                num2Text = ToLetter(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0)
                {
                    num2Text = num2Text + " " + ToLetter(value - Math.Truncate(value / 1000000) * 1000000);
                }
            }
            else if (value == 1000000000000) num2Text = "UN BILLON";
            else if (value < 2000000000000) num2Text = "UN BILLON " + ToLetter(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                num2Text = ToLetter(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0)
                {
                    num2Text = num2Text + " " + ToLetter(value - Math.Truncate(value / 1000000000000) * 1000000000000);
                }
            }
            return num2Text;
        }
        #endregion
    }
}
