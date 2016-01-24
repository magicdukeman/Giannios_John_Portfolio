using System;

namespace ReturnFunctions
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Create the variables for width and height
			int width1 = 10;
			int height1 = 5;



			//Function call
			//Create a variable to "catch the return value

			int results = CalcArea (width1, height1);

		
			Console.WriteLine (results);


			int results2 = CalcArea (3,4);
			Console.WriteLine (results2);

		}


		public static int CalcArea(int w, int h)
		{
			//Inside of function CalcArea
			//int width = 6;
			//int height = 7;

			//Calc the area of a rectangle
			//int area = width * height;

			int area = w * h;

			//return the area
			return area;

		}
	}
}
