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
    struct Point
    {
        public double X;
        public double Y;
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    class Program
    {
        private static double CalculateDistance2(in Point point1, in Point point2)
        {
            double xDifference = point1.X - point2.X;
            double yDifference = point1.Y - point2.Y;
            return Math.Sqrt(xDifference * xDifference + yDifference * yDifference);
        }
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
        static int Sum(in int a, in int b) => a + b;

        private static ref int Max(ref int x, ref int y)
        {
            if(x > y) return ref x;
            else return ref y;
        }

 


        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            ref int maximum = ref MaxValue(myArray);
            int max = MaxValue(myArray);
            Console.WriteLine($"The maximum is {MaxValue(myArray)}");
            maximum = 100;  // Грешка! Променливата е readonly. 
            foreach (var e in myArray)
                Console.Write($"{e} ");
            Console.WriteLine();

            MaxValue(myArray) = 200;        // Грешка!
            foreach (var e in myArray)
                Console.Write($"{e} ");
            Console.WriteLine();

            var distance = CalculateDistance2(new Point(1, 2), new Point(1, 7));
            Console.WriteLine($"Distance = {distance}");


            int x = 5, y = 6;
            Max(ref x, ref y) = 10;
            const int z = 10;
            Console.WriteLine(Sum(x,y));    //извикване с променливи
            Console.WriteLine(Sum(1,2));    //извикване с числови литерали
            Console.WriteLine(Sum(z, 2));   //извикване с константа и числов литерали

            Circle c = new Circle(12.34);
            Console.WriteLine(c);
            WriteLine(c.Radius);


            Console.ReadKey();



        }
    }
}