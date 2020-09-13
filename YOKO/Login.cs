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
using YOKO.Helpers;
using YOKO.Notifications;

namespace YOKO
{
    public partial class Login : Form
    {
        private int posY = 0;
        private int posX = 0;
        private bool handled = false;

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            NotificationsCenter notificationsCenter = new NotificationsCenter(YOKKO);
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
            LogIn();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            new NuevoUsuario().Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RecuperarContra().Show();
            Hide();
        }

        private void navigationBar1_Load(object sender, EventArgs e)
        {
            navigationBar1.HideBackButton();
            navigationBar1.HideTitle();
            navigationBar1.StopAllApp();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usuario.Focus();
            usuario._TextBox.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            contra._TextBox.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            contra._TextBox.PasswordChar = '•';
            contra._TextBox.KeyDown += onContraKeyDown;
            contra._TextBox.KeyPress += onContraKeyPressed;
        }

        private void LogIn()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConnectionString.connectionString;
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    NotificationsCenter.notifyIcon.ShowBalloonTip(1000, "Error en la conexión", ex.Message, ToolTipIcon.Info);
                }
                if (conn.State == ConnectionState.Open)
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("select * from tblUsers where UsrName = '" + usuario._TextBox.Text + "' and UsrPwd = '" + contra._TextBox.Text + "'", conn);
                        int a = int.Parse(s: command.ExecuteScalar().ToString());
                        if (a > 0)
                        {
                            BasicData.UpdateSellerName(usuario.Text);
                            Form inicio = new Inicio();
                            inicio.Show();
                            Hide();
                        }
                    }
                    catch
                    {
                        NotificationsCenter.notifyIcon.ShowBalloonTip(1000, "Nombre o contraseña incorrectos", "Verifique sus datos", ToolTipIcon.Info);
                    }
                }
                conn.Close();
            }
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void crear_Click(object sender, EventArgs e)
        {
            new NuevoUsuario().Show();
        }

        private void onContraKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                handled = true;
                LogIn();
            }
        }

        private void onContraKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (handled)
            {
                e.Handled = true;
            }

            handled = false;
        }
    }
}
