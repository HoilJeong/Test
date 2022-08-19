using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test10952
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;

            while (c != 0)
            {
                string str = Console.ReadLine();
                string[] strs = str.Split();
                int a = int.Parse(strs[0]);
                int b = int.Parse(strs[1]);

                c = a + b;
                
                if (c != 0)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
