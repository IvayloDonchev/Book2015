using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Circle
    {
        public Circle() : this(0.0) { }
        public Circle(double d) => this.Radius = d;
        public double Radius { get; private set;}
        public override string ToString() => $"Circle with radius {Radius} and area {Area}";
        public double Area => Math.PI * Radius * Radius;
    }
}
