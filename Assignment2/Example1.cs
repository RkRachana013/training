using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Example1
    {
		static void Main(string[] args)
		{
			//datatype [] identifier = new datatype[size];
			//datatype [] identifier = {elements of the array seperated by comma};
			Console.WriteLine("Enter the size of the array"); //Ask the user to enter the size of the array
			int size = int.Parse(Console.ReadLine());//get the value...
			int[] elements = new int[size];//create the array

			//Iterate thro the elements of the array to ask the user to enter x number of times...
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine($"Enter the value for the element at location {i}");
				elements[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Now all the values are set!!!!!!!");

			//Display the elements of the array in a single line..
			foreach (int element in elements)
			{
				Console.Write(element + " ");//Observe the differen
			}
			Console.WriteLine();
			Console.Read();
		}
	}
}
