using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2908
{
    class Program
    {
        static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();
            string str1 = Reverse(strs[0]);
            string str2 = Reverse(strs[1]);

            int a = int.Parse(str1);
            int b = int.Parse(str2);

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if (b > a)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
