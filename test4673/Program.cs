using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4673
{
    class Program
    {
        static int PlusNumber(int n)
        {
            int num;

            if (n < 10)
            {
                num = n + n;
            }
            else if (n >= 10 && n < 100)
            {
                num = n + (n / 10) + (n % 10);
            }
            else if (n >= 100 && n < 1000)
            {
                num = n + (n / 100) + ((n % 100) / 10) + ((n % 100) % 10);
            }
            else if (n >= 1000 && n < 10000)
            {
                num = n + (n / 1000) + ((n % 1000) / 100) + (((n % 1000) % 100) / 10) + (((n % 1000) % 100) % 10); 
            }
            else
            {
                num = n + 1;
            }

            return num;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[10000];

            for (int i = 0; i < 10000; i++)
            {
                nums[i] = PlusNumber(i);
            }

            StringBuilder selfNumber = new StringBuilder();
            bool isCheck = true;

            for (int i = 0; i < 10001; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == i)
                    {
                        isCheck = false;
                        break;
                    }
                    else
                    {
                        isCheck = true;
                    }
                }

                if (isCheck)
                {
                    selfNumber.AppendLine(i.ToString());
                }
            }

            Console.WriteLine(selfNumber);
        }
    }
}
