using GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralStore.LogicLayer
{
    public class FoodLogic
    {
        public static List<Food> foods= GetFoods();
        private static double _isFoodExipredValue = 2;
  
        public FoodLogic(double foodExipredDiscount)
        {
            _isFoodExipredValue = foodExipredDiscount;
        }

        public static List<Food> GetFoods()
        {
            foods = new List<Food>
            {
                new Food(1,"Burger King",45,"Burger",true,DateTime.Now.AddDays(6),10),
                new Food(2,"Burger King",45,"Burger",true,DateTime.Now,87),
                new Food(3,"Burger King",45,"Burger",true,DateTime.Now,45),
                new Food(4,"Burger King",45,"Burger",true,DateTime.Now,75),
                new Food(5,"Burger King",45,"Burger",true,DateTime.Now,15),
                new Food(6,"Burger King",45,"Burger",true,DateTime.Now,62)
            };
            return foods;
        }

        public static bool IsFoodExipred(int id)
        {
            foreach(var item in foods)
            {
                if (item.ExpiryDate < DateTime.Now.Date && id == item.id)
                    return true;
            }
            return false;
        }

        public static double GetFoodPrice(int id)
        {
            double price = StoreLogic.GetItemPrice(foods.Cast<Product>().ToList(), id);
            return IsFoodExipred(id) ? price / _isFoodExipredValue : price;
        }

        public static void DisplayFoods()
        {
            foreach (var item in foods)
            {
                Console.WriteLine($" Item Product Code : {item.id}" +
                    $"\n Product Name : {item.Name}" +
                    $"\n Product Cost :{item.Price}" +
                    $"\n Available Stock :{item.Quantity}" +
                    $"\n  Expiry Date : {item.ExpiryDate}" +
                    $"\n-----------------------------------------------");
            }
        }
    }
}
