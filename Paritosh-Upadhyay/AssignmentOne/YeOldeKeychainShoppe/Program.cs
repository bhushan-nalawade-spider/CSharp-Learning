using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeOldeKeychainShoppe
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int totalCostOfKeyChains = 0;
            int choice = 0;

            ProgramIntroduction into = new ProgramIntroduction();
            into.Introduction("This is a program for Ye Olde Keychain Shoppe.\n");

        Menu:
            showMenuOnConsole show = new showMenuOnConsole();
            choice = show.showMenu(choice);

            switch (choice)
            {
                case 1:
                    addKeyChains add = new addKeyChains();
                    count = add.add_keychains(count);
                    goto Menu;

                case 2:
                    removeKeyChains remove = new removeKeyChains();
                    count = remove.remove_keychains(count);
                    goto Menu;

                case 3:
                    viewKeyChainsOrder view = new viewKeyChainsOrder();
                    totalCostOfKeyChains = view.viewOrder(count);
                    goto Menu;

                case 4:
                    checkoutOrder cart = new checkoutOrder();
                    cart.checkout(count, totalCostOfKeyChains);
                    break;

                default:
                    break;
            }
        }
    }
}
