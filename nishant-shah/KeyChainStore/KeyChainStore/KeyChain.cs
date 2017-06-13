using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChainStore
{

    class KeyChain
    {
        private double _price;
        private int _currentOrder;
        private const int pricePerUnit = 10;

        public KeyChain()
        {
            Price = 0;
            CurrentOrder = 0;
        }

        public double Price
        {
        get
            {
                return _currentOrder*pricePerUnit;
            }
        set
            {

                _price = value;
            }
        }

        public int CurrentOrder
        {
            get
            {
                return _currentOrder;
            }
            set
            {

                _currentOrder = value;
            }
        }

        public void SwitchMenu(int menuCount)
        {
            switch(menuCount)
            {
                case 1: AddKeychains(1);
                    break;
                case 2: RemoveKeyChains(1);
                    break;
                case 3: ViewOrder();
                    break;
                case 4: Checkout();
                    break;
                default: defaultLogic();
                    break;
            }
        }

        public void Checkout()
        {
           Console.Write("What is your name ?:");
           String name = Console.ReadLine();
           Console.WriteLine("Keychains in order:- " + CurrentOrder);
           Console.WriteLine("Keychains cost per unit:- " + pricePerUnit);
           Console.WriteLine("Total cost is:-" + Price);
           Console.WriteLine("Thanks for your order- " + name);
           Console.ReadLine();
        }

        public void defaultLogic()
        {
            throw new NotImplementedException();
        }

        public void AddKeychains(int keychainCount)
        {
            Console.WriteLine("You have " + CurrentOrder + " keychains. How many to add?: ");
            int keyChainCount = int.Parse(Console.ReadLine());
            CurrentOrder = CurrentOrder + keyChainCount;
            Console.WriteLine("KeyChains in Order:- " + CurrentOrder.ToString());            
        }

        public void RemoveKeyChains(int keychainCount)
        {
            Console.WriteLine("You have "+CurrentOrder+" keychains. How many to remove?: ");
            int keyChainCount = int.Parse(Console.ReadLine());
            CurrentOrder = CurrentOrder - keyChainCount;

            while(CurrentOrder<0)
            {
                Console.WriteLine("Oops!! The Total keyChain order will go to negative. Please enter a valid number to remove:-");
                CurrentOrder = CurrentOrder + keyChainCount;

                Console.WriteLine("You have " + CurrentOrder + " keychains. How many to remove?: ");
                
                keyChainCount = int.Parse(Console.ReadLine());
                CurrentOrder = CurrentOrder - keyChainCount;
            }
            Console.WriteLine("KeyChains in Order:- " + CurrentOrder.ToString());
        }

        public void ViewOrder()
        {
            Console.WriteLine("Total Keychains in order:- " + CurrentOrder);
            Console.WriteLine("Keychain's cost per Unit:- " + pricePerUnit);
            Console.WriteLine("Total cost :-Rs " + (Price).ToString());
        }

        public void PrintMenu()
        {
            Console.WriteLine("1. Add Keychains to Order:");
            Console.WriteLine("2. Remove keychains from Order:");
            Console.WriteLine("3. View Current Order:");
            Console.WriteLine("4. Checkout:");
            Console.WriteLine("Please enter your choice: ");
        }

    }
}
