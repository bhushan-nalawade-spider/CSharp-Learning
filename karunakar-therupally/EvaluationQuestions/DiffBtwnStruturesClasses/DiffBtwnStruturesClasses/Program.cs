using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classes are usually used for large amounts of data, whereas structs are usually used for smaller amounts of data

namespace DiffBtwnStruturesClasses
{
    class Program: ClassDefaultValues //Classes can be inherited whereas structures not.  cannot override any methods within a structure except those belonging to the type object:
    {
        static void Main(string[] args)
        {
            StructDefaultValues struct1;
            struct1.item = "C#";
            struct1.rate = 99.50f;
            struct1.available = true;
           
            // we can not have default values for structs, if above values are not assignd and try to access leads CE
            Console.WriteLine($"Struct Value name:{struct1.item}, rate:{struct1.rate}, available: {struct1.available}");


            Console.WriteLine($"Class Default Values {new ClassDefaultValues().item}, rate:{new ClassDefaultValues().rate}, available: {new ClassDefaultValues().available}");
            Console.ReadKey();
        }

    }

    //cannot override any methods within a structure except the following belonging to the type object:
    //A structure must always have the default parameterless constructor defined as public,  can't define a private parameter-less constructor 
    struct StructDefaultValues
    {
        public String item;
        public bool available;
        public float rate;
        
    }

    //A structure can't be abstract, a class can.
    //Fields are automatically initialized with classes to 0/false/null wheatheras strucutres are not
    class ClassDefaultValues
    {
        public String item;
        public bool available;
        public float rate;
    }
}
