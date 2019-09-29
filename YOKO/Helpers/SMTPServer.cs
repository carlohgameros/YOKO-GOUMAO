using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace YOKO.Helpers
{
    public class SMTPServer
    {
        MailMessage mailMessage = new MailMessage();
        MailAddress mailAddress = new MailAddress("carlo.hernandez16@tectijuana.edu.mx");

        public string header { get; set; }
        public string body { get; set; }
        public string bodyString { get; set; } 
        public string code { get; set; }

        public SMTPServer()
        {
            header = "<img src=\"https://drive.google.com/uc?export=view&id=1WCSBZ5PINRx5NM3UHHFfwTyN4-Tq49mo\" alt=\"GouMao\" style=\"width: 300px; max-width: 100%; height: auto; display: block; margin-left: auto; margin-right: auto; width: 50%;\"> <hr style=\" border: 0; height: 1px; background-image: linear-gradient(to right, rgba(0, 0, 0, 0), rgba(0, 0, 0, 0.75), rgba(0, 0, 0, 0));\">";
            body = "<div style=\"text - align: justify; text - justify: inter - word; width: 100 %; align: center; \">";
            bodyString = "</div>";
        }

 
    }
}
