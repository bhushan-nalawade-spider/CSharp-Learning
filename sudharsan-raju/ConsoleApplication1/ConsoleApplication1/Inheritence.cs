using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Constructor.");
        }
        public void print()
        {
            Console.WriteLine("I am the Parent Class.");
        }
    }
    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("Child Constructor.");
        }
        public new void print()
        {
            base.print();
            Console.WriteLine("I am the child Class");
        }

        //  // public static void Main()
        //           {
        //               ChildClass child = new ChildClass();
        //               child.print();
        //                    }  
        //}

    }
}

