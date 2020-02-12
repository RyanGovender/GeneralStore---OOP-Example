using System;
using System.Collections.Generic;
using System.Text;
using GeneralStore.LogicLayer;

namespace GeneralStore.Payment
{
    class Payment
    {
        private CalculationLogic getPrice;
      
        public CalculationLogic GetTotalPrice { get { return getPrice; } }
       
        public Payment()
        {

        }

        public virtual void PaymentMethod()
        {

        }
    }
}
