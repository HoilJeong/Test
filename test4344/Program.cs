using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4344
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            double[] nums = new double[100];
            double v = 0;
            double s = 0;
            double t = 0;
            double n = 0;
            double a = 0;

            for (int i = 0; i < c; i++)
            {
                string str = Console.ReadLine();
                string[] strs = str.Split(' ');
                
                n = 0;
                t = 0;
                a = 0;
                s = 0;           

                nums = Array.ConvertAll(strs, st => double.Parse(st));               

                for (int j = 1; j < nums.Length; j++)
                {
                    n = nums[0];
                    t += nums[j];           
                }

                a = t / n;
                v = 0;

                for (int k = 1; k < nums.Length; k++)
                {
                    if (a < nums[k] )
                    {
                        v++;
                    }
                }
                
                s = v / n;                
                
                Console.WriteLine($"" + (s * 100).ToString("F3") + "%");
            }
        }
    }
}
