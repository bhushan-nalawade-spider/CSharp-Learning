using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDateRange
{
    internal class SetData
    {
        public static List<KeyValuePair<DateTime, string>> GetExistingData()
        {
            List<KeyValuePair<DateTime, string>> statusListWithDate = new List<KeyValuePair<DateTime, string>>();
            statusListWithDate.Add(new KeyValuePair<DateTime, string>(DateTime.Today.Date, "ON"));
            statusListWithDate.Add(new KeyValuePair<DateTime, string>(DateTime.Today.AddDays(1), "ON"));
            statusListWithDate.Add(new KeyValuePair<DateTime, string>(DateTime.Today.AddDays(2), "OFF"));
            statusListWithDate.Add(new KeyValuePair<DateTime, string>(DateTime.Today.AddDays(3), "ON"));
            statusListWithDate.Add(new KeyValuePair<DateTime, string>(DateTime.Today.AddDays(4), "OFF"));
            statusListWithDate.Add(new KeyValuePair<DateTime, string>(DateTime.Today.AddDays(5), "ON"));
            statusListWithDate.Add(new KeyValuePair<DateTime, string>(DateTime.Today.AddDays(6), "ON"));
            statusListWithDate.Add(new KeyValuePair<DateTime, string>(DateTime.Today.AddDays(7), "OFF"));
            statusListWithDate.Add(new KeyValuePair<DateTime, string>(DateTime.Today.AddDays(8), "ON"));
            statusListWithDate.Add(new KeyValuePair<DateTime, string>(DateTime.Today.AddDays(9), "ON"));

            foreach (var keyValuePair in statusListWithDate)
            {
                Console.WriteLine(keyValuePair);
            }
            var a= statusListWithDate.First().Key;
            return statusListWithDate;
        }
    }
}
