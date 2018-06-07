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
        
        public NuevoUsuario()
        {
            a.Next(100000, 999999);
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=DESKTOP-5ON2GLQ;Initial Catalog=GoumaoDB;Integrated Security=True";
                conn.Open();
                try
                {

                    SqlCommand command = new SqlCommand("insert into tblUsers values('Joel', 123, 'Administrador', 1, GETDATE(), 'carlo.hernandez16@gmail.com', GETDATE())", conn);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
            mail.To.Add("carlo-turbo@hotmail.com");
            mail.Subject = "This is an email";
            mail.Body = "this is the body content of the email. " + a + "";

            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment(@"C:\Attachment.txt");
            //mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = true;
            SmtpServer.Credentials = new NetworkCredential("carlo.hernandez16@tectijuana.edu.mx", "realcj18");//no need to mention here?
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }
}
