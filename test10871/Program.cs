using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test10871
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string[] strs1 = str1.Split();
            int n = int.Parse(strs1[0]);
            int x = int.Parse(strs1[1]);
            int a = 0;

            string str2 = Console.ReadLine();
            string[] strs2 = str2.Split();

            for (int i = 0; i < n; i++)
            {
                a = int.Parse(strs2[i]);

                if (a < x)
                {
                    Console.Write($"" + a + " ");
                }
            }           
        }
    }
}
