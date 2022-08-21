using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1065
{
    class Program
    {
        static bool Hansu(string num)
        {
            if (int.Parse(num) < 100)
            {
                return true;
            }

            int[] digits = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                digits[i] = num[i];
            }

            if ((digits[0] - digits[1]) == (digits[1] - digits[2]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (Hansu(i.ToString()))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
