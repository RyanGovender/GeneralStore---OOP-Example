using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Models
{
    public enum UserType
    {
        BulkCustomer,
        CasualCustomer 
    }

   public class Customer
    {
        public string CustomerName { get; set; }
        public UserType TypeOfClient { get; set; }

        public Customer(UserType type,string name)
        {
            CustomerName = name;
            TypeOfClient = type;
        }
    }
}
