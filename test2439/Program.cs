using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2439
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = int.Parse(str);

            for (int i = 1; i < a + 1; i++)
            {        
                for (int k = a - i; k > 0; k--)
                {
                    Console.Write(" ");
                }

                for(int j = 0; j < i; j++)
                {
                    
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
