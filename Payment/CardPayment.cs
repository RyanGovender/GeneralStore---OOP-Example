using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Payment
{
    class CardPayment : Payment
    {

        private int cardNumber;
        private int cardPin;
        private const int cardNumberlength = 10;
        public int CardNumber { get { return cardNumber; } set { cardNumber = value; } }

        public int UserCardPin{ get { return cardPin; } set { cardPin = value; } }

        public override void PaymentMethod()
        {
            Console.WriteLine("Your amount is: "+ GetTotalPrice.CalculateFinalCost());
            try
            {
                do
                {
                    Console.WriteLine("Please enter card pin below: ");
                    CardNumber = int.Parse(Console.ReadLine());
                } while (cardNumber.ToString().Length < cardNumberlength || cardNumber.ToString().Length > cardNumberlength);

                Console.WriteLine(" Please enter your pin Number");
                UserCardPin = int.Parse(Console.ReadLine());

                Console.WriteLine("Thank you payment has been successful");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
