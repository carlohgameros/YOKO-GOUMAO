using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOKO.Interfaces
{
    public interface ITicketHelper
    {
        void ErrorPrinting(Exception exception);

        void SuccessPrinting();
    }
}
