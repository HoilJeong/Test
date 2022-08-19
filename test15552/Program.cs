using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test15552
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string strT = sr.ReadLine();         
            int T = int.Parse(strT);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                string strT2 = sr.ReadLine();
                string[] strT2s = strT2.Split(' ');
                int T2 = int.Parse(strT2s[0]);
                int T3 = int.Parse(strT2s[1]);
                sb.Append(T2 + T3 + "\n");               
            }

            Console.Write(sb);
        }
    }
}
