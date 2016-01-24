using System;

namespace SteakTemperature
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			/*
			 * John G. Giannios JR.
			 * Date
			 * Steak Temperature
			 * Secion # 01
			*/

			//Determine wht cook temp our steack is for certain temerature

			/*
			 * Rare - 130-140
			 * Medium Rare - 140-145
			 * Medium - 145-160
			 * Well done - 160-170
			*/

			//ask the user for temperature of their steak
			Console.WriteLine("We are going to determine the Steak Doneness level.\r\nWhat is the temperture of your steak in degrees F, please press return done");

			//Capture the user response and stroe it in a variable
			string steakTempString = Console.ReadLine();

			//Convert to number
			int steakTemp = int.Parse(steakTempString);

			//Start our conditional

			if (steakTemp < 130) {
				Console.WriteLine ("This is uncooked meat.");

			} else if (steakTemp < 140) {
				Console.WriteLine ("The Steak is Rare.");

			} else if (steakTemp < 145) {
				Console.WriteLine ("The Steak is Medium Rare.");
			
			} else if (steakTemp < 160) {
				Console.WriteLine ("The Steak is Meduim.");

			} else if (steakTemp <= 170) {
				Console.WriteLine ("The Steak is Well Done.");
			
			} else {
				Console.WriteLine ("The Steak is burnt. Feed to the Dog!");
			
			}







		}
	}
}
