using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDateRange
{
    class GetInputDatesFromUser
    {
        public static DateTime StartDate()
        {
            DateTime startDate;
            Console.WriteLine("Please Enter start date (dd/MM/yyyy) format=>");
            var userInputForStartDate = Console.ReadLine();
            DateTime.TryParse(userInputForStartDate, out startDate);
            
            return startDate;
        }

        public static DateTime EndDate()
        {
            DateTime endDate;
            Console.WriteLine("Please Enter end date (dd/MM/yyyy) format=>");
            var userInputForEndDate = Console.ReadLine();
            DateTime.TryParse(userInputForEndDate, out endDate);
            
            return endDate;
        }

        public static int CheckInputDatesAreValid(DateTime startDate, DateTime endDate)
        {
            DateTime badDate;
            DateTime.TryParse("01-01-0001 00:00:00", out badDate);
            if (startDate > endDate || startDate == badDate || endDate == badDate)
            {
                Console.WriteLine("Invalid dates! Program terminated..");
                return 0;
            }
            return 1;
        }
    }
}
