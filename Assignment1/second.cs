using System;


namespace Assignment1
{
    class second
    {
        public static void Main(String[] args) 
        {
            Console.WriteLine("Enter the number for multiplication:");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(n + "*" + i + "=" + n * i);
                Console.Read();
            }
        
        }   
    }
}
