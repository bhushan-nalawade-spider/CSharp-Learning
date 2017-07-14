using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FindDateRange
{
    class GetReport
    {
        public static void CompareDateRange(List<KeyValuePair<DateTime, string>> logData)
        {
            DateTime startDate = GetInputDatesFromUser.StartDate();
            DateTime endDate = GetInputDatesFromUser.EndDate();
//            Console.WriteLine(startDate + "  " + endDate);
            int validDates = GetInputDatesFromUser.CheckInputDatesAreValid(startDate, endDate);
            double noOfDaysPresentInUserInput = (endDate - startDate).TotalDays;
            if (validDates == 1)
            {
                var firstDate = logData.First().Key;
                var lastDate = logData.Last().Key;
                int validRange = CheckForOverLap( firstDate, lastDate, startDate, endDate);
                if (validRange == 1)
                {
                    Console.WriteLine("****Actual Output***");
                    foreach (var keyValuePair in logData)
                {
                   for (int i=0;i <= noOfDaysPresentInUserInput;i++)
                   {
                       if (startDate.AddDays(i) >= lastDate)
                       {
                           Console.WriteLine(startDate.AddDays(i) + " " + logData.Last().Value);
                       }

                            if (keyValuePair.Key == startDate.AddDays(i))
                           {
                              
                               Console.WriteLine(keyValuePair.Key + " " + keyValuePair.Value);
                           }
                       }
                   }
                }
            }
        }

        public static int CheckForOverLap(DateTime startDateA , DateTime endDateA, DateTime startDateB, DateTime endDateB)
        {
            int valid = 0;
            if (((startDateA <= startDateB) && (endDateA >= startDateB)) ||
                ((startDateA <= startDateB) && (endDateA >= endDateB)) ||
                ((startDateA == startDateB) && (endDateA == endDateB)) ||
                ((startDateA <= endDateB) && (endDateA >= endDateB)) ||
                ((startDateA >= startDateB) && (endDateA <= endDateB)) ||
                    ((endDateA <=startDateB) && (endDateA <= endDateB)))
            {
                valid = valid + 1;

            }
            if (endDateB < startDateA )
                Console.WriteLine("For the given dates,{0} and {1}, No record found!!", startDateB,endDateB);
            if(startDateB < startDateA)
                Console.WriteLine("No record found till {0}!!", startDateA.AddDays(-1));
            return valid;
        }
    }
}
