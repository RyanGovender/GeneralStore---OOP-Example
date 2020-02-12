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
        private static double _returnDefaultAmount = 0;

        public static List<Food> GetFoods()
        {
            foods = new List<Food>
            {
                new Food(1,"Burger King",45,"Burger",true,DateTime.Now.AddDays(6),50),
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
            foreach(var item in foods)
            {
                if(item.id==id)
                {
                    UpdateFoodQuantity(id);
                    if (IsFoodExipred(id)) return item.Price / _isFoodExipredValue;
                    return item.Price; 
                }
            }
            return _returnDefaultAmount;
        }

        private static void UpdateFoodQuantity(int id)
        {
            foreach (var item in foods)
            {
                if (item.id == id)
                {
                    item.Quantity--;
                    break;
                }
            }
        }
    }
}
