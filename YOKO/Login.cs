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
                conn.Open();
                try
                {

                    SqlCommand command = new SqlCommand("select * from tblUsers where UsrName = '" + usuario.Text + "' and UsrPwd = '" + contra.Text + "'", conn);
                    int a = int.Parse(s: command.ExecuteScalar().ToString());
                    if (a > 0)
                    {
                        new Inicio().Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nombre o contraseña incorrectos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            new NuevoUsuario().Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
