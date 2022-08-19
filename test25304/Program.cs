using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test25304
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int t = 0;

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                string[] strs = str.Split(' ');
                int a = int.Parse(strs[0]); // 개당 금액
                int b = int.Parse(strs[1]); // 갯수

                t += a * b;
            }

            if (x == t)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
