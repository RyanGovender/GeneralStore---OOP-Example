using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Models
{
   public abstract class Customer
    {
        public int Id { get; }
        public string CustomerName { get;}

        public Customer(int id)
        {
            Id = id;
        }

        public Customer(int id,string name)
        {
            Id = id;
            CustomerName = name;
        }


    }
}
