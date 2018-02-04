using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Circle
    {
        public Circle() => radius = 0;
        public Circle(int r) => radius = r;
        //-----------------------------
        private int radius;
        public double Area() => Math.PI * radius * radius;
        public void SetRadius(int r)
        {
            if (r > 0)
                radius = r;
            else
                throw new ArgumentOutOfRangeException("Incorrect radius value");
        }
    }

}
