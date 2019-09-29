using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOKO.Models
{
    public class MailSubscription
    {
        public int id { get; set; }
        public string email { get; set; }
        public bool subscribted { get; set; }

        public MailSubscription(int id, string email, bool subscribted)
        {
            this.id = id;
            this.email = email;
            this.subscribted = subscribted;
        }
    }
}
