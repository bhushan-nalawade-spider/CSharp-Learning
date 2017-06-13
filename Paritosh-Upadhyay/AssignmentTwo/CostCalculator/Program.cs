using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();

            calc.InputWidth();

            calc.InputHeight();

            calc.CalculateArea();

            calc.InputcostPerSquareFeet();

            calc.CalculateTotalCost();
        }
    }
}
