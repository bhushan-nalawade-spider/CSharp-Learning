using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            gradebook gb = new gradebook();

            gb.Addgrade(55.5f);
            gb.Addgrade(20);

            gradebook gb2 = gb;
            gb = new gradebook();
            gb.Addgrade(11);

        }
    }
}
