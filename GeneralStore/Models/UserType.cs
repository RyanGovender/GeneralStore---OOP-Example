using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Models
{
    public class UserType : Customer
    {
        public int Id { get; set; }
        public string TypeOfUser { get;}
        public double UserMarkup { get;}

        public double AlcoholTax { get;}

        public UserType(int id,string typeOfUser, double discount, double alcoholTax)
        {
            Id = id;
            TypeOfUser = typeOfUser;
            UserMarkup = discount;
            AlcoholTax = alcoholTax;
        }

        public UserType(string name, int id):base(name)
        {
            Id = id;
        }

    }
}
