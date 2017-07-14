using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationQuestions
{
    class Pr1_CustomExceptions
    {
        static void Main(string[] args)
        {
            try
            {
                throw new CustomException  ("It's a custome exception.");

            }

            catch(CustomException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            finally
            {
                Console.Read();
            }
        }
    }
}
