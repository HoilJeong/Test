using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2884
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();

            int h = int.Parse(strs[0]);
            int m = int.Parse(strs[1]);

            if (m >= 45)
            {           
                m -= 45;
                             
                Console.WriteLine($"" + h + " " + m);
                           
            }
            else if (m < 45)
            {                         
                if (h == 0)
                {
                    h += 23;
                }
                else if (h > 0)
                {
                    h -= 1;
                }            

                m = 60 + (m - 45);
                
                Console.WriteLine($"" + h + " " + m);
            }
        }
    }
}
