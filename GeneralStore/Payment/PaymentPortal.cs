using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Payment
{
    class PaymentPortal : Payment
    {

        private long cardNumber;
        private int cardPin;
        private const int cardNumberlength = 10;

        public long CardNumber { get { return cardNumber; } set { cardNumber = value; } }
        public int UserCardPin { get { return cardPin; } set { cardPin = value; } }

        public override void PaymentMethod(double GetTotalCost)
        {
            Console.WriteLine("Your amount is: " + GetTotalCost);
            try
            {
                do
                {
                    Console.WriteLine("Please enter your Card Number below: ");
                    CardNumber = Convert.ToInt64(Console.ReadLine());
                } while (cardNumber.ToString().Length < cardNumberlength || cardNumber.ToString().Length > cardNumberlength);

                Console.WriteLine(" Please enter your Card Pin below: ");
                UserCardPin = int.Parse(Console.ReadLine());

                Console.WriteLine("Thank you payment has been successful.");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
