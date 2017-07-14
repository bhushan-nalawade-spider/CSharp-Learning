using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr8_OnOffDates
{
    class Pr8_OnOffDates
    {
        static void Main(string[] args)
        {
            DateTime lowerDate = new DateTime(2017, 8, 1);
            DateTime workingDate = lowerDate;
            DateTime upperDate = new DateTime(2017, 8, 31);
            TimeSpan tSpan =new TimeSpan (1,0,0,0);

            DateTime[] companyHolidays = { new DateTime(2017, 8, 15), new DateTime(2017, 8, 31)};

            for (int i = lowerDate.Day; i <= upperDate.Day; i++, workingDate += tSpan  )
            {
                if(!DecideIfOffDay(workingDate, companyHolidays))
                {
                    Console.WriteLine(workingDate.Day + ": Working Day");
                }
            }

            Console.Read();

           //lowerDate.
        }

        private static bool DecideIfOffDay(DateTime workingDate, DateTime[] companyHolidays)
        {
            bool offDay = false;
            if (workingDate.DayOfWeek.ToString().Equals("Saturday") || workingDate.DayOfWeek.ToString().Equals("Sunday"))
            {
                Console.WriteLine(workingDate.Day + ": Off Day (Weekend)");
                offDay = true;
            }
            foreach (DateTime date in companyHolidays)
            {
                if (date == workingDate)
                {
                    Console.WriteLine(workingDate.Day + " Off Day (Company Holiday)");
                    offDay = true;
                }
            }

            return offDay;
        }
    }
}
