using GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.LogicLayer
{
   public class CustomerLogic
    {
        public static List<UserType> _userTypes= GetTypesOfUser();
        private static double _returnDefault = 0;

        public CustomerLogic(double defaultAmount)
        {
            _returnDefault = 0;
        }

        public static List<UserType> GetTypesOfUser()
        {
            _userTypes = new List<UserType>
            {
                new UserType(1,"Bulk Client",0.2,0),
                new UserType(2,"Casual",1,0.15)
            };

            return _userTypes;
        }

        public double GetClientDiscount(int id)
        {
            foreach(var userType in _userTypes)
            {
                if(userType.Id == id)
                {
                    return userType.UserMarkup;
                }
            }
           return _returnDefault;
        }

        
    }
}
