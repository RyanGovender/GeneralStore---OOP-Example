using GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralStore.LogicLayer
{
   public class StoreLogic
    {
        private static List<SupplierProduct> _stock= GetStock();

        public static List<SupplierProduct> GetStock()
        {
            _stock = new List<SupplierProduct>
            {
                new SupplierProduct(new Product(1,"Burger King",45,80)),
                new SupplierProduct(new Product(9,"Coke",20,1000))
            };
            return _stock;
        }

        public static void AddFood()
        {
            UpdateStock(FoodLogic.foods.Cast<Product>().ToList());
            UpdateStock(DrinkLogic.drinks.Cast<Product>().ToList());

        }

        public static void  UpdateStock(List<Product> product)
        {
            foreach(var item in _stock)
            {
               foreach(var instock in product)
                {
                    if(item.Product.id == instock.id)
                    {
                        instock.Quantity += item.Product.Quantity;
                    }
                }
            }
        }
    }
}
