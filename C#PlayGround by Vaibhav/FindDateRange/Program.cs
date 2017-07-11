using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDateRange
{
    class GetDateRange
    {
        static void Main(string[] args)
        {
            var listOfInput= SetData.GetExistingData();
            GetReport.CompareDateRange(listOfInput);
        }

       
    }
}
