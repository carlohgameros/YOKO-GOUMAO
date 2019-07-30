using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace YOKO
{
    public partial class NuevoUsuario : Form
    {
        Random a = new Random();
        int b;
        public NuevoUsuario()
        {
            b = a.Next(100000, 999999);
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (contra1.Text != contra2.Text)
            {
                //notifyIcon1.ShowBalloonTip(1000, "Error en la contraseña", "Verifique que sean iguales", ToolTipIcon.Info);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = ConnectionString.connectionString;
                    conn.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand("insert into tblUsers values('" + nombre.Text + "', " + contra1.Text + ", 'Trabajador', 1, GETDATE(), '" + correo.Text + "', GETDATE())", conn);
                        command.ExecuteNonQuery();
                        //notifyIcon1.ShowBalloonTip(1000, "Intento Correcto", "Datos actualizados a la base de datos", ToolTipIcon.Info);
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
            if (codigo.Text == "1")
            {
                ingresar.ButtonText = "Test";
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("carlo.hernandez16@tectijuana.edu.mx");
            mail.To.Add(correo.Text.Trim());
            mail.Subject = "Código de verificación.";
            mail.Body = nombre.Text + ", su código es: " + b;

            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment(@"C:\Attachment.txt");
            //mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = true;
            SmtpServer.Credentials = new NetworkCredential("carlo.hernandez16@tectijuana.edu.mx", "realcj18");
            SmtpServer.EnableSsl = true;
            try
            {
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (b.ToString() == codigo.Text)
            {
                MessageBox.Show("Correcto.");
                ingresar.ButtonText = "Crear";
            }
            else
            {
                MessageBox.Show("Incorrecto");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
