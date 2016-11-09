using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ConsoleApplication1
{
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }
    struct route
    {
        public orientation direction;
        public double distance;
    }

    class Program
    {
        static void Write()
        {
            WriteLine("Hello form function");
        }
        static double Multiply(double myVal1, double myVal2) => myVal1 * myVal2;
        static int MaxValue(int[] intArray, out int maxIndex)
        {
            int maxVal = intArray[0];
            maxIndex = 0;
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                {
                    maxVal = intArray[i];
                    maxIndex = i;
                }
            }
            return maxVal;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxIndex;
            WriteLine($"The maximum value in myArray is {MaxValue(myArray, out maxIndex)}");
            WriteLine($"The first occurrence of this value is at element { maxIndex + 1}");
            WriteLine(@"List of items:
        1. Item 1
        2. Item 2
        3. Item 3");

        }
    }
}