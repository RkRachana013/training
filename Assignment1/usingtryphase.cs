using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class usingtryphase
    {
        static void Main(String[] args)
        {
            int age;
        RETRY:
            Console.WriteLine("Enter the Age");
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine($"U R supposed to enter a whole number ranging from {int.MinValue} and {int.MaxValue}");
                goto RETRY;
            }
            Console.WriteLine($"The age is {age}");//New in C# 5.0
            //---------------------using Compare method-------------------------------
            int value1 = 234;
            int value2 = 555;
            int comparison = value1.CompareTo(value2);
            if (comparison == 0)
            {
                Console.WriteLine("They are equal");
            }
            else if (comparison < 0)
                Console.WriteLine("value 1 is lesser than value 2");
            else
                Console.WriteLine("value 1 is greater than value 2");
            Console.Read();
        }
    }
}
