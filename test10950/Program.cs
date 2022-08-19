using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test10950
{
    class Program
    {
        static void Main(string[] args)
        {           
            string strT = Console.ReadLine();         
            int T;
            T = int.Parse(strT);
            int[] nums = new int[T];
            int a = 0;
            int b = 0;

            for (int i = 0; i < T; i++)
            {
                string str = Console.ReadLine();
                string[] strs = str.Split(' ');
                a = int.Parse(strs[0]);
                b = int.Parse(strs[1]);
                nums[i] = a + b;

                Console.WriteLine(nums[i]);
            }         
        }
    }
}
