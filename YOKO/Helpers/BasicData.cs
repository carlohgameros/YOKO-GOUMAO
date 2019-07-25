
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOKO.Helpers
{
    public class BasicData
    {
        public static String selller;
        
        public static void UpdateSellerName(String Name) => selller = Name;

        public static String GetSellerName() => selller;
    }
}