using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2438
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = int.Parse(str);

            for (int i = 1; i < a + 1; i++)
            {            
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
