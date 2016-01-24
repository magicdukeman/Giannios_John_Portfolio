using System;

namespace ZombieLoopingMadness
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Zombie Madness

			//Givens first
			//Start with 1 zombie
			//it can bite 4 people in a day
			//8 days?

			//How many zombies do we have?

			int numZombies = 1;

			//Number of bites per zombie per day
			int numBites = 4;

			//How days?
			int days = 8;

			//Create our for to cycle through each day
			for(int i=1; i<=days; i++){

				//What happaens in a day?
				//How many new zombies get created?
				int newZombies = numZombies * numBites;

				//End of the day these newzombies join our zombie horde
				numZombies += newZombies;

				//Tell the public how many zombies we have each day
				Console.WriteLine("There are {0} zombies on day #{1}", numZombies,i);
			}


			//How long it will take to reach a million zombies?

			int numDays = 1;

			int zombieHordeNumber = 1;

			while(zombieHordeNumber<=1000000){

				//Happens each day
				int bittenPeople = zombieHordeNumber * numBites;

				//End of the day those zombies

				zombieHordeNumber += bittenPeople;

				//Report to the people how many zombies there are
				Console.WriteLine("On day {0}, there are {1} zombies",numDays, zombieHordeNumber);

				//endo of the day, we increas the day #
				numDays++;
			}



		}
	}
}
