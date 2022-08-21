using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1157
{
    class Program
    {
        static char[] Max = new char[26];
        static int[] answer = new int[26];

        static void Main(string[] args)
        {          
            for (int i = 0; i < 26; i++)
            {
                Max[i] = (char)((int)'A' + i);
            }

            string str = Console.ReadLine().ToUpper();

            Count(str);
            Console.WriteLine(Result());
        }

        static void Count(string t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                for (int j = 0; j < Max.Length; j++)
                {
                    if (t[i] == Max[j])
                    {
                        answer[j]++;
                    }
                }
            }
        }

        static char Result()
        {
            int num = 0;
            int maxNum = 0;
            bool same = false;

            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == maxNum && answer[i] != 0)
                {
                    same = true;
                }
                if (answer[i] > maxNum)
                {
                    maxNum = answer[i];
                    num = i;
                    same = false;
                }
            }

            if (same)
            {
                return '?';
            }
            else
            {
                return Max[num];
            }
        }
    }
}
