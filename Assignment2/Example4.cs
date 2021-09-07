using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Example4
    {
		static void Main(string[] args)
		{
			//Jagged array
			int[][] school = new int[5][];//Jagged array syntax..
			school[0] = new int[] { 45, 67, 77, 56, 45, 62 };
			school[1] = new int[] { 56, 45, 62 };
			school[2] = new int[] { 23, 55, 81, 12, 18, 77, 56, 45, 62 };
			school[3] = new int[] { 77, 56, 45, 62 };
			school[4] = new int[] { 45, 67, 77, 56, 45, 62, 77, 56, 35, 68 };
			//Length property of the Jagged Array will give the rows of the array
			for (int i = 0; i < school.Length; i++)
			{
				foreach (int value in school[i])
					Console.Write(value + " ");
				Console.WriteLine();
			}

		}
	}
}
