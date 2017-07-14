using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Implement multiple inheritance using interfaces

//A program to calculate cost based on area(width and height)
//Create a class which sets width and height of a rectangle
//Create an interface to calculate cost, get the input as area
//Create a derived class which will inherit base class and implement interface and has methods
//            a.to get the area i.e.it will calculate W* H
//            b.to get cost i.e.area * some rate (say 100rs)
//A class with main methods by creating objects on derived class

//output e.g.Total area: 50
//Total paint cost: Rs. 5000


namespace MultipleInheritnace
{

    interface ICalculateAreaCost {
        float CalculateArea(float width, float height);
        float CalculateCost(float area, float rate);
    }

    abstract class Shape : ICalculateAreaCost
    {
        public abstract float CalculateArea(float width, float height);

        public float CalculateCost(float area, float rate)
        {
            //throw new NotImplementedException();
            float cost = area * rate;
            return cost;
        }
    }
    class Rectangle : Shape
    {
        public override float CalculateArea(float width, float height)
        {
          
            return width * height;
        }

        

    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            float rect1Area = rect1.CalculateArea(10, 5);
            float rect1Cost = rect1.CalculateCost(rect1Area, 100);
            //CultureInfo inr = new CultureInfo("en-IN");
            //Console.WriteLine(i.ToString("c", inr));
            //Console.WriteLine($"Total area of rectangle is {rect1Area} and its Total paint cost is {rect1Cost.ToString("C",inr)}");

            Console.WriteLine($"Total area of rectangle is {rect1Area} and its Total paint cost is Rs. {rect1Cost}");
            Console.ReadKey();
        }
    }


}
