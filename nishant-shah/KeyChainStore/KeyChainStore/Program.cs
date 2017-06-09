using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChainStore
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyChain kc = new KeyChain();
            Console.WriteLine("Ye Olde Keychain Shoppe:");
            kc.PrintMenu();

            //calling switch menu & PrintMenu till checkout occurs
            int optionSelected = int.Parse(Console.ReadLine());
            while ( optionSelected != 4)
            {
                kc.SwitchMenu(optionSelected);
                kc.PrintMenu();
                optionSelected = int.Parse(Console.ReadLine());
            }

            //Switch Menu for checkout
            kc.SwitchMenu(optionSelected);
        }
    }
}
