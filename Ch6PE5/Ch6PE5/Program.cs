using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6PE5
{
    class COmputeTotal
    {
        static void Main()
        {
            int Charge;
            int N;
            double SalesTax;
            double ShippingCharge = 0.0;
            double GrandTotal = 0;
            string chg;
            string Nitem;
            Console.WriteLine("Enter the purchase"
                + " charge:");
            chg = Console.ReadLine();
            while((int.TryParse(chg, out Charge)==
                false))
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Re-enter an integer"
                    + " value");
                chg = Console.ReadLine();
            }
            Console.WriteLine("Enter the number of"
                + " items:");
            Nitem = Console.ReadLine();
            while((int.TryParse(Nitem, out N)== false))
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Re-enter an integer"
                    + " value:");
                Nitem = Console.ReadLine();
            }
            SalesTax = (Charge * 7.75) / 100;
            if (N< 3)
            {
                ShippingCharge = 3.50;
            }
            else if (N >= 3 && N <= 6)
            {
                ShippingCharge = 5.00;
            }
            else if (N >= 7 && N <= 10)
            {
                ShippingCharge = 7.00;
            }
            else if (N >= 11 && N <= 15)
            {
                ShippingCharge = 9.00;
            }
            else if (N >= 15)
            {
                ShippingCharge = 10.00;
            }
            Console.WriteLine("Here is the detailed" +
                " summary of purchase");
            Console.WriteLine("Purchase Charge" +
                " purchased is: {0}", Charge);
            Console.WriteLine("Number of items" +
                "Charge is: {0}", N);
            Console.WriteLine("Sales Tax" +
                "Charge is: {0}", SalesTax);
            Console.WriteLine("Shipping Charge" +
                "is: {0}", ShippingCharge);
            GrandTotal = Charge + SalesTax
                + ShippingCharge;
            Console.WriteLine("Grand Total"
                + " is: {0}", GrandTotal);
            Console.ReadKey();




        }
    }
}
