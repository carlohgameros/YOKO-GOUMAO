using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework;
using System.Data.SqlClient;

namespace YOKO
{
    public partial class Login : Form
    {
        int posY = 0;
        int posX = 0;
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) => Close();

        private void bunifuImageButton2_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top+ (e.Y - posY);
            }
        }

        private void usuario_MouseClick(object sender, MouseEventArgs e)
        {
            usuario.Text = "";
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=DESKTOP-5ON2GLQ;Initial Catalog=GoumaoDB;Integrated Security=True";
                try
                {
                    conn.Open();
                }
                catch (Exception ex)                {
                    notifyIcon1.ShowBalloonTip(1000, "Error en la conexión", ex.Message, ToolTipIcon.Info);
                }
                if (conn.State == ConnectionState.Open)
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("select * from tblUsers where UsrName = '" + usuario.Text + "' and UsrPwd = '" + contra.Text + "'", conn);
                        int a = int.Parse(s: command.ExecuteScalar().ToString());
                        if (a > 0) { new Venta().Show(); Hide(); }
                    }
                    catch 
                    {
                        notifyIcon1.ShowBalloonTip(1000, "Nombre o contraseña incorrectos", "Verifique sus datos", ToolTipIcon.Info);
                    }
                }
                conn.Close();
            }
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            new NuevoUsuario().Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RecuperarContra().Show();
            Hide();
        }

        WebBrowser navegador = new WebBrowser();
        string a;
        private void Login_Load(object sender, EventArgs e)
        {
            navegador.ScriptErrorsSuppressed = true;
            navegador.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.cargar_datos);
            navegador.Navigate("http://www.lacasadecambio.com/");
        }
        
        public void cargar_datos(object sender, EventArgs e )
        {
            a = navegador.Document.GetElementById("tipocambio").InnerText;
            a = a.Replace("PROMEDIO EN CASAS DE CAMBIO", "");
            a = a.Replace("VENTA", System.Environment.NewLine  + "VENTA");
            notifyIcon1.ShowBalloonTip(2000, "PROMEDIO EN CASAS DE CAMBIO", a, ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) => Show();

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }
    }
}
