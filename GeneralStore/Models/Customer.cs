using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Models
{
   public abstract class Customer
    {
        public string CustomerName { get;}

        public Customer()
        {

        }

        public Customer(string name)
        {
            CustomerName = name;
        }


    }
}
