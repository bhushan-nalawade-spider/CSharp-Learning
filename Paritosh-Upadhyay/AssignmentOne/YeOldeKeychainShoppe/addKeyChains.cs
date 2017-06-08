using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeOldeKeychainShoppe
{
    class addKeyChains
    {
        public int add_keychains(int count)
        {
            Console.Clear();
            Console.WriteLine("You have {0} keychains. How many to add? ",count);
            int numberOfKeyChainsToAdd = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of Keychains in order: {0}",count+numberOfKeyChainsToAdd);
            return count + numberOfKeyChainsToAdd;
        }

    }
}
