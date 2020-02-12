using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Models
{
   public abstract class Customer
    {
        public string CustomerName { get; set; }

        public Customer()
        {

        }

        public Customer(string name)
        {
            CustomerName = name;
        }


    }
}
