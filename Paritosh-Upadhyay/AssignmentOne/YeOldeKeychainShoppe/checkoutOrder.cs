using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeOldeKeychainShoppe
{
    class checkoutOrder
    {
        public void checkout(int count, int totalCostOfKeyChains)
        {
            Console.Clear();
            Console.WriteLine("What is your name? ");
            string nameOfCustomer = Console.ReadLine();
            Console.WriteLine("Total cost of {0} keychains is {1}", count, totalCostOfKeyChains);
            Console.WriteLine("Thanks for your order {0}!", nameOfCustomer);
        }
    }
}
