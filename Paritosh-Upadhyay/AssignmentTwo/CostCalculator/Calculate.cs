using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostCalculator
{
    class Calculate : InputNumber
    {
       double areaInSquareFeets;

       public void CalculateArea()
        {
            areaInSquareFeets = widthInSquareFeets * heightInSquareFeets;
            Console.WriteLine("Total area to be painted is {0} square feets.", areaInSquareFeets);
        } 

        public void CalculateTotalCost()
        {
            double costOfPainting = areaInSquareFeets * costPerSquareFeet;
            Console.WriteLine("Total cost to paint the wall of {0} square feets is {1}.\n", areaInSquareFeets, costOfPainting);
        }
    }
}
