using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    using System;

    public class Solution
    {
        public static int[,] array = new int[2, 3] { {1, 2 ,3 }, { 4, 5, 6 } };    

        public static int solution(int[,] sizes)
        {
            int answer = 0;

            int w = 0;
            int h = 0;

            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                int maxW = Math.Max(sizes[i, 0], sizes[i, 1]);
                int maxH = Math.Min(sizes[i, 0], sizes[i, 1]);

                w = Math.Max(w, maxW);
                h = Math.Max(h, maxH);
            }

            answer = w * h;

            return answer;
        }

        public static void Main()
        {           
            Console.WriteLine(solution(array));
        }
    }
}
