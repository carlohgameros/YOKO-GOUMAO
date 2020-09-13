using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Collections.Generic;
using Bunifu.Framework.UI;
using System.Drawing;

namespace YOKO
{
    public partial class NuevoUsuario : Form
    {
        private Random a = new Random();
        private int b;
        private string pass1;
        private string pass2;
        private bool isCorrectCode = false;

        public NuevoUsuario()
        {
            b = a.Next(100000, 999999);
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (contra1.Text != contra2.Text)
            {
                Notifications.NotificationsCenter.ShowSucessMessage("Error en la contraseña", "Verifique que sean iguales.");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = ConnectionString.connectionString;
                    conn.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand("insert into tblUsers values('" + nombre.Text + "', '" + contra1.Text + "', 'Trabajador', 1, GETDATE(), '" + correo.Text + "', GETDATE())", conn);
                        command.ExecuteNonQuery();
                        Notifications.NotificationsCenter.ShowSucessMessage("¡Perfil creado!", "Ya puede iniciar sesión con sus nuevas credenciales.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            new Login().Show();
            Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) => Close();

        private void bunifuImageButton2_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            List<BunifuTextbox> list = new List<BunifuTextbox>
            {
                nombre,
                contra1,
                contra2,
                correo,
                codigo               
            };

            foreach (BunifuTextbox textbox in list)
            {
                textbox._TextBox.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            }

            contra1._TextBox.PasswordChar = '•';
            contra2._TextBox.PasswordChar = '•';
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (correo.text.Length == 0)
            {
                Notifications.NotificationsCenter.ShowWarningMessage("Por favor valide sus datos.");
                return;
            }

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("carlo.hernandez16@tectijuana.edu.mx");
            mail.To.Add(correo.text.Trim());
            mail.Subject = "Código de verificación.";
            mail.Body = nombre.text + ", su código es: " + b;

            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new NetworkCredential("carlo.hernandez16@tectijuana.edu.mx", "rxRealcj23@");
            SmtpServer.EnableSsl = true;

            bool emailSended = false;
            try
            {
                SmtpServer.Send(mail);
                emailSended = true;
            }
            catch (Exception ex)
            {
                Notifications.NotificationsCenter.ShowErrorMessageForException(ex);
            }

            if (emailSended)
            {
                Notifications.NotificationsCenter.ShowSucessMessage("Código enviado", "Revisa tu bandeja de correos.");
            }
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            if (b.ToString() == codigo.text)
            {
                Notifications.NotificationsCenter.ShowSucessMessage("Código correcto", "Perfil puede crear el perfil.");
                isCorrectCode = true;
                ingresar.Visible = true;
            }
            else
            {
                Notifications.NotificationsCenter.ShowErrorMessage("Código incorrecto, inténta de nuevo.");
            }
        }
    }
}
