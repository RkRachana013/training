using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
	class Example2
	{
		public static void Main(string[] args)
		{
			int[,] Scores = { { 45, 56, 66 }, { 56, 66, 77 }, { 45, 55, 89 }, { 78, 89, 90 }, { 67, 83, 81 } };
			//To know the dimensions of this array.. 
			Console.WriteLine("The Dimensions of this array is " + Scores.Rank);
			Console.WriteLine("The total no of elements is " + Scores.Length);
			//Console.WriteLine("The no of elements in the 1st dimension: " + Scores.GetLength(0));
			//Console.WriteLine("The no of elements in the 2nd dimension: " + Scores.GetLength(1));
			Console.WriteLine($"This is an array of {Scores.GetLength(0)} X {Scores.GetLength(1)}");
		}
	}
}

