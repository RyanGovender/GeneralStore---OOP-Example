using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Models
{
   public class Food: Product
    {
        private string TypeOfFood { get;}
        public bool Perishable { get;}
        public DateTime ExpiryDate { get;}
  
        public Food()
        {

        }

        public Food(int id,string name, double price, string typeOfFood, bool perishable, int quantity) : base(id,name, price, quantity)
        {
            TypeOfFood = typeOfFood;
            Perishable = perishable;
        }

        public Food(int id,string name,double price,string typeOfFood, bool perishable,DateTime expiryDate, int quantity) :base(id,name,price, quantity)
        {
            TypeOfFood = typeOfFood;
            Perishable = perishable;
            ExpiryDate = expiryDate;
        }
    }
}
