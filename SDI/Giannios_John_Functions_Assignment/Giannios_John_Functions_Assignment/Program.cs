using System;

namespace Giannios_John_Functions_Assignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			 * John G. Giannios Jr.
			 * 11-16-2015
			 * Functions Assignmnet
			 * Section 01
			*/

			//Lets calculate the markup on wholesale and retail price and tell the user what the final price should be

			//Let's create our arrays to capture our values
			//I love using arrays
			decimal [] money = new decimal[8];
			string [] moneyString = new string[8];
			string [] text = new string[1];

			//Lets introduce the user and ask the user their name
			Console.WriteLine("Lets count out your drawer,\r\nplease enter your name and hit enter.");

			//Lets capture the user response
			text [0] = Console.ReadLine ();

			//Lets validate the user response for the user name
			while (string.IsNullOrWhiteSpace (text [0])){
				Console.WriteLine ("I'm sorry what is your name?");
				text [0] = Console.ReadLine ();
			}
			//Lets count some money - How many ten dollar bills
			Console.WriteLine("\r\n{0} let's count up your drawer.\r\nTotal of $10's", text[0]);

			//Lets capture the user response
			moneyString [0] = Console.ReadLine();

			//Lets validate the user response
			while (!decimal.TryParse(moneyString[0], out money [0])){
				//Alert the user the problem
				Console.WriteLine("Ooops, total in $10's");
				//Lets recapture the user response
				moneyString [0] = Console.ReadLine();
			}

			//Lets count some money - How many five dollar bills
			Console.WriteLine("Total of $5's");

			//Lets capture the user response
			moneyString [1] = Console.ReadLine();

			//Lets validate the user response
			while (!decimal.TryParse(moneyString[1], out money [1])){
				//Alert the user the problem
				Console.WriteLine("Ooops, total in $5's");
				//Lets recapture the user response
				moneyString [1] = Console.ReadLine();
			}

			//Lets count some money - How many one dollar bills
			Console.WriteLine("Total of $1's");

			//Lets capture the user response
			moneyString [2] = Console.ReadLine();

			//Lets validate the user response
			while (!decimal.TryParse(moneyString[2], out money [2])){
				//Alert the user the problem
				Console.WriteLine("Ooops, total in $1's");
				//Lets recapture the user response
				moneyString [2] = Console.ReadLine();
			}

			//Lets count some money - How many Quarters
			Console.WriteLine("Total of $0.25's");

			//Lets capture the user response
			moneyString [3] = Console.ReadLine();

			//Lets validate the user response
			while (!decimal.TryParse(moneyString[3], out money [3])){
				//Alert the user the problem
				Console.WriteLine("Ooops, total in $0.25's");
				//Lets recapture the user response
				moneyString [3] = Console.ReadLine();
			}

			//Lets count some money - How many Dimes
			Console.WriteLine("Total of $0.10's");

			//Lets capture the user response
			moneyString [4] = Console.ReadLine();

			//Lets validate the user response
			while (!decimal.TryParse(moneyString[4], out money [4])){
				//Alert the user the problem
				Console.WriteLine("Ooops, total in $0.10's");
				//Lets recapture the user response
				moneyString [4] = Console.ReadLine();
			}

			//Lets count some money - How many Nickels
			Console.WriteLine("Total of $0.05's");

			//Lets capture the user response
			moneyString [5] = Console.ReadLine();

			//Lets validate the user response
			while (!decimal.TryParse(moneyString[5], out money [5])){
				//Alert the user the problem
				Console.WriteLine("Ooops, total in $0.05's");
				//Lets recapture the user response
				moneyString [5] = Console.ReadLine();
			}

			//Lets count some money - How many Pennys
			Console.WriteLine("Total of $0.01's");

			//Lets capture the user response
			moneyString [6] = Console.ReadLine();

			//Lets validate the user response
			while (!decimal.TryParse(moneyString[6], out money [6])){
				//Alert the user the problem
				Console.WriteLine("Ooops, total in $0.01's");
				//Lets recapture the user response
				moneyString [6] = Console.ReadLine();
			}

			//Lets create a function to add all of the bills
			//Lets call the function totalBills
			//Lets catch the return totalOfBills
			decimal billsTotal = TotalBills(money[0],money[1], money[2]);

			//Lets create a function to add all of the coins
			//Lets call a function TotalCoins
			//Lets catch the return totalOfCoins
			decimal coinsTotal = TotalCoins(money [3], money [4], money [5], money [6]);

			//Lets count up some checks
			Console.WriteLine("Total amount of checks?");

			//Lets capture the user input
			moneyString [7] = Console.ReadLine();

			//Lets validate the user response
			while (!decimal.TryParse(moneyString[7], out money[7])){
				//alert the user the problem
				Console.WriteLine ("Ooops, total amount of the checks");
				//lets recapture the user response
				moneyString [7] = Console.ReadLine();
			}

			/*
			 * Test area *
			
			Console.WriteLine (money [1]*2);
			Console.WriteLine (money [2]*2);
			Console.WriteLine (money [3]*2);
			Console.WriteLine (money [4]*2);
			Console.WriteLine (money [5]*2);
			Console.WriteLine (money [6]*2);
			Console.WriteLine (money [7]*2);

			*/

			//Lets add up all the cash
			decimal totalCash = billsTotal + coinsTotal;

			//Lets show the results to the user
			Console.WriteLine ("Your total amount bills ${0}\r\nYour total amount coins ${1}\r\nYour total amount in cash ${2}\r\n\r\nYour total amount in checks ${3}",billsTotal, coinsTotal, totalCash, money[7]);

			

		}

		public static decimal TotalBills(decimal tenBill, decimal fiveBill, decimal oneBill){

			//Create a variable to catch the return
			decimal totalOfBills = tenBill + fiveBill + oneBill;

			//Return the value
			return totalOfBills;

		}

		public static decimal TotalCoins(decimal quarterCoin, decimal dimeCoin, decimal nickelCoin, decimal pennyCoin){

			//Create a variable to catch the return
			decimal totalOfCoins = quarterCoin + dimeCoin + nickelCoin + pennyCoin;

			//Return the value
			return totalOfCoins;

/*
* ------ Testing ------
* 
* ------ Test 1 -------
Lets count out your drawer,
please enter your name and hit enter.
John

John let's count up your drawer.
Total of $10's
10
Total of $5's
10
Total of $1's
10
Total of $0.25's
2
Total of $0.10's
2
Total of $0.05's
2
Total of $0.01's
2
Total amount of checks?
200
Your total amount bills $30
Your total amount coins $8
Your total amount in cash $38

Your total amount in checks $200
---- The amounts was check with calculater and are correct.



* ------ Testing ------
* 
* ------ Test 2 -------
Lets count out your drawer,
please enter your name and hit enter.

I'm sorry what is your name?
John

John let's count up your drawer.
Total of $10's

Ooops, total in $10's
cat
Ooops, total in $10's
10
Total of $5's
bat
Ooops, total in $5's
10
Total of $1's
sit
Ooops, total in $1's
10
Total of $0.25's
2
Total of $0.10's
hi
Ooops, total in $0.10's
2
Total of $0.05's

Ooops, total in $0.05's
2
Total of $0.01's
2
Total amount of checks?
rat
Ooops, total amount of the checks
200
Your total amount bills $30
Your total amount coins $8
Your total amount in cash $38

Your total amount in checks $200
The calculations where check with calculater and are correct


* ------ Testing ------
* 
* ------ Test 3 -------
Lets count out your drawer,
please enter your name and hit enter.
John G. Giannios Jr.

John G. Giannios Jr. let's count up your drawer.
Total of $10's
45.00
Total of $5's
25.00
Total of $1's
34.00
Total of $0.25's
4.75
Total of $0.10's
3.20
Total of $0.05's
2.15
Total of $0.01's
.45
Total amount of checks?
34.75
Your total amount bills $104.00
Your total amount coins $10.55
Your total amount in cash $114.55

Your total amount in checks $34.75
The calculationa where check with a calculater and are correct

*/
		}
				
		
		

	}
}
