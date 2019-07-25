
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOKO.Helpers
{
    public class BasicData
    {
        public String selller { get; set; }
        public int sellOfTheDay { get; set; }

        public BasicData(string sellerm, int sellOfTheDay)
        {
            this.selller = selller;
            this.sellOfTheDay = sellOfTheDay;
        }
    } }