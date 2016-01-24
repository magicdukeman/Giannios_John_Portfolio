using System;

namespace MathOperators
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Math operators
			//+ addition - concatenation when deal with text
			// - subtraction
			//* multiplication
			//  / divion

			//Area of triangle
			//width * height /2

			int width = 8;
			int height = 7;

			int areaTriangle = width * height / 2;
			Console.WriteLine (areaTriangle);

			//add descriptive text to our final output
			Console.WriteLine("The area of a triangle with width of "+width+" and height of "+height+" is "+areaTriangle);

			//Modulo %
			//Give the remainder left over

			decimal normalDivision = 36 / 10m;
			Console.WriteLine (normalDivision);

			int remainderVal = 15 % 7;
			Console.WriteLine (remainderVal);

			//Tell if something is an even or an odd
			//%2 - if 1 then it is odd and if it is 0 it is even

			int evenOrOdd = 31 % 2;
			Console.WriteLine (evenOrOdd);


		}

	}
}
