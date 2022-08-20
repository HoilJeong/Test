using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test8958
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int score = 0;
            string str = "";
            string[] strs = new string[100];

            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                sum = 0;
                score = 0;

                for (int j = 0; j < str.Length; j++)
                {
                    strs[j] = str.Substring(j, 1);

                    if (strs[j] == "O")
                    {
                        score += 1;
                        sum += score;
                    }
                    else if (strs[j] == "X")
                    {
                        score = 0;
                        sum += score;
                    }                   
                }

                Console.WriteLine(sum);
            }          
        }
    }
}
