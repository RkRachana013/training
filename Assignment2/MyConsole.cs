using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MyConsole
    {
        public static int GetNumber(string question)
        {
            int result;
        TRYAGAIN:
            Console.WriteLine(question);
            if (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Input value should be a valid number");
                goto TRYAGAIN;
            }
            return result;
        }

        public static int GetInt(string question)
        {
            int result;
        TRYAGAIN:
            Console.WriteLine(question);
            if (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Input value should be a valid number");
                goto TRYAGAIN;
            }
            return result;
        }
    }
}