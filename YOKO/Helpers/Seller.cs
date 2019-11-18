using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YOKO.Models;
using YOKO.Helpers;

namespace YOKO.Helpers
{
    class Seller
    {
        SQL sqlHelper = new SQL();

        public bool sellProducts(List<ProductItem> productItems)
        {
            var success = new List<bool>();
            foreach (ProductItem item in productItems)
            {
                var query = "UPDATE tblProductos SET Existencia = Existencia - " + item.items + " WHERE ProdID = 4";
                success.Add(sqlHelper.ExecuteSQLCommand(query));
            }
            return !success.Find(result => result == false);
        }

        public void PrintRecipe(List<ProductItem> products, List<Service> services)
        {

        }
    }
}
