using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YOKO.Models;
using YOKO.Helpers;
using YOKO.enums;
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

        public KeyValuePair<bool, string> getEquivalent(string query)
        {
            var result = new KeyValuePair<bool, string>(false, "0");
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
            }
            
            return result;
        }

        public bool MultipleRecords(string query)
        {
            var currentStatus = false;

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
            }

            return currentStatus;
        }

        #endregion General

        #region Pets request
        public PetStatusEnum GetPetStatus(string petID)
        {
            var currentStatus = new PetStatusEnum();
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
            }

            if (previousStatus.Count == 0) return PetStatusEnum.SinRegistro;

            foreach (string status in previousStatus)
            {
                if (status == "Rojo") return PetStatusEnum.RegistrosNegativos;
            }

            return PetStatusEnum.SinRegistrosNegativos;
        }
        #endregion Pets request

        #region Services
        public List<Service> getCurrentServices()
        {
            var currentServices = new List<Service>();
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
            }

            return currentServices;
        }
        #endregion
    }
}
