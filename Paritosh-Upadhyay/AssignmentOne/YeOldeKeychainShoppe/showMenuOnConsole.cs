using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeOldeKeychainShoppe
{
    class showMenuOnConsole
    {
        public int showMenu(int choice)
        {
            Console.WriteLine("\nYe Olde Keychain Shoppe\n");
            Console.WriteLine("1.Add Keychains to Order");
            Console.WriteLine("2.Remove keychains from Order");
            Console.WriteLine("3.View Current Order");
            Console.WriteLine("4.Checkout");
            Console.WriteLine("Please enter your choice:");
            try
            {
                choice = int.Parse(Console.ReadLine());
                
            }
            catch
            {
                Console.WriteLine("You did not enter any choice.");
            }
            return choice;
        }
    }
}
