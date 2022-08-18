using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2588
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();        

            int a = int.Parse(str1);
            int b = int.Parse(str2);        

            Console.WriteLine($"" + (a * (b % 100 % 10)));
            Console.WriteLine($"" + (a * (b % 100 / 10)));
            Console.WriteLine($"" + (a * (b / 100)));
            Console.WriteLine($"" + (a * b));
        }
    }
}
