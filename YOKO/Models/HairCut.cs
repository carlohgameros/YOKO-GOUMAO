using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOKO.Models
{
    public class HairCut
    {
        private int knifeSize = 0;
        private string specifications = "";

        public HairCut(int knifeSize, string specifications)
        {
            this.knifeSize = knifeSize;
            this.specifications = specifications;
        }

        public int GetKnifeSize()
        {
            return knifeSize;
        }

        public string GetSpecifications()
        {
            return specifications;
        }
    }
}
