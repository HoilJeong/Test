using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1546
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            string[] strs = str.Split();
            float[] nums = Array.ConvertAll(strs, s => float.Parse(s));
            float[] nums2 = new float[n];
            float m = nums.Max();
            int t = 0;
            float a = 0;

            for (int i = 0; i < n; i++)
            {                               
                nums2[i] = nums[i] / m * 100;               
            }

            for (int i = 0; i < n; i++)
            {
                a += nums2[i] / n;               
            }
            
            Console.WriteLine(a);
        }
    }
}
