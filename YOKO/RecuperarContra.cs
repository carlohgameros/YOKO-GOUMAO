using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace YOKO
{
    public partial class RecuperarContra : Form
    {
        Random a = new Random();
        int b;
        public RecuperarContra()
        {
            b = a.Next(100000, 999999);
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("carlo.hernandez16@tectijuana.edu.mx");
            mail.To.Add(correo.Text.Trim());
            mail.Subject = "Código de verificación.";
            mail.Body = "El código de recuperacion es: " + b;

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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (contra1.Text != contra2.Text)
            {
                notifyIcon1.ShowBalloonTip(1000, "Error en la contraseña", "Verifique que sean iguales", ToolTipIcon.Info);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Data Source=DESKTOP-5ON2GLQ;Initial Catalog=GoumaoDB;Integrated Security=True";
                    conn.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand("update tblUsers set LastChange = GETDATE(), UsrPwd = "+contra1.Text+"  where Email = '"+correo.Text+"'", conn);
                        command.ExecuteNonQuery();
                        notifyIcon1.ShowBalloonTip(1000, "Actualización correcta", "Datos actualizados a la base de datos", ToolTipIcon.Info);
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            bool v = codigo.Text == b.ToString();
            if (v)
            {
                notifyIcon1.ShowBalloonTip(1000, "Códigos correctos", "Eliga nueva contraseña", ToolTipIcon.Info);
                contra1.Enabled = true;
                contra2.Enabled = true;
            }
        }
    }
}
