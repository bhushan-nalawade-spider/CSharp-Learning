using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr10_Inheritance
{
    class Pr10_Inheritance
    {
        static void Main(string[] args)
        {
            Pr10_Inheritance_Child testChild = new Pr10_Inheritance_Child();

            testChild.showCurrentClass();

            Console.ReadLine();
        }
    }
}
