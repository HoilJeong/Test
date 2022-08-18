using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test9498
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int score = int.Parse(str);

            if (90 <= score)
            {
                Console.WriteLine("A");
            }
            else if (80 <= score && score <= 89)
            {
                Console.WriteLine("B");
            }
            else if (70 <= score && score <= 79)
            {
                Console.WriteLine("C");
            }
            else if (60 <= score && score <= 69)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
