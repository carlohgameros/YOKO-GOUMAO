using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOKO.Models
{
    class ProductItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int items { get; set; }
        public int stock { get; set; }
        public bool isService { get; set; }
        public bool isResponsive { get; set; }

        public ProductItem(int id, string name, decimal price, int items, int stock, bool isService, bool isResponsive)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.items = items;
            this.stock = stock;
            this.isService = isService;
            this.isResponsive = isResponsive;
        }
    }
}
