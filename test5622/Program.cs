using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5622
{
    class Program
    {      
        static int CountSecond(char word)
        {
            if (word >= 'A' && word <= 'C')
            {
                return 2;
            }
            else if (word >= 'D' && word <= 'F')
            {
                return 3;
            }
            else if(word >= 'G' && word <= 'I')
            {
                return 4;
            }
            else if(word >= 'J' && word <= 'L')
            {
                return 5;
            }
            else if(word >= 'M' && word <= 'O')
            {
                return 6;
            }
            else if(word >= 'P' && word <= 'S')
            {
                return 7;
            }
            else if(word >= 'T' && word <= 'V')
            {
                return 8;
            }
            else if(word >= 'W' && word <= 'Z')
            {
                return 9;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            int sum = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                sum += CountSecond(charArray[i]) + 1;             
            }

            Console.WriteLine(sum);
        }
    }
}
