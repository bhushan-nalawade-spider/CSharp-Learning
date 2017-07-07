using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearning
{
    class gradebook
    {
       public void Addgrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades = new List<float>();
    }
}
