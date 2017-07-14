using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2_MultipleInheritance
{
    public class Pr2_Rectangle
    {
        private int width;
        private int height;

        public Pr2_Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }
       
    }
}
