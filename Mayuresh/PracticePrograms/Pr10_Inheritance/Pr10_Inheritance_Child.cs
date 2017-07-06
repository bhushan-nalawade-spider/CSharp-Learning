using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr10_Inheritance
{
    class Pr10_Inheritance_Child : Pr10_Inheritance_Parent
    {
        public Pr10_Inheritance_Child()
        {
            Console.WriteLine("Child Constructor");
        }

        public void showCurrentClass()
        {
            Console.WriteLine("I am in Child Class");
            base.showCurrentClass();
        }
    }
}
