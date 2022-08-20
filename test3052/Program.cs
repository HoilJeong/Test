using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3052
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            List<int> nums2 = new List<int>();                 

            for (int i = 0; i < 10; i++)
            {
                nums[i] = int.Parse(Console.ReadLine()) % 42;
            }

            for (int i = 0; i < nums.Length; i++)
            {              
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i > 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (!nums2.Contains(nums[i]))
                        {
                            nums2.Add(nums[i]);
                        }
                    }
                }
            }

            Console.WriteLine(nums2.Count);
        }
    }
}
