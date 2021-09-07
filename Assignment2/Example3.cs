using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Example3
    {
		static void Main(string[] args)
		{
			int[,] Scores = { { 45, 56, 66 }, { 56, 66, 77 }, { 45, 55, 89 }, { 78, 89, 90 }, { 67, 83, 81 } };
			//Display the elements of this array in matrix format:
			for (int i = 0; i < Scores.GetLength(0); i++)
			{
				for (int j = 0; j < Scores.GetLength(1); j++)
				{
					Console.Write(Scores[i, j] + "  ");
				}
				Console.WriteLine();//To move over to the next line...
				Console.Read();
			}
		}
	}
}
