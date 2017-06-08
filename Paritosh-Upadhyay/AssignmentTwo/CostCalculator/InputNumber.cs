using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostCalculator
{
    public class InputNumber
    {
        public static double widthInSquareFeets;
        public static double heightInSquareFeets;
        public static double costPerSquareFeet;

        public void InputWidth()
        {
            Console.Write("Enter the width of the wall: ");
            widthInSquareFeets = double.Parse(Console.ReadLine());
        }

        public void InputHeight()
        {
            Console.Write("Enter the height of the wall: ");
            heightInSquareFeets = double.Parse(Console.ReadLine());
        }

        public void InputcostPerSquareFeet()
        {
            Console.Write("Enter the cost per square feet to paint the wall: ");
            costPerSquareFeet = double.Parse(Console.ReadLine());
        }
    }
}
