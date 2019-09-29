using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YOKO.Models;

namespace YOKO.Helpers
{
    public class SQL
    {

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
                            var subscriptions = new MailSubscription(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2));
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
    }
}
