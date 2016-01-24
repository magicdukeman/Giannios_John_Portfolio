using System;

namespace UserPrompts
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Readline method of he console
			//reads the nex line in the console and returns the tezt string back to your code

			//ONLY returns a string!!!

			//Ask the user their name

			//Ask the question then listen for the response
			Console.WriteLine ("Please type in your name and then press enter.");

			//Listen for the anwser
			//Create a varaible to "catch" the return text string
			string userName = Console.ReadLine();

			//Say hello to the user
			Console.WriteLine("Hello "+userName+" Welcome to our program");

			//Calculate the Perimeter of a rectangle
			// width *2 + lenght*2

			//Ask the user for the width and lenght

			Console.WriteLine ("Let's find out the perimeter of a rectangle! \r\nPlease enter the width and press enter:");

			//Listen for the answer
			string widthString = Console.ReadLine();

			//Convert the string to a number datatype

			double widthNumber = double.Parse (widthString);


			//Ask the user for a lenght
			Console.WriteLine("Now enter a lenght:");
			string lenghtString = Console.ReadLine ();

			//Convert string to int
			double lenghtNumber = double.Parse (lenghtString);

			double perimeterRect = widthNumber * 2 + lenghtNumber * 2;


			//Add in descriptive text
			Console.WriteLine ("The perimeter of the rectangle is "+perimeterRect);

			//If user types in decimal place then we have issues


		}
	}
}
