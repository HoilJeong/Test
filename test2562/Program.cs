using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2562
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[9];

            for (int i = 0; i < 9; i++)
            {
                int a = int.Parse(Console.ReadLine());
                nums[i] = a;
            }

            int maxValue = nums.Max();
            int maxIndex = nums.ToList().IndexOf(maxValue);

            Console.WriteLine(maxValue);
            Console.WriteLine(maxIndex + 1);
        }
    }
}
