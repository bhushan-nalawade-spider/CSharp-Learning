using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramIntroduction intro = new ProgramIntroduction();
            intro.Introduction("This is a program to demonstrate inheritance");

            ClassA parent = new ClassA();
            parent.MethodInClassA();

            ClassB child = new ClassB();
            child.MethodInClassB();
        }
    }
}
