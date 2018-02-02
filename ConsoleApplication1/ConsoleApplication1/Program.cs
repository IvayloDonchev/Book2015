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
        static ref int MaxValue(int[] intArray)
        {

            int maxIndex = 0;
            for (int i = 1; i < intArray.Length; i++)
                if (intArray[i] > intArray[maxIndex])
                    maxIndex = i;
            return ref intArray[maxIndex];
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            ref int maximum = ref MaxValue(myArray);
            Console.WriteLine($"The maximum is {MaxValue(myArray)}");
            maximum = 100;
            foreach (var e in myArray)
                Console.Write($"{e} ");
            Console.WriteLine();

            MaxValue(myArray) = 200;
            foreach (var e in myArray)
                Console.Write($"{e} ");
            Console.WriteLine();

            Console.ReadKey();



        }
    }
}