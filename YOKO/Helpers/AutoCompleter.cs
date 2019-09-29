using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace YOKO.Helpers
{
    public class AutoCompleter
    {
        public static void SetTextboxAutoComplete(TextBox textBox, String SQlQuery, String reference)
        {
            var autoComplete = new AutoCompleteStringCollection();
            var sqlConnection = new SqlConnection(ConnectionString.connectionString);
            
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(SQlQuery, sqlConnection);
            SqlDataReader rr2 = sqlCommand.ExecuteReader();
            rr2.Read();
            while (rr2.Read())
                autoComplete.Add(rr2[reference].ToString());
            rr2.Close();
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource = autoComplete;
            sqlConnection.Close();
        }

        public static void FillDataGrid(DataGridView dataGrid, string query, string table)
        {
            dataGrid.DataSource = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var dataSet = new DataSet();
                    var adapter = new SqlDataAdapter(command);
                    var builder = new SqlCommandBuilder(adapter);

                    adapter.Fill(dataSet, table);
                    var dataTable = dataSet.Tables[table];

                    dataGrid.DataSource = dataSet.Tables[table];
                    dataGrid.ReadOnly = true;
                    dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
        }
    }
}
