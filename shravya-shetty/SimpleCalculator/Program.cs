using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace SimpleCalculator
    {
        class SimpleCalculator
        {
            static void Main(string[] argsS)
            {
                float a, b, res;
                char choice;
            SimpleCalculator cal = new SimpleCalculator();

                do
                {
                    Console.WriteLine("1. Addition\n");
                    Console.WriteLine("2. Subtraction\n");
                    Console.WriteLine("3. Multiplication\n");
                    Console.WriteLine("4. Division\n");
                    Console.WriteLine("5. Exit\n\n");
                    Console.WriteLine("Enter Your Choice : ");
                    choice = Convert.ToChar(Console.ReadLine());
                    switch (choice)
                    {
                        case '1':
                            Console.WriteLine("Enter Two Number : ");
                            a = Convert.ToInt32(Console.ReadLine());
                            b = Convert.ToInt32(Console.ReadLine());
                            res = a + b;
                            Console.WriteLine("Result = " + res);
                            break;
                        case '2':
                            Console.WriteLine("Enter Two Number : ");
                            a = Convert.ToInt32(Console.ReadLine());
                            b = Convert.ToInt32(Console.ReadLine());
                            res = a - b;
                            Console.WriteLine("Result = " + res);
                            break;
                        case '3':
                            Console.WriteLine("Enter Two Number : ");
                            a = Convert.ToInt32(Console.ReadLine());
                            b = Convert.ToInt32(Console.ReadLine());
                            res = a * b;
                            Console.WriteLine("Result = " + res);
                            break;
                        case '4':
                            Console.WriteLine("Enter Two Number : ");
                            a = Convert.ToInt32(Console.ReadLine());
                            b = Convert.ToInt32(Console.ReadLine());
                            res = a / b;
                            Console.WriteLine("Result = " + res);
                            break;
                        case '5':
                            Console.WriteLine(0);
                            break;
                        default:
                            Console.WriteLine("Wrong Choice!!!");
                            break;
                    }

                    Console.WriteLine("\n---------------------------------------\n");
                    Console.ReadLine();
                } while (choice != 5);
            }
        }
    }

