using System;

namespace Assignment1
{
    class first
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the celsius");
            int celsius = int.Parse(Console.ReadLine());
            Console.WriteLine("kelvin=" + (celsius + 273));
            Console.WriteLine("Fahrenheit=" + (celsius * 18 / 10 + 32));
            Console.Read();
        }
    }
}
