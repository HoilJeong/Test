using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2739
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = int.Parse(str);

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"" + a + " * " + i + " = " + (a * i));
            }
        }
    }
}
