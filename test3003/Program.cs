using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3003
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();

            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            int c = int.Parse(ss[2]);
            int d = int.Parse(ss[3]);
            int e = int.Parse(ss[4]);
            int f = int.Parse(ss[5]);

            Console.WriteLine($"" + (1 - a) + " " + (1 - b) + " " + (2 - c) + " " + (2 - d) + " " + (2 - e) + " " + (8 - f));
        }
    }
}
