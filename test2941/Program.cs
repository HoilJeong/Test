using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2941
{
    class Program
    {
        static string[] alpabet = new string[8]
        {
            "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z="
        };

        static int Count(string str, string[] alpabet)
        {
            int answer = 0;
            int sum = 0;

            for (int i = 0; i < alpabet.Length; i++)
            {
                // 처음 길이에서 - 타겟 단어 전부 삭제 => 없어진 길이 획득 => 이것을 단어 길이로 나누면 횟수 획득
                sum = str.Length - str.Replace(alpabet[i], "").Length;
                str = str.Replace(alpabet[i], "_");
                answer += sum / alpabet[i].Length;
            }

            str = str.Replace("_", "");
            answer += str.Length;

            return answer;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(Count(str, alpabet));
        }
    }
}
