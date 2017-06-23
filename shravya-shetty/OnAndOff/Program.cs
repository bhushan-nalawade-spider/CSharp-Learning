using System;

namespace OnAndOff
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 0;
            DateTime[] offDates = new DateTime[10];
            Console.WriteLine("Enter a Range from date: ");
            DateTime fromRange = readDate();
            Console.WriteLine("Enter a Range To date: ");
            DateTime toRange = readDate();
            while (i == 1)
            {
                Console.WriteLine("Enter the off dates");
                offDates[j++] = readDate();
                Console.WriteLine("press 1 to continue 0 to exit");
                i = Convert.ToInt32(Console.ReadLine());
            }



            for (int k = 0; k < offDates.Length; k++)
            {
                Console.WriteLine("off dates" + offDates[k]);
                Console.WriteLine("On dates from" + offDates[k] + " to " + offDates[k + 1].AddDays(-1));
                Console.ReadLine();
            }


        }

        private static DateTime readDate()
        {
            DateTime userDateTime;

            if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
            {
                Console.WriteLine("The day of the week is: " + userDateTime.DayOfWeek);

            }
            else
            {
                Console.WriteLine("You have entered an incorrect value.");
                System.Environment.Exit(-1);
            }
            return userDateTime;
        }
    }
}
    






