using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2480
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int a = int.Parse(strs[0]);
            int b = int.Parse(strs[1]);
            int c = int.Parse(strs[2]);
            int money = 0;

            if (a == b && a == c && b == c)
            {
                money = 10000 + a * 1000;
            }
            else if (a == b || a == c || b == c)
            {
                if (a == b)
                {
                    money = 1000 + a * 100;
                }
                else if (a == c)
                {
                    money = 1000 + a * 100;
                }
                else if (b == c)
                {
                    money = 1000 + b * 100;
                }
            }
            else
            {
                if (a != b && a != c && b != c)
                {
                    if (a > b && a > c)
                    {
                        money = a * 100;
                    }
                    else if (b > a && b > c)
                    {
                        money = b * 100;
                    }
                    else if (c > a && c > b)
                    {
                        money = c * 100;
                    }
                }
            }

            Console.WriteLine(money);
        }
    }
}
