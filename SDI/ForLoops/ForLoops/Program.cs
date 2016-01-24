using System;

namespace ForLoops
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//For loops
			//for(variable; test; increment of change)

			for (int counter = 0; counter <= 11; counter++) {
				Console.WriteLine ("The value of counter is {0}", counter);

				if(counter==2){
					Console.WriteLine ("Stopping the loop.");
					break;
				}
			
			}

			//break will stop the loop


			//continue will only skip the iteration

			for(int i=0; i<50; i++){

				if(i>10 && i<30){

					continue;
				}

				Console.WriteLine ("The value of i is {0}", i);

			}






			//Create an array
			int[] myBills = new int[4]{30,40,50,60};
			Console.WriteLine (myBills [0]);

			//create foreach loop
			foreach (int arrayItem in myBills){
				Console.WriteLine ("The item in the array is {0}", arrayItem);

			}
				
			//Create a variable to hold the sum
			int totalSum = 0;

			foreach (int eachBill in myBills) {

				//for each bill we will add it to the total sum
				totalSum = totalSum + eachBill;

				//totalSum =+eachBill;

			
			}

			Console.WriteLine ("The sum of our bills is {0}", totalSum);


		}
	}
}
