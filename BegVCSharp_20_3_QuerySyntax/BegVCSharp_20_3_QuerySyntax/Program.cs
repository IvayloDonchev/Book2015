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
            string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small", "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };
            var queryResults = names.Where(n => n.StartsWith("S"));
            
            WriteLine("Names beginning with S:");
            foreach (var item in queryResults)
            {
                WriteLine(item);
            }
            Write("Program finished, press Enter/Return to continue:");
            ReadLine();
        }
    }
}
