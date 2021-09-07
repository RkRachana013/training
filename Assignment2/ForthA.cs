using System;


namespace Assignment2
{
    class ForthA
    {
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Enter the number of team members"); 
			int size = int.Parse(Console.ReadLine());
			String[] elements = new String[size];

			
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine($"Enter the name of member  {i}");
				elements[i] = (Console.ReadLine());

			}
			Console.WriteLine("Now all the values are set!!!!!!!");

			
			foreach (string element in elements)
			{
				Console.Write(element + " ");
			}
			Console.WriteLine();
			Console.Read();
		}
	}
}
