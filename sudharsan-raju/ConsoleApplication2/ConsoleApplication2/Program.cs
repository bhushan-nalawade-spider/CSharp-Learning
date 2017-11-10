using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {



            int i, j = 0, k = 0;


            Console.Write("Input the comma seperated numbers:");
            string value = Console.ReadLine();
            string[] arr = value.Split(',');

            int[] evenarray = new int[arr.Length];
            int[] oddarray = new int[arr.Length];

            for (i = 0; i < arr.Length; i++)
            {
                int number = Int32.Parse(arr[i]);
                //int number;
               // if (Int32.TryParse(arr[i], out number))
                //{
                    if (number % 2 == 0)
                    {
                        evenarray[j] = number;
                        j++;
                    }
                    else
                    {
                        oddarray[k] = number;
                        k++;
                    }

                }

                Console.Write("\nThe Even elements are : \n");
                for (i = 0; i < j; i++)
                {
                    Console.Write("{0} ", evenarray[i]);
                }

                Console.Write("\nThe Odd elements are :\n");
                for (i = 0; i < k; i++)
                {
                    Console.Write("{0} ", oddarray[i]);
                }
                Console.Write("\n\n");
                Console.ReadLine();
            }
        }
    }



        