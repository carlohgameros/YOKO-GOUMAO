using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YOKO.Resources;

namespace YOKO.Helpers
{
    class ServicesHelper
    {
        SQL sql = new SQL();

        public bool isServicesInActive() => sql.MultipleRecords(Constants.isServicesActiveString);

        public void getCurrentServices()
        {
            return 
        }
    }
}
