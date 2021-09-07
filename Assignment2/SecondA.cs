using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SecondA
    {
        static int fib(int n)
        {

           
            int[] f = new int[n + 2];
            int i;

            f[0] = 0;
            f[1] = 1;

            for (i = 2; i <= n; i++)
            {
               
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }

       
        public static void Main()
        {
            int n = 20;
            Console.WriteLine(fib(n));
            Console.Read();
        }
    }

}

