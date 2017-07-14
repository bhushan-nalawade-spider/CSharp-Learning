using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2_MultipleInheritance
{
    public class Pr2_AreaAndCost : Pr2_Rectangle, 
                                          Ipr2_CostCalculationFromArea
                                          
    {
        public Pr2_AreaAndCost(int width, int height)
            : base(width, height)
        {
            width = base.getWidth();
            height = base.getHeight();
        }

        public int calcuateArea()
        {
            return base.getWidth() * base.getHeight();
        }
       
        public int calculateCost(int ratePerSqMeter)
        {
            return calcuateArea() * ratePerSqMeter;
        }

        
    }
}
