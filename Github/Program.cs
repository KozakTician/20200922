using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class Program
    {
        static void Main(string[] args)
        {
            //x y
            // 1 1 2 3 5 8 13 21

            int n = 10;

            int a1 = 1;
            int a2 = 1;

            int x = 1;
            int y = 1;

            Console.WriteLine($"{a1} {a2} ");

            for (int i = 0; i < n; i++)
            {
                int k = x + y;
                Console.WriteLine($"{k}");
                x = y;
                y = k;
            }
            Console.ReadKey();
        }
    }
}
