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
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

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
            notifyIcon1.ShowBalloonTip(1000, "Intento Correcto", "Datos actualizados a la base de datos", ToolTipIcon.Info);
            /*
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=DESKTOP-5ON2GLQ;Initial Catalog=GoumaoDB;Integrated Security=True";
                conn.Open();
                try
                { 
                    SqlCommand command = new SqlCommand("insert into tblUsers values('"+nombre.Text+"', "+contra1.Text+", 'Trabajador', 1, GETDATE(), '"+correo.Text+"', GETDATE())", conn);
                    command.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
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

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();
            new Login().Show();
        }
    }
}
