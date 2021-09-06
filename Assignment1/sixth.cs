using System;


namespace Assignment1
{
    class sixth
    {

        public void sortThreeNumbers(int a, int b, int c)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            if (b > c)
            {
                int temp = b;
                b = c;
                c = temp;
            }

        }
        public static void Main(string[] args)
        {
            
            int r;
           
            sixth n = new sixth();
            r = n.sortThreeNumbers(a,b, c);
            Console.WriteLine("the sorted array is :", r);
            Console.Read();
        }
    }
}
