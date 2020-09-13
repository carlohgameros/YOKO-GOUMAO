using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YOKO.enums;

namespace YOKO.Models
{
    public class PetRegister
    {
        public int ownerID;
        public int petID;
        public string description;
        public DateTime date;
        public string status;

        public PetRegister(int ownerID, int petID, string description, DateTime date, string status)
        {
            this.ownerID = ownerID;
            this.petID = petID;
            this.description = description;
            this.date = date;
            this.status = status;
        }
    }
}
