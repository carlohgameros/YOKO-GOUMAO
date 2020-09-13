using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YOKO.Models;

namespace YOKO.Service_Additional_Information
{
    public interface IServiceInformationAdded
    {
        void OnServiceInformationAdded(int index, string observaciones, int navaja);
    }
}
