using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();

            double a = double.Parse(ss[0]);
            double b = double.Parse(ss[1]);

            Console.WriteLine(a / b);
        }
    }
}
