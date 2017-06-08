using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeOldeKeychainShoppe
{
    class viewKeyChainsOrder
    {
        public int viewOrder(int count)
        {
            Console.Clear();
            Console.WriteLine("Keychains in order: {0}", count);
            Console.WriteLine("Keychains cost per unit is 10");
            int totalCostOfKeyChains = count * 10;
            Console.WriteLine("Total cost of {0} keychains is {1}",count,totalCostOfKeyChains);
            return totalCostOfKeyChains;
        }
    }
}
