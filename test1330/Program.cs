using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1330
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int a = int.Parse(strs[0]);
            int b = int.Parse(strs[1]);

            if (a > b)
            {
                Console.WriteLine(">");
            }
            else if (a < b)
            {
                Console.WriteLine("<");
            }
            else if (a == b)
            {
                Console.WriteLine("==");
            }
        }
    }
}
