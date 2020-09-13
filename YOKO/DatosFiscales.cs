using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using YOKO.Models;

namespace YOKO
{

    public partial class DatosFiscales : Form
    {
        LegalData legalData;
        SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
        
        public DatosFiscales()
        {
            InitializeComponent();
        }

        private void DatosFiscales_Load(object sender, EventArgs e)
        {
            legalData = LegalData.getInstance();

            setData();
        }

        private void setData()
        {
            tblrfc.Text = legalData.rfc;
            tblnombre.Text = legalData.name;
            tblrazon.Text = legalData.razon;
            tblcalle.Text = legalData.street;
            tblcolonia.Text = legalData.colonia;
            tblmunicipio.Text = legalData.municipio;
            tblestado.Text = legalData.state;
            tblcp.Text = legalData.postalCode;
            tbltel.Text = legalData.phone;
            tblemail.Text = legalData.email;
            tblweb.Text = legalData.web;
            tbliva.Text = legalData.tax;
            tbldolar.Text = legalData.dolar;
            tblimpresora.Text = legalData.printer;
            tbll1.Text = legalData.leyend1;
            tbll2.Text = legalData.leyend2;
            tbll3.Text = legalData.leyend3;
            tbll4.Text = legalData.leyend4;
            tbll5.Text = legalData.leyend5;
            txtLeyenda6.Text = legalData.leyend6;
            tblregimen.Text = legalData.regimen;

            //LabelFecha.Text = legalData.monthName;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            legalData.RefreshData();
            setData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LegalData newLegalData = new LegalData();
            newLegalData.rfc = tblrfc.Text;
            newLegalData.name = tblnombre.Text;
            newLegalData.razon = tblrazon.Text;
            newLegalData.street = tblcalle.Text;
            newLegalData.colonia = tblcolonia.Text;
            newLegalData.municipio = tblmunicipio.Text;
            newLegalData.state = tblestado.Text;
            newLegalData.postalCode = tblcp.Text;
            newLegalData.phone = tbltel.Text;
            newLegalData.email = tblemail.Text;
            newLegalData.web = tblweb.Text;
            newLegalData.tax = tbliva.Text;
            newLegalData.dolar = tbldolar.Text;
            newLegalData.printer = tblimpresora.Text;
            newLegalData.leyend1 = tbll1.Text;
            newLegalData.leyend2 = tbll2.Text;
            newLegalData.leyend3 = tbll3.Text;
            newLegalData.leyend4 = tbll4.Text;
            newLegalData.leyend5 = tbll5.Text;
            newLegalData.leyend6 = txtLeyenda6.Text;
            newLegalData.regimen = tblregimen.Text;
                
            if (legalData.updateLegalData(newLegalData))
            {
                Notifications.NotificationsCenter.notifyIcon.ShowBalloonTip(1000, "Datos actualizados", "Ahora los datos guardados serán lo que se usen en el sistema.", ToolTipIcon.Info);
                
            }
            bunifuFlatButton1_Click(sender, e);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            new Inicio().Show();
            Hide();
        }
    }
}
