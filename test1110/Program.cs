using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1110
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b;
            int c;
            int a2 = a;
            int count = 0;

            while (true)
            {
                b = a2 / 10;
                c = a2 % 10;
                int sum = b + c;

                a2 = (c * 10) + (sum % 10);
                count++;

                if (a == a2)
                {                    
                    break;
                }                       
            }

            Console.WriteLine(count);
        }
    }
}
