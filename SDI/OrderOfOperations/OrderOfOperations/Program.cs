using System;

namespace OrderOfOperations
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Order of Operations
			//PEMDAS - Please Excuse My Dear Aunt Sally
			//Parenthesis, Exponennts, Multiply, Divide, Addition and Subtraction


			//Find the aberage of 4 quizzes

			//Create variables for quiz values
			double quiz1 = 85;
			double quiz2 = 100;
			double quiz3 = 80;
			double quiz4 = 90;

			//Average is add up everything and divide bby he number of items
			double average = (quiz1+quiz2+quiz3+quiz4)/4;
			//add descriptive text
			Console.WriteLine ("The average of the quizzess is "+average);

			//too many parenthesis is not a good thing

			//find the perimeter of a rectangle
			//2*lenght + 2*width

			int lengthRect = 8;
			int widthRect = 6;

			int perimeterRect = 2 * lengthRect + 2 * widthRect;
			Console.WriteLine (perimeterRect);

			
		}
	}
}
