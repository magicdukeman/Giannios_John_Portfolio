using System;

namespace Giannios_John_Expressions_Assignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* John G. Giannios Jr.
			 * November 3, 2015
			 * Expressions Assignment
			 * Online - Section 01
			*/

			//This program calculate's your batch of candy total weight of all of your ingredients.


			//Say hello to employee
			Console.WriteLine ("Welcome to the Giannios Candy Batch Calculater \r\nPlease enter your name and press enter\r\n");
			string name = Console.ReadLine ();
			Console.WriteLine ("Okay let's get started " + name + "\r\n");

			//Create an array
			string[] ingredientsNames = new string[3];

			//Prompt the user for name of the ingredients and how many pounds are being used

			//Parse the intput into decimals for the amount of indredient used
			//Use an array for the name of the ingredient names

			Console.WriteLine ("Name of First Ingredient:");
			ingredientsNames [0] = Console.ReadLine ();
			Console.WriteLine ("How Many lbs of product?");
			string ingredientOne = Console.ReadLine (); 
			Console.WriteLine ("Name of Second Ingedient:");
			ingredientsNames [1] = Console.ReadLine ();
			Console.WriteLine ("How Many lbs of Product:");
			string ingredientTwo = Console.ReadLine ();
			Console.WriteLine ("Name of Third Ingredient");
			ingredientsNames [2] = Console.ReadLine ();
			Console.WriteLine ("How Many lbs of Product:");
			string ingredientThree = Console.ReadLine ();
			Console.WriteLine ("");

			//Convert strings to int
			Console.WriteLine ("Your Ingredient List\r\n");

			decimal lbsIngredientOne = decimal.Parse (ingredientOne);
			decimal lbsIngredientTwo = decimal.Parse (ingredientTwo);
			decimal lbsIngredientThree = decimal.Parse (ingredientThree);

			//List the batch ingredients with the amount being used
			Console.WriteLine (ingredientsNames[0] +" "+ lbsIngredientOne + "lbs.");
			Console.WriteLine (ingredientsNames[1] +" "+ lbsIngredientTwo + "lbs.");
			Console.WriteLine (ingredientsNames[2] +" "+ lbsIngredientThree + "lbs.");

			//Calculate the size of the batch
			decimal totalBatchSize = lbsIngredientOne+lbsIngredientTwo+lbsIngredientThree;

			//lets show the wieght of the batch with and without the kettle
			decimal kettle = totalBatchSize;
			kettle+=10;
			Console.WriteLine ("");
			Console.WriteLine ("Your batch wieght is " + totalBatchSize + "lbs.\r\n  ");
			Console.WriteLine ("Your batch wieght with kettle is " + kettle);

			/*Test my Solution
			 * ----- Test One----
			 * I entered "Chocolate" and got "Chocolate
			 * I entered "65" and got "65"
			 * I entered "Coconut Oil" and got "Coconut Oil"
			 * I entered "15" and got "15"
			 * I entered "Peanuts" and got "Peanuts"
			 * I entered "5" and got "5"
			 * Total Batch showed "85lbs", I checked the result and it is correct.
			 * Total Batch with Kettle showed "95", I checked the result and it is correct
			 * -----Test Two------
			 * I entered "Dark Chocolate" and got "Dark Chocolate"
			 * I entered "45" and got "45"
			 * I entered "Coconut OIl" and got "Coconut Oil"
			 * I entered "5" and got "5"
			 * I entered "Coconut" and got "Coconut"
			 * I entered "3" and got "3"
			 * Totol batch showed "53", I checked the result and it is correct
			 * Total Batch with kettle showed "63", I checked the result and it is correct
			*/

		}
	}
}