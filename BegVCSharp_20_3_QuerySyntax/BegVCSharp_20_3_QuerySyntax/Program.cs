using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BegVCSharp_20_3_QuerySyntax
{
    class Program
    {
        static bool LessThanZero(int n) => n <0;
        static void Main(string[] args)
        {
            //string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small", "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };

            //var queryResults = from n in names where n.StartsWith("S") select n;
            // IEnumerable<string> res= from n in names where n.StartsWith("S") select n;
            // WriteLine("Names beginning with S:");
            //foreach (string item in queryResults)
            // {
            //     WriteLine(item);
            // }
            //WriteLine(queryResults);
            //Write("Program finished, press Enter/Return to continue:");

            //ReadLine();
            // WriteLine();
            // foreach (string s in res)
            //     WriteLine(s);



            //string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small", "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };
            //var queryResults = names.Where(n => n.StartsWith("S"));

            //WriteLine("Names beginning with S:");
            //foreach (var item in queryResults)
            //{
            //    WriteLine(item);
            //}
            //Write("Program finished, press Enter/Return to continue:");
            //ReadLine();



            //string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small", "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };
            //var queryResults = from n in names where n.StartsWith("S") orderby n descending select n;
            //WriteLine("Names beginning with S ordered alphabetically:");
            //foreach (var item in queryResults)
            //{
            //    WriteLine(item);
            //}
            //Write("Program finished, press Enter/Return to continue:");
            //ReadLine();



            //int[] numbers = GenerateLotsOfNumbers(12045678);
            //var queryResults = from n in numbers
            //                   where n < 1000
            //                   select n;
            //WriteLine("Numbers less than 1000:");
            //foreach (var item in queryResults)
            //{
            //    WriteLine(item);
            //}
            //Write("Program finished, press Enter/Return to continue:");
            //ReadLine


            int[] numbers = GenerateLotsOfNumbers(12345678);
            WriteLine("Numeric Aggregates");
            var queryResults =
                from n in numbers
                where n > 1000
                select n
;
            WriteLine("Count of Numbers > 1000");
            WriteLine(queryResults.Count());
            WriteLine("Max of Numbers > 1000");
            WriteLine(queryResults.Max());
            WriteLine("Min of Numbers > 1000");
            WriteLine(queryResults.Min());
            WriteLine("Average of Numbers > 1000");
            WriteLine(queryResults.Average());
            WriteLine("Sum of Numbers > 1000");
            WriteLine(queryResults.Sum(n => (long)n));
            Write("Program finished, press Enter/Return to continue:");
            ReadLine();
        }
        private static int[] GenerateLotsOfNumbers(int count)
        {
            Random generator = new Random(0);
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = generator.Next();
            }
            return result;
        }
    }
}
