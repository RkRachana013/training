using System;


namespace Assignment1
{
    class third
    {
        public static void Main(string[] args)
        {
            int i,n,sum=0, neg=0;
            
            Console.WriteLine("Enter the numbers");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the Array Elements ");
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            if (a[i]>0)
            {
               sum =sum+a[i];

            }
            if(a[i]<0)
            {
                neg = neg+a[i];

            }
            Console.WriteLine("the average positive numbers are:");
            Console.WriteLine("the average negative numbers are:" + n);
            Console.Read();

        }  

    }
}
