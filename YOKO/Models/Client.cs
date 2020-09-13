using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOKO.Models
{
    public class Client
    {
        public String id;
        public String name;
        public String phone;
        public String alternativePhone;
        public String email;

        public Client(string id, string name, string phone, string alternativePhone, string email)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.alternativePhone = alternativePhone;
            this.email = email;
        }

        public Client(Client newClient)
        {
            this.name = newClient.name;
            this.phone = newClient.phone;
            this.alternativePhone = newClient.alternativePhone;
            this.email = newClient.email;
        }
    }
}
