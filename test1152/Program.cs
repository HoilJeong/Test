using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1152
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().Trim();           
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }

            if (str.Length == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(count + 1);
            }
        }
    }
}
