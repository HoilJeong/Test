using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test8393
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(str);
            int a = 0;

            for (int i = 0; i < n + 1; i++)
            {              
                a += i;               
            }

            Console.WriteLine(a);
        }
    }
}
