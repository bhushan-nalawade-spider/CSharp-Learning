using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_KeychainShoppe
{
    class KeychainSales
    {
        
        static int CurrentOrder = 0;
        static int TotalOrder = 0;
        static int KeychainsCostPerUnit = 10;
        static int option = 1;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Ye Olde Keychain Shoppe:");
            
            do
            {
                DiplayMenu();
                string key = Console.ReadLine();
                try
                {
                    option = int.Parse(key);
                }
                catch (Exception)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("you have not entered 1 to 4 value");

                }
                switch (key)
                {
                    case "1":
                        Console.Write("You have "+ CurrentOrder + " keychains. How many to add?: ");
                        string KeychainsToAdd = Console.ReadLine();
                        CurrentOrder = add_keychains(int.Parse(KeychainsToAdd));
                        Console.WriteLine("Keychains in order, now: "+ CurrentOrder);
                        break;
                    case "2":
                        Console.Write("no of keychains removed: ");
                        string KeychainsToRemove = Console.ReadLine();
                        CurrentOrder = remove_keychains(int.Parse(KeychainsToRemove));
                        Console.WriteLine("Keychains in order, now: " + CurrentOrder);
                        break;
                    case "3":
                        if (CurrentOrder > 0)
                        {
                            Console.Write("Keychain's cost per unit: ");
                            KeychainsCostPerUnit = int.Parse(Console.ReadLine());
                            Console.WriteLine("Total Cost of order: " + view_Order(CurrentOrder, KeychainsCostPerUnit));
                        } else {
                            Console.WriteLine("you do not have any keychains in your order..");
                        }
                        
                        break;
                    case "4":
                        Console.Write("Keychain's cost per unit: ");
                        KeychainsCostPerUnit = int.Parse(Console.ReadLine());
                        checkout(CurrentOrder, KeychainsCostPerUnit);
                        return;
                }
            } while (option<=4);

            if (option > 4)
            {
                Console.Write("you have not entered propervalue, restart your prog ");
                Console.ReadKey();
            }
        }

        static int add_keychains(int CurrentOrder)
        {           
            TotalOrder += CurrentOrder;
            Console.WriteLine("--------------------------------");
            return TotalOrder;
        }

        static int remove_keychains(int CurrentOrder)
        {
            TotalOrder -= CurrentOrder;
            Console.WriteLine("--------------------------------");
            return TotalOrder;
        }

        static int view_Order (int CurrentOrder, int KeychainsCostPerUnit)
        {
            Console.WriteLine("--------------------------------");
            return CurrentOrder * KeychainsCostPerUnit;
        }

        static void checkout(int CurrentOrder, int KeychainsCostPerUnit)
        {
            Console.Write("What is your name ?:");
            string name = Console.ReadLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Keychains in order now: "+CurrentOrder);
            Console.WriteLine("Your total cost:"+ CurrentOrder* KeychainsCostPerUnit);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Thanks for your order " + name);
            Console.ReadKey();
        }
        static void DiplayMenu()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("1.Add Keychains to Order:");
            Console.WriteLine("2.Remove keychains from Order:");
            Console.WriteLine("3.View Current Order:");
            Console.WriteLine("4.Checkout:");
            Console.Write("Please enter your choice: ");
        }
    }
}
