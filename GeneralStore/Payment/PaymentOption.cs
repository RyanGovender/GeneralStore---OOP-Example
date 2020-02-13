using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Payment
{
    public class PaymentOption
    {
        public PaymentOption()
        {

        }

        public void PayOption(double GetTotalCost)
        {
            var cashPayment = new CashPayment();
            var cardPayment = new CardPayment();
            var paymentPortal = new PaymentPortal();

            Console.WriteLine("Please select a type of payment method below?");
            Console.WriteLine("A) Cash Payment \nB) Card Payment \nC) Potal Payment");
            string paymentOption = Console.ReadLine();

            if (paymentOption == "A" || paymentOption == "a")
            {
                cashPayment.PaymentMethod(GetTotalCost);
            }
            else if (paymentOption == "B" || paymentOption == "b")
            {
                cardPayment.PaymentMethod(GetTotalCost);
            }
            else if (paymentOption == "C" || paymentOption == "c")
            {
                paymentPortal.PaymentMethod(GetTotalCost);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

    }
}
