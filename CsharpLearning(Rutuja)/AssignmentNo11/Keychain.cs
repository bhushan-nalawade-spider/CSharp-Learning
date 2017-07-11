using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo11
{
    class Keychain
    {
        int KeyChain_Count = 0;
        public int add_keychain(int Purchased_item)
        {
            KeyChain_Count = KeyChain_Count + Purchased_item;
            return KeyChain_Count;
        }

        public int remove_keychain(int Purchased_item)
        {
            KeyChain_Count = KeyChain_Count - Purchased_item;
            return KeyChain_Count;
        }

        int view_order()
        {
            return KeyChain_Count;
        }

        void checkout()
        {
            Console.WriteLine("Please Enter Your Name : ");
            String name = Console.ReadLine();
            Console.WriteLine("\n" + name + " Thank you for shopping " + KeyChain_Count + " KeyChains");
        }

        public void options()
        {
            Boolean reverse = true;
            while (reverse)
            {
                Console.WriteLine("1. Add Keychains to Order:");
                Console.WriteLine("2. Remove keychains from Order:");
                Console.WriteLine("3. View Current Order:");
                Console.WriteLine("4. Checkout:");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Add Keychains to Order:");
                        add_keychain(int.Parse(Console.ReadLine()));
                        break;

                    case 2:
                        Console.WriteLine("Remove Keychains to Order:");
                        remove_keychain(int.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        Console.WriteLine("Total Number of KeyChain is : " + view_order());
                        break;

                    case 4:
                        checkout();
                        reverse = false;
                        break;

                    default:
                        reverse = false;
                        break;
                }

            }
        }
    }
}
