using GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.LogicLayer
{
  public  class CalculationLogic
    {
        private static List<int> _itemInCart;
        private UserType _customer;
      
        public CalculationLogic(List<int> cart, UserType customer)
        {
            _itemInCart = cart;
            _customer = customer;
        }

        public double CalculateFoodCost()
        {
            double total = 0;
            foreach (var item in _itemInCart)
            {
                total += FoodLogic.GetFoodPrice(item);
            }
            return total;
        }

        public double CalculateDrinkCost()
        {
            double total = 0;
            foreach (var customerType in CustomerLogic._userTypes)
            {
                if(customerType.Id == _customer.Id)
                {
                    foreach (var itemsInCart in _itemInCart)
                    {
                        total += DrinkLogic.AddAlcoholTax(itemsInCart, customerType.AlcoholTax);
                        total += DrinkLogic.GetDrinkPrice(itemsInCart);
                    }
                    break;
                }
            }
            return total;
        }

        public double CostPrice()
        {
          return  CalculateFoodCost() + CalculateDrinkCost();
        }
        public double CalculateFinalCost()
        {
           double costPrice = CostPrice();
           foreach(var user in CustomerLogic._userTypes)
            {
                if(_customer.Id == user.Id)
                {
                    return costPrice + (costPrice * user.UserMarkup);
                }
            }
            return costPrice;
        }
    }
}
