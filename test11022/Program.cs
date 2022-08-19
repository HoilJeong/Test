using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test11022
{
    class Program
    {
        static void Main(string[] args)
        {
            string strT = Console.ReadLine();
            int T = int.Parse(strT);

            for (int i = 0; i < T; i++)
            {
                string str = Console.ReadLine();
                string[] strs = str.Split(' ');
                int a = int.Parse(strs[0]);
                int b = int.Parse(strs[1]);
                int c = a + b;

                Console.WriteLine("Case #" + (i + 1) + ": " + a + " + " + b + " = " + c);
            }
        }
    }
}
