using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test11720
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
         
            string[] strs = new string[str.Length];

            int sum = 0;

            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = Convert.ToString(str[i]);
                sum += int.Parse(strs[i]);
            }

            Console.WriteLine(sum);
        }
    }
}
