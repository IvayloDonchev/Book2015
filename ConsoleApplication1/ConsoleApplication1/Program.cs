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
        static void Main(string[] args)
        {
            //    route myRoute;
            //    int myDirection = -1;
            //    double myDistance;
            //    WriteLine("1) North\n2) South\n3) East\n4) West");
            //    do
            //    {
            //        WriteLine("Select a direction:");
            //        myDirection = ToInt32(ReadLine());
            //    } while ((myDirection < 1) || (myDirection > 4));
            //    WriteLine("Input a distance:");
            //    myDistance = ToDouble(ReadLine());
            //    myRoute.direction = (orientation)myDirection;
            //    myRoute.distance = myDistance;
            //    WriteLine($"myRoute specifies a direction of {myRoute.direction} " +
            //    $"and a distance of {myRoute.distance}");

            //    Write("Enter the size of the array: ");
            //    int size = Convert.ToInt32(ReadLine());
            //    int[] myIntArray = new int[size];
            //    size = myIntArray.Length; // По същество същото
            //    for (int i = 0; i < size; ++i)
            //        myIntArray[i] = (i + 1) * 10;
            //    foreach(int i in myIntArray)
            //        Write($"{i} ");
            //    WriteLine();

            //    double[,] hillHeight = new double[3, 4];
            //    int[][] jaggedIntArray;
            //    jaggedIntArray = new int[2][];
            //    jaggedIntArray[0] = new int[3];
            //    jaggedIntArray[1] = new int[4];


            //    //try
            //    //{
            //    //    myIntArray[6] = 3;
            //    //    WriteLine(myIntArray[6]);
            //    //}
            //    //catch(IndexOutOfRangeException e)
            //    //{
            //    //    WriteLine(e.Message);
            //    //}


            //    ReadKey();


            string myString = "This is a test.";
            char[] separator = { ' ' };
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                WriteLine($"{word}");
            }
            for (int i = myString.Length-1; i >= 0; --i)
                Write(myString[i]);
            WriteLine();       
            ReadKey();
        }
    }
}