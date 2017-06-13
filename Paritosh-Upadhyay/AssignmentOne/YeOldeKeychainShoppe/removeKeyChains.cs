using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeOldeKeychainShoppe
{
    class removeKeyChains
    {
        public int remove_keychains(int count)
        {
            Console.Clear();
            Console.WriteLine("You have {0} keychains. How many to remove? ",count);
            count = count - int.Parse(Console.ReadLine());
            Console.WriteLine("Number of Keychains in order: {0}", count);
            return count;
        }
    }
}
