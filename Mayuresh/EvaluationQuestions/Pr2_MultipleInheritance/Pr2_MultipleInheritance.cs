using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2_MultipleInheritance
{
    class Pr2_MultipleInheritance
    {
        static void Main(string[] args)
        {
            Pr2_AreaAndCost rectangle = new Pr2_AreaAndCost(20, 10);
            int rectangleRatePerSqMeter = 25;

            int rectangleArea = rectangle.calcuateArea();

            Console.WriteLine("The area of the rectangle is: " + rectangleArea);
            Console.WriteLine("The cost of paiting the rectangle is: " + rectangle.calculateCost(rectangleRatePerSqMeter));
            Console.ReadLine();
        }
    }
}
