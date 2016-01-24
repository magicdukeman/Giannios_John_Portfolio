using System;

namespace ValidatingUserPrompts
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Validating user prompts with conditionals

			//Ask user for name
			Console.WriteLine("Hello please type in your name and hit enter.");

			//Store results in a sring varialbe
			string userName = Console.ReadLine();

			//Test to see if the user left it blank
			//string.IsNullOrWhiteSpace(variale to check)
			//Returns a bo0lean of true if it is blank
			//Returns a boolean of false if it contants anything

			//Console.WriteLine(string.IsNullOrWhiteSpace(userName));

			//Create a conditional toa test if the user imputed anything
			if(string.IsNullOrWhiteSpace(userName)){
				//then this means the user left it blank
				//Tell the user what went wrong
				Console.WriteLine("Please do not leave this blank.  Enter your name.");
				userName = Console.ReadLine ();

			}

			Console.WriteLine ("Hello "+userName+"! Thanks for running my program!");

			Console.WriteLine ("Please enter an integer between 1 and 10");
			string userIntString = Console.ReadLine ();

			//convert

			//TryParse  int.TryParse(variable to try to convert, out variable name to hold the converted number)
			//Returns a boolean value of true if the conversion works!
			//Returns a false if it has an error
			//It will not throw a runtime error for our program


			//-----int userInt = int.Parse(userIntString);

			//Create a veraible to hole=d the output value
			int userInt;
			//Console.WriteLine (int.TryParse (userIntString, out userInt));
			if(!(int.TryParse(userIntString, out userInt))){}
				//This will run if it could not convert it

				//tell the user the problem
			Console.WriteLine("You typed in something other than an integer between 1 an 10\r\nPlease enter an integer etween 1 and 10:");
			userIntString = Console.ReadLine ();
			int.TryParse (userIntString, out userInt);

			Console.WriteLine (userInt*2);

		}
	}
}
