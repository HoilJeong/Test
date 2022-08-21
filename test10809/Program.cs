using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test10809
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();           

            for (int i = 97; i < 123; i++)
            {
                if (str.Contains(Convert.ToChar(i)))
                {
                    Console.Write(str.IndexOf(Convert.ToChar(i)) + " ");                   
                }
                else
                {
                    Console.Write("-1 ");
                }
            }
        }
    }
}
