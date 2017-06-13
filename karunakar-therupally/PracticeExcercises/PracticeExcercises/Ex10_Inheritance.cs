using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*************************************************************************/
/*            
 * EX-10: inheritance-program            
 *  
 ************************************************************************** 
 */

namespace PracticeExcercises
{
    public class Parent
    {
        public Parent() {
            Console.WriteLine("parent constructor");
        }

        public  void Print()
        {

            Console.WriteLine("I am the parent class");
        }
    }

    public class Child:Parent
    {
        public Child()
        {

            Console.WriteLine("child constructor");
        }

        public static new void Print()
        {
            Console.WriteLine("I am the child class");
        }
    }
}
