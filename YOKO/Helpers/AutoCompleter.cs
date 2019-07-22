using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YOKO.Helpers
{
    public class AutoCompleter
    {
        public static void SetTextboxAutoComplete(TextBox textBox, String SQlQuery, String reference)
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            SqlConnection sqlConnection = CreateSQLConnection();
            
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

        public static SqlConnection CreateSQLConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConnectionString.connectionString;
            return sqlConnection;
        }
    }
}
