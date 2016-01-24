using System;

namespace WhileLoops
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Whle loops

			//Declare a define a starting counting variable
			int counter =20;

			while(counter>0){
				Console.WriteLine ("The counter is {0}", counter);


				//Increment of change to the counter variable
				counter--;

			}

			Console.WriteLine ("Please enter your name.");

			//Save the user response
			string userName = Console.ReadLine();

			//Validate the user did not leave blank
			while(string.IsNullOrWhiteSpace(userName)){

				//Tell the user what is happening
				Console.WriteLine("Please do not leave this blank\r\nPlease enter your name.");

				//Redefine the variable
				userName = Console.ReadLine();
			}


			Console.WriteLine ("Hi {0}! Please enter a number.", userName);
			string numberString = Console.ReadLine ();

			//Declare the variable to hold the converted value
			double userNum;

			while(!double.TryParse(numberString, out userNum)){

				//Tell the user the problem
				Console.WriteLine("You typed something other than a number\r\nPlease enter a number.");


				//Catch the user response
				numberString = Console.ReadLine();
			}

			Console.WriteLine ("The number you type in is {0}\r\n", userNum);

			//Declare and define the variable to test
			int i = 45;

			// do while loops run at least once then do the check
			do {
				Console.WriteLine ("The value of i is {0}", i);

				//Increment of change
				i-=5;


			} while(i > 5);





		}
	}
}
