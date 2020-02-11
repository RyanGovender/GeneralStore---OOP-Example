using GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.LogicLayer
{
  public  class CalculationLogic
    {
        private List<int> _numbers;
        private Customer _customer;
        private static double _bulkClientDiscount ;
        private static double _casualClientDiscount;
        private static double _returnDefaultAmount;

        public CalculationLogic(List<int> x, Customer customer)
        {
            _numbers = x;
            _customer = customer;
            _bulkClientDiscount = 1.2;
            _casualClientDiscount = 2;
            _returnDefaultAmount = 0;
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach(var item in _numbers)
            {
                total+=FoodLogic.GetFoodPrice(item);
                if(_customer.TypeOfClient == UserType.CasualCustomer)
                total += DrinkLogic.AddAlcoholTax(item);
            }
            return total;
        }

        public double CalculateFinalCost()
        {
           if(_customer.TypeOfClient == UserType.BulkCustomer)
            {
                return CalculateTotal() * _bulkClientDiscount;
            }
            else
            {
                return CalculateTotal() * _casualClientDiscount;
            }
        }
    }
}
