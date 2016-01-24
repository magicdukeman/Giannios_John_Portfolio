using System;

namespace TextVariables
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Variables - Characters

			//Characters - char- only the size of one character
			//must be surrounded by single quotes ' '

			//Declar a variable
			char firstLetter;

			//Define the variable
			firstLetter ='A';

			//print the variable to our console
			Console.WriteLine(firstLetter);

			//Declare and Define a variable
			char secondCharacter = 'b';

			//Print the variable to the console
			Console.WriteLine(secondCharacter);

			//String of characters - basically anything bigger than a single character
			//Must be surrounded by double quotes ""

			string wholeSentence = "This is an exaple of a sentence";

			//print out a variable
			Console.WriteLine(wholeSentence);

			//comping Strings
			String combineString = "First Part "+"Second Part";
			Console.WriteLine (combineString);

			string firstName = "Kermit";
			string lastName = "The Frog";
			string wholeName = firstName + " " + lastName;
			Console.WriteLine (wholeName );
		}
	}
}
