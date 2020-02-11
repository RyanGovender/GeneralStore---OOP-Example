using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Models
{
    public class Drink : Product
    {
        private double DrinkVolume { get; set; }
        public bool AlcoholicOrNonAloholic { get;}

        public Drink()
        {

        }

        public Drink(int id, string name, double price, double drinkVolume, bool alcohol,int quantity) : base(id,name,price, quantity)
        {
            DrinkVolume = drinkVolume;
            AlcoholicOrNonAloholic = alcohol;
        }
    }
}
