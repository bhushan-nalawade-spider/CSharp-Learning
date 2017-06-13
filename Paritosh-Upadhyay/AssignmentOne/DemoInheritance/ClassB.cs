using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    class ClassB : ClassA
    {
        public ClassB()
        {
            Console.WriteLine("Child Constructor");
        }
        public void MethodInClassB()
        {
            Console.WriteLine("Child Class");
        }
    }
}
