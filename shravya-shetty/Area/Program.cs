using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Area
    {
        public int width;
        public int height;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }


        static void Main(string[] args)
        {
            CalculateArea ca = new CalculateArea();
            int area;
            ca.setWidth(5);
            ca.setHeight(7);
            area = ca.getArea();

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", ca.getArea());
            Console.WriteLine("Total paint cost: ${0}", ca.getCost(area));
            Console.ReadKey();
        }
    }
}
        

