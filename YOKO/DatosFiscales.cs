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

namespace YOKO
{

    public partial class DatosFiscales : Form
    {
        SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
        
            
        public DatosFiscales()
        {
            InitializeComponent();
        }

        private void DatosFiscales_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select top 1 * from tblDatosFiscales order by Fecha desc", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DateTime date = new DateTime();
            foreach (DataRow dr in dt.Rows)
            {
                tblrfc.Text = dr["RFC"].ToString();
                tblnombre.Text = dr["NombreComercial"].ToString();
                tblrazon.Text = dr["RazonSocial"].ToString();
                tblcalle.Text = dr["CalleNum"].ToString();
                tblcolonia.Text = dr["Colonia"].ToString();
                tblmunicipio.Text = dr["Municipio"].ToString();
                tblestado.Text = dr["Estado"].ToString();
                tblcp.Text = dr["CP"].ToString();
                tbltel.Text = dr["Tel"].ToString();
                tblemail.Text = dr["Email"].ToString();
                tblweb.Text = dr["SitioWeb"].ToString();
                tbliva.Text = dr["PIva"].ToString();
                tbldolar.Text = dr["TCambio"].ToString();
                tblimpresora.Text = dr["Impresora"].ToString();
                tbll1.Text = dr["Leyenda1"].ToString();
                tbll2.Text = dr["Leyenda2"].ToString();
                tbll3.Text = dr["Leyenda3"].ToString();
                tbll4.Text = dr["Leyenda4"].ToString();
                tbll5.Text = dr["Leyenda5"].ToString();
                txtLeyenda6.Text = dr["Leyenda6"].ToString();
                tblregimen.Text = dr["Regimen"].ToString();
                date = DateTime.Parse(dr["Fecha"].ToString());
                
            }
            var fullMonthName = new DateTime(date.Year, date.Month, date.Day).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
            LabelFecha.Text = "El " + date.Day +" de " + fullMonthName + " del " + date.Month + " se modificó por última vez.";
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox12_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox10_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select top 1 * from tblDatosFiscales order by Fecha desc", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DateTime date = new DateTime();
            foreach (DataRow dr in dt.Rows)
            {
                tblrfc.Text = dr["RFC"].ToString();
                tblnombre.Text = dr["NombreComercial"].ToString();
                tblrazon.Text = dr["RazonSocial"].ToString();
                tblcalle.Text = dr["CalleNum"].ToString();
                tblcolonia.Text = dr["Colonia"].ToString();
                tblmunicipio.Text = dr["Municipio"].ToString();
                tblestado.Text = dr["Estado"].ToString();
                tblcp.Text = dr["CP"].ToString();
                tbltel.Text = dr["Tel"].ToString();
                tblemail.Text = dr["Email"].ToString();
                tblweb.Text = dr["SitioWeb"].ToString();
                tbliva.Text = dr["PIva"].ToString();
                tbldolar.Text = dr["TCambio"].ToString();
                tblimpresora.Text = dr["Impresora"].ToString();
                tbll1.Text = dr["Leyenda1"].ToString();
                tbll2.Text = dr["Leyenda2"].ToString();
                tbll3.Text = dr["Leyenda3"].ToString();
                tbll4.Text = dr["Leyenda4"].ToString();
                tbll5.Text = dr["Leyenda5"].ToString();
                txtLeyenda6.Text = dr["Leyenda6"].ToString();
                tblregimen.Text = dr["Regimen"].ToString();
                date = DateTime.Parse(dr["Fecha"].ToString());

            }
            var fullMonthName = new DateTime(date.Year, date.Month, date.Day).ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
            LabelFecha.Text = "El " + date.Day + " de " + fullMonthName + " del " + date.Month + " se modificó por última vez.";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select top 1 * from tblDatosFiscales order by Fecha desc", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bool alerta = true;
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (tblrfc.Text != dr["RFC"].ToString())
                {
                    alerta = false;
                }
                if (tblnombre.Text != dr["NombreComercial"].ToString())
                {
                    alerta = false;
                }
                
                if (tblrazon.Text != dr["RazonSocial"].ToString())
                {
                    alerta = false;
                }
                
                if (tblcalle.Text != dr["CalleNum"].ToString())
                {
                    alerta = false;
                }
                
                if (tblcolonia.Text != dr["Colonia"].ToString())
                {
                    alerta = false;
                }
                
                if (tblmunicipio.Text != dr["Municipio"].ToString())
                {
                    alerta = false;
                }
                
                if (tblestado.Text != dr["Estado"].ToString())
                {
                    alerta = false;
                }
                
                if (tblcp.Text != dr["CP"].ToString())
                {
                    alerta = false;
                }
                
                if (tbltel.Text != dr["Tel"].ToString())
                {
                    alerta = false;
                }
                
                if (tblemail.Text != dr["Email"].ToString())
                {
                    alerta = false;
                }
                
                if (tblweb.Text != dr["SitioWeb"].ToString())
                {
                    alerta = false;
                }
                
                if (tbliva.Text != dr["PIva"].ToString())
                {
                    alerta = false;
                }
                
                if (tbldolar.Text != dr["TCambio"].ToString())
                {
                    alerta = false;
                }
                
                if (tblimpresora.Text != dr["Impresora"].ToString())
                {
                    alerta = false;
                }
                
                if (tbll1.Text != dr["Leyenda1"].ToString())
                {
                    alerta = false;
                }
                
                if (tbll2.Text != dr["Leyenda2"].ToString())
                {
                    alerta = false;
                }
                
                if (tbll3.Text != dr["Leyenda3"].ToString())
                {
                    alerta = false;
                }
                
                if (tbll4.Text != dr["Leyenda4"].ToString())
                {
                    alerta = false;
                }
                
                if (tbll5.Text != dr["Leyenda5"].ToString())
                {
                    alerta = false;
                }
                
                if (txtLeyenda6.Text != dr["Leyenda6"].ToString())
                {
                    alerta = false;
                }
                
                if (tblregimen.Text != dr["Regimen"].ToString())
                {
                    alerta = false;
                }
                
            }
            if (alerta == true)
            {
                MessageBox.Show("");
            }
            else
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

        private void navigationBar1_Load(object sender, EventArgs e)
        {

        }
    }
}
