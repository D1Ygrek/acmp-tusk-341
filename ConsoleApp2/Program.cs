using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[] godfrommachine = new int[21];
            for(int i = 1; i < 12;i++)
            {
                godfrommachine[i] = i-1;
            }
            godfrommachine[12] = 22;
            for(int i = 3; i <= 9;i++)
            {
                int k = 0;
                if (i % 2 == 0)
                {
                    k = 1;
                }
                godfrommachine[i + 10] = i * 10+k;
            }
            godfrommachine[20] = 111;
            string result = "";
            if (x <= 20)
            {
                Console.WriteLine(godfrommachine[x]);
            }
            else
            {
                x -= 21;
                int t = x % 2;
                result = result + (x % 8 + 2).ToString();
                for(int i = 0; i < x / 8 + 2; i++)
                {
                    result = result + t.ToString();
                }
            }
            Console.WriteLine(result);
        }
    }
}
