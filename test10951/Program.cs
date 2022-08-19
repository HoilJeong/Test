using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test10951
{
    class Program
    {
        static void Main(string[] args)
        {           
            while (true)
            {
                
                
                string str = Console.ReadLine();
                if (str == null)
                {
                    break;
                }
                string[] strs = str.Split();
                int a = int.Parse(strs[0]);
                int b = int.Parse(strs[1]);
                Console.WriteLine(a + b);                        
            }
        }
    }
}
