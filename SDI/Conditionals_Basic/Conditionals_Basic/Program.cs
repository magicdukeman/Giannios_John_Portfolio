using System;

namespace Conditionals_Basic
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Boolean variable
			//only contain a value of true or false

			// true is not a text string of "true"
			bool testing1 = true;

			bool wontRun = false;

			Console.WriteLine (testing1);
			Console.WriteLine (wontRun);

			//Relational Operators
			Console.WriteLine(5<7);

			Console.WriteLine (7>5);

			Console.WriteLine (2>5);

			Console.WriteLine (5<=5);
			Console.WriteLine (6<6);

			Console.WriteLine (4 == 4);

			Console.WriteLine (4 != 3);
			Console.WriteLine (4!=4);

			//IF statement
			//Else statement

			//Delare and define a variable

			int kidAge = 11;


			if (kidAge>=13) {

				Console.WriteLine ("The child can go to the pg 13 movie");

			} else if(kidAge>=10) {
				
				Console.Write("The can go to see the pg moive");

			} else {

				Console.WriteLine("The child can only see a G rated movi");

			}




			//We work in a shoe store.
			//We get a bonus if we sell 50 or more pairs of shoes in a day

			//Declare and define starting variables
			decimal basePay =  200.00m;

			decimal bonus = 50.00m;

			//What is our total pay?
			decimal totalPay = 0.00m;



			int shoesPerDay = 35;


			//Create a conditional to tst if we get our bonus?

			if(shoesPerDay>=50){

				//We get our bonus
				//Tototal pay should be base pay pluse bones pay
				totalPay = basePay + bonus;


			} else {

				//We do not get a bonus

				//total pay is just base pay
				totalPay = basePay;
			}


		//Report to users there total pay
		Console.WriteLine("Your total pay is $"+totalPay);

		}
	}
}
