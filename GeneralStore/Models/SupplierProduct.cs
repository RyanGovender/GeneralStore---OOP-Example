using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Models
{
   public class SupplierProduct
    {
        public Product Product{ get; set; }

        public SupplierProduct()
        {

        }

        public SupplierProduct(Product product)
        {
            Product = product;
        }
    }
}
