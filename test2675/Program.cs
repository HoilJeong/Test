using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2675
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < t; i++)
            {
                string str = Console.ReadLine();
                string[] strs = str.Split();
                int r = int.Parse(strs[0]); // 반복 횟수
                string anwser = "";

                for (int j = 2; j < str.Length; j++)
                {
                    for (int k = 0; k < r; k++)
                    {
                        anwser += str[j];
                    }
                }

                Console.WriteLine(anwser);
            }                               
        }
    }
}
