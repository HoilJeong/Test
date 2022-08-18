using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2753
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int year = int.Parse(str);

            if ((year % 4) == 0 && ((year % 100) != 0 || (year % 400) == 0))
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
