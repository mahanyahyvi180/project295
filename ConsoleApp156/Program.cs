using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp156
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = "Happy";
            var string2 = "Birthday";

            Console.WriteLine($"string1=\"{string1}\"");
            Console.WriteLine($"string2=\"{string2}\"");

            Console.WriteLine($"\nResult of string.concat(string1,string2)=" + string.Concat(string1, string2));
            Console.WriteLine($"string1 after concatination={string1}");
            Console.ReadLine();
            
            
        }
    }
}
