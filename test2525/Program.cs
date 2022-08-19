using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2525
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string[] str1s = str1.Split();

            int h = int.Parse(str1s[0]);
            int m = int.Parse(str1s[1]);
            int set = int.Parse(str2);

            m += set;

            while (true)
            {
                if (m > 59)
                {
                    h += 1;
                    m = m - 60;

                    if (h > 23)
                    {
                        h = 0;
                    }
                }
                else if (m < 60 && h < 24)
                {
                    break;
                }
            }

            Console.WriteLine($"" + h + " " + m);
        }
    }
}
