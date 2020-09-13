using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOKO.Models
{
    class CurrentClient
    {
        private static Client currentClientInstance;

        public static void SetCurrentClient(Client client)
        {
            currentClientInstance = client;
        }

        public static Client getCurrentClientInstance()
        {
            return null;
        }

        public static Client GetCurrentClientInstance()
        {
            return currentClientInstance;
        }

        public static int GetID()
        {
            return currentClientInstance != null ? int.Parse(currentClientInstance.id) : 0;
        }
    }
}
