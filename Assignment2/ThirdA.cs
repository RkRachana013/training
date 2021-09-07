using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ThirdA
    {

        public static int pattern()
        {
            int i, j,num=5;

            // outer for loop to represent rows
            for (i = 1; i <= num; i++)
            {
                // inner for loop to represent columns
                for (j = 1; j <= i; j++)
                {
                    Console.WriteLine("* ");

                }

                
            }

            return 0;
        }
        public static void Main(string[] args)
        {
            
            pattern();
            Console.Read();

        }
    } 
}