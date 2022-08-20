using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test10818
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();
            string[] strs = str.Split();                      
            
            int[] nums = Array.ConvertAll(strs, s => int.Parse(s));

            Console.Write($"" + nums.Min() + " ");
            Console.Write($"" + nums.Max() + " ");                  
        }
    }
}
