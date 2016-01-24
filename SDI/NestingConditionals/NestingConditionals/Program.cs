using System;

namespace NestingConditionals
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Nesting Conditionals

			//Some decisions affect other decisions

			//if it is warm enough, lets go to the beach. it not lets see a movie
			//if the water is warm and then lets go swimming if not lets get a tan


			//Create a tempature variable
			int temp = 90;

			//Create a water temp variable
			int waterTemp = 72;
				
			//Test to see if goin to the beach
			if (temp >= 85) {
				//Warm enough lets go to the beach
				Console.WriteLine ("Its is warm enough, let's go to the beach.");

				//Conditional block for water temp
				if (waterTemp>=75){
					Console.WriteLine ("Let's go swimming");

				} else {

					Console.WriteLine ("Water is a little cold, lets get a tan!");

				}
			
			} else {
					
				//Cold so lets go to the movies
				Console.WriteLine ("It is cold, so let's go see a movie");
			
			
			}



		}	
	}
}
