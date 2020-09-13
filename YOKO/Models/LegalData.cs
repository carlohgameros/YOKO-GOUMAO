using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using YOKO.Helpers;

namespace YOKO.Models
{
    class LegalData
    {
        private static LegalData legalDataInstance = null;
        private SQL sqlHelper;

        public string rfc;
        public string name;
        public string razon;
        public string street;
        public string colonia;
        public string municipio;
        public string state;
        public string postalCode;
        public string phone;
        public string email;
        public string web;
        public string tax;
        public string dolar;
        public string taxPrice;
        public string printer;
        public string leyend1;
        public string leyend2;
        public string leyend3;
        public string leyend4;
        public string leyend5;
        public string leyend6;
        public string regimen;
        public DateTime date;
        public String monthName;

        public LegalData()
        {
            Initialize();
        }

        public static LegalData getInstance()
        {
            if (legalDataInstance == null)
            {
                legalDataInstance = new LegalData();
            }

            return legalDataInstance;
        }

        private void Initialize()
        {
            sqlHelper = new SQL();
            DataTable dt = sqlHelper.getLegalInformation();
            foreach (DataRow dr in dt.Rows)
            {
                rfc = dr["RFC"].ToString();
                name = dr["NombreComercial"].ToString();
                razon = dr["RazonSocial"].ToString();
                street = dr["CalleNum"].ToString();
                colonia = dr["Colonia"].ToString();
                municipio = dr["Municipio"].ToString();
                state = dr["Estado"].ToString();
                postalCode = dr["CP"].ToString();
                phone = dr["Tel"].ToString();
                email = dr["Email"].ToString();
                web = dr["SitioWeb"].ToString();
                tax = dr["PIva"].ToString();
                dolar = dr["TCambio"].ToString();
                taxPrice = dr["PreciosIVA"].ToString();
                printer = dr["Impresora"].ToString();
                leyend1 = dr["Leyenda1"].ToString();
                leyend2 = dr["Leyenda2"].ToString();
                leyend3 = dr["Leyenda3"].ToString();
                leyend4 = dr["Leyenda4"].ToString();
                leyend5 = dr["Leyenda5"].ToString();
                leyend6 = dr["Leyenda6"].ToString();
                regimen = dr["Regimen"].ToString();
                date = DateTime.Parse(dr["Fecha"].ToString());
            }

            InitializeMonthName();
        }

        private void InitializeMonthName()
        {
            string fullMonthName = new DateTime(date.Year, date.Month, date.Day).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
            monthName = "El " + date.Day + " de " + fullMonthName + " del " + date.Month + " se modificó por última vez.";
        }

        public void RefreshData()
        {
            Initialize();
        }

        public bool updateLegalData(LegalData newLegalData)
        {
            if (newLegalData == legalDataInstance)
                return false;

            return sqlHelper.ExecuteSQLCommand(getUpdateLegalInformationQuery(newLegalData));
        }

        private String getUpdateLegalInformationQuery(LegalData newLegalData)
        {
            return $"INSERT INTO tblDatosFiscales values ('{newLegalData.rfc}', '{newLegalData.name}', '{newLegalData.razon}', '{newLegalData.street}', '{newLegalData.colonia}', '{newLegalData.municipio}', '{newLegalData.state}', '{newLegalData.postalCode}', '{newLegalData.phone}', '{newLegalData.email}', '{newLegalData.web}', '{newLegalData.tax}', '{newLegalData.dolar}', '{newLegalData.taxPrice}', '{newLegalData.printer}', '{newLegalData.leyend1}', '{newLegalData.leyend2}', '{newLegalData.leyend3}', '{newLegalData.leyend4}', '{newLegalData.leyend5}', '{newLegalData.leyend6}', 0, '{newLegalData.regimen}', GETDATE())";
        }

        public override bool Equals(object obj)
        {
            var data = obj as LegalData;
            return data != null &&
                   rfc == data.rfc &&
                   name == data.name &&
                   razon == data.razon &&
                   street == data.street &&
                   colonia == data.colonia &&
                   municipio == data.municipio &&
                   state == data.state &&
                   postalCode == data.postalCode &&
                   phone == data.phone &&
                   email == data.email &&
                   web == data.web &&
                   tax == data.tax &&
                   dolar == data.dolar &&
                   printer == data.printer &&
                   leyend1 == data.leyend1 &&
                   leyend2 == data.leyend2 &&
                   leyend3 == data.leyend3 &&
                   leyend4 == data.leyend4 &&
                   leyend5 == data.leyend5 &&
                   leyend6 == data.leyend6 &&
                   regimen == data.regimen &&
                   date == data.date &&
                   monthName == data.monthName;
        }

        public override int GetHashCode()
        {
            var hashCode = -966028507;
            hashCode = hashCode * -1521134295 + EqualityComparer<SQL>.Default.GetHashCode(sqlHelper);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(rfc);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(razon);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(street);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(colonia);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(municipio);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(state);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(postalCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(phone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(web);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tax);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(dolar);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(taxPrice);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(printer);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(leyend1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(leyend2);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(leyend3);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(leyend4);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(leyend5);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(leyend6);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(regimen);
            hashCode = hashCode * -1521134295 + date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(monthName);
            return hashCode;
        }
    }
}
