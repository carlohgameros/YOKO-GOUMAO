﻿using System;
using System.Net;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using YOKO.Notifications;

namespace YOKO.Helpers
{
    public class ExchangePrice
    {
        string url = "https://api.exchangeratesapi.io/latest?base=USD&symbols=MXN";
        string html = string.Empty;
        string exchangeRate = string.Empty;

        public ExchangePrice()
        {
            
        }

        public double GetDolarPrice()
        {
            if (!SettingsHelper.getInstance().ShouldCheckDolarUpdates())
            {
                double dolarSaved = 20.0;
                bool isValid = double.TryParse(SettingsHelper.getInstance().GetIVA().ToString(), out dolarSaved);
                return isValid ? dolarSaved : 20.0;
            }

            if (!new BasicData().CheckInternetConnection())
            {
                double dolarSaved = 20.0;
                bool isValid = double.TryParse(SettingsHelper.getInstance().GetIVA().ToString(), out dolarSaved);
                return isValid ? dolarSaved : 20.0;
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
                exchangeRate = JObject.Parse(html)["rates"].ToString();
                exchangeRate = exchangeRate.Replace("\r\n", string.Empty).Replace("{", string.Empty);
            }

            double dolar = double.Parse(exchangeRate.filterOnlyNumbers()[1] + "." + exchangeRate.filterOnlyNumbers()[2]);
            double dolarPrice = double.Parse(dolar.ToString("F"));

            return dolarPrice;
        }
    }
}
