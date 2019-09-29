
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace YOKO.Helpers
{
    public class BasicData
    {
        public static String seller = "Seller";
        
        public static void UpdateSellerName(String Name) => seller = Name;

        public static String GetSellerName() => seller;

        public BasicData() { }

        public bool CheckInternetConnection()
        {
            try
            {
                Ping ping = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply pingReply = ping.Send(host, timeout, buffer, pingOptions);

                return pingReply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }

        public bool CheckDatabaseConnection()
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                try
                {
                    sqlConnection.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}