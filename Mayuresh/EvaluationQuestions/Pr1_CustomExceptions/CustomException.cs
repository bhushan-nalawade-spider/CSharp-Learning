using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationQuestions
{
    public class CustomException : Exception
    {
        public CustomException(string str) : base (str)
        {
            Console.WriteLine("Custom Exception");
        }
    }
}
