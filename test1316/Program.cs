using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1316
{
    class Program
    {
        static bool[] check = new bool[26]; // 알파벳 문자가 반복된 여부를 저장
        static int answer = 0; // 정답 출력

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());          

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                Count(str);

                for (int j = 0; j < check.Length; j++)
                {
                    check[j] = false;
                }
            }

            Console.WriteLine(answer);
        }

        static int Count(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (check[(str[i] - 'a')])
                {
                    return 0;
                }

                check[(str[i] - 'a')] = true;

                if ((i + 1) < str.Length)
                {
                    while (str[i] == str[i + 1])
                    {
                        i++;

                        if ((i + 1) < str.Length)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }              
            }

            return answer++;
        }
    }
}
