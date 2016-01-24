using System;

namespace Giannios_John_Conditionals_Assignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* John G. Giannios Jr.
			 * November 10, 2015
			 * Conditionals Assignment
			 * Online - Section 01
			*/

			//Cashiers cash drawer check at end of day or shift

			//Define and declare variables with an array
			string [] endOfDay = new string[5];

			Console.Write ("Giannios Candy End of Day Cash Procedure\r\nPlease enter your employee name and press enter\r\n");
			endOfDay [0] = Console.ReadLine ();

			//Let's Validate the response
			while (string.IsNullOrWhiteSpace(endOfDay [0])){
				Console.WriteLine ("Your name is required, please enter your name.");
				endOfDay [0] = Console.ReadLine ();
			}

			Console.WriteLine ("\r\nHello "+endOfDay [0]+", let's close out your cash drawer.\r\n\r\n");

			//Enter info for closing out employee cash drawer
			//Let's also validate the responses
			Console.WriteLine ("What is your starting cash amount?");
			endOfDay [1] = Console.ReadLine ();
			while (string.IsNullOrWhiteSpace(endOfDay [1])){
				Console.WriteLine ("Ooops, Let's try that again \r\nWhat is your starting cash amount?");
				endOfDay [1] = Console.ReadLine ();
			}

			Console.WriteLine ("What is the current cash count");
			endOfDay [2] = Console.ReadLine ();
			while (string.IsNullOrWhiteSpace (endOfDay [2])){
				Console.WriteLine ("I think you forgot something it's okay\r\nWhat is the amount of the counted drawer.");
				endOfDay [2] = Console.ReadLine ();
			}
			Console.WriteLine ("What is the total in credit card sales?\r\nEnter 0 if you had not credit card sales.");
			endOfDay [3] = Console.ReadLine ();
			while (string.IsNullOrWhiteSpace (endOfDay [3])){
				Console.WriteLine ("Oh sorry to ask you again but,\r\nWhat is the total in credit card sales?\r\nEnter 0 if you had not credit card sales.");
				endOfDay [3] = Console.ReadLine ();
			}
			Console.WriteLine ("What is the total in check sales?\r\nEnter 0 if you had no check sales.");
			endOfDay [4] = Console.ReadLine ();
			while (string.IsNullOrWhiteSpace (endOfDay [4])) {
				Console.WriteLine ("Almost There\r\nWhat is the total in check sales?\r\nEnter 0 if you had no check sales.");
				endOfDay [4] = Console.ReadLine ();
			}

			//Parse the numbers
			decimal cashStart = decimal.Parse (endOfDay [1]);
			decimal cashEnd = decimal.Parse (endOfDay [2]);
			decimal creditCardSales = decimal.Parse (endOfDay [3]);
			decimal checkSales = decimal.Parse (endOfDay [4]);

			//Calculate the amount for deposit
			//Calculate the ammout if drawer is short
			decimal cashDeposit = cashEnd - cashStart;
			decimal cashShort = cashStart - cashEnd;
			decimal nonCashAmount = creditCardSales + checkSales;
			decimal totalAmountSales = creditCardSales + checkSales + cashDeposit;



			//Determine the amount to deposit
			//Display the current deposit
			//We are also going to show if our drawer is short cash amount
			if (cashEnd > cashStart) {
				Console.WriteLine ("Your cash deposit should be $" + cashDeposit+"\r\n");
				 
			} else if (cashEnd < cashStart && cashShort >5) {
				Console.WriteLine ("Your drawer is short $"+cashShort+", get manager right away.\r\n");
				//This shows when we have cash shortage more than $5.00 and tells the employee to get a manager right away
			} else if (cashEnd == cashStart) {
				Console.WriteLine ("No deposit, no Cash Sales today!\r\n");
				//this shows when we no cash sales but will also show when we have credit card and/or checks sales

			} else {
				Console.WriteLine ("Your drawer is short $"+cashShort+", amount short is $5.00 or under, so your okay.\r\n");
				//This shows when we are only short 5.00 or less and letting the employee company policy says its okay
			}



			//Lets determine it there where credit card and check sales or just cash sales
			if (nonCashAmount > 0 && cashDeposit > 0) {
				Console.WriteLine ("Total Cash Sales is $" + cashDeposit + "\r\nTotal Credit Card Sales is $" + creditCardSales + "\r\nTotal Check Sales is $" + checkSales + "\r\nTodays Sales total is $" + totalAmountSales);
				//This runs if we have a positive amount for our deposit

			} else if (cashDeposit < 0) {
				Console.WriteLine ("BETTER DOUBLE CHECK YOUR CASH AMOUNT!\r\nTotal Credit Card Sales is $" + creditCardSales + "\r\nTotal Check Sales is $" + checkSales + "\r\nTodays Sales Total is $" + nonCashAmount);
				//This runs if we have a negitive amount for our deposit

			} else if (cashDeposit == 0 && nonCashAmount == 0) {
				Console.WriteLine ("---- NO SALES TODAY -----");
				//This runs if we have NO SALES FOR THE DAY

			} else if (cashDeposit == 0 && nonCashAmount > 0) {
				Console.WriteLine ("---- NO CASH SALES ---- \r\n\r\nTotal Credit Card Sales is $" + creditCardSales + "\r\nTotal Check Sales is $" + checkSales + "\r\nTodays Total Sales is $" + totalAmountSales);
				//This runs if we only have NO CASH SALES
			
			} else
				Console.WriteLine ("----CASH SALES ONLY ----\r\n\r\nTotal Cash Sales is $"+cashDeposit);
				//This runs if we have CASH SALES ONLY

/*----- Testing ---- Testing -----
 * 
 * 
 * Test 1
 * I tested all the math with my calculater and they are correct
 * 
Giannios Candy End of Day Cash Procedure
Please enter your employee name and press enter
John

Hello John, let's close out your cash drawer.


What is your starting cash amount?
150
What is the current cash count
350
What is the total in credit card sales?
Enter 0 if you had not credit card sales.
100
What is the total in check sales?
Enter 0 if you had no check sales.
0
Your cash deposit should be $200

Total Cash Sales is $200
Total Credit Card Sales is $100
Total Check Sales is $0
Todays Sales total is $300



* Test 2
* I tested all the math with my calculater and they are correct
* I tested the prompt validation and it works great with a "while" statement
* 
* Giannios Candy End of Day Cash Procedure
Please enter your employee name and press enter
    
Your name is required, please enter your name.
John

Hello John, let's close out your cash drawer.


What is your starting cash amount?

Ooops, Let's try that again 
What is your starting cash amount?
150
What is the current cash count

I think you forgot something it's okay
What is the amount of the counted drawer.
350
What is the total in credit card sales?
Enter 0 if you had not credit card sales.
1
What is the total in check sales?
Enter 0 if you had no check sales.

Almost There
What is the total in check sales?
Enter 0 if you had no check sales.
1
Your cash deposit should be $200

Total Cash Sales is $200
Total Credit Card Sales is $1
Total Check Sales is $1
Todays Sales total is $202



* Test 3
* I tested all the math with my calculater and they are correct
* 
Giannios Candy End of Day Cash Procedure
Please enter your employee name and press enter
John

Hello John, let's close out your cash drawer.


What is your starting cash amount?
150
What is the current cash count
145
What is the total in credit card sales?
Enter 0 if you had not credit card sales.
200
What is the total in check sales?
Enter 0 if you had no check sales.
100
Your drawer is short $5, amount short is $5.00 or under, so your okay.

BETTER DOUBLE CHECK YOUR CASH AMOUNT!
Total Credit Card Sales is $200
Total Check Sales is $100
Todays Sales Total is $300





* Test 4
* I tested all the math with my calculater and they are correct
* 
* Giannios Candy End of Day Cash Procedure
Please enter your employee name and press enter
John

Hello John, let's close out your cash drawer.


What is your starting cash amount?
150
What is the current cash count
140
What is the total in credit card sales?
Enter 0 if you had not credit card sales.
1200
What is the total in check sales?
Enter 0 if you had no check sales.
300
Your drawer is short $10, get manager right away.

BETTER DOUBLE CHECK YOUR CASH AMOUNT!
Total Credit Card Sales is $1200
Total Check Sales is $300
Todays Sales Total is $1500



*Test 5
*I tested all the math with my calculater and they are correct
*
Giannios Candy End of Day Cash Procedure
Please enter your employee name and press enter
John

Hello John, let's close out your cash drawer.


What is your starting cash amount?
150
What is the current cash count
5000
What is the total in credit card sales?
Enter 0 if you had not credit card sales.
0
What is the total in check sales?
Enter 0 if you had no check sales.
0
Your cash deposit should be $4850

---- CASH SALES ONLY ---- 

Total Cash Sales is $4850
*
*
*
*
*Test 6
*I tested all the math with my calculater and they are correct
*
*Giannios Candy End of Day Cash Procedure
Please enter your employee name and press enter
John

Hello John, let's close out your cash drawer.


What is your starting cash amount?
150
What is the current cash count
150
What is the total in credit card sales?
Enter 0 if you had not credit card sales.
0
What is the total in check sales?
Enter 0 if you had no check sales.
0
No deposit, no Cash Sales today!

---- NO SALES TODAY -----

*
*
*
*Test 7
*I tested all the math with my calculater and they are correct
*
*Giannios Candy End of Day Cash Procedure
Please enter your employee name and press enter
John

Hello John, let's close out your cash drawer.


What is your starting cash amount?
0
What is the current cash count
0
What is the total in credit card sales?
Enter 0 if you had not credit card sales.
0
What is the total in check sales?
Enter 0 if you had no check sales.
0
No deposit, no Cash Sales today!

---- NO SALES TODAY -----
*
*
*
*Test 8
*I tested all the math with my calculater and they are correct
*
*
*Giannios Candy End of Day Cash Procedure
Please enter your employee name and press enter
John

Hello John, let's close out your cash drawer.


What is your starting cash amount?
150
What is the current cash count
150
What is the total in credit card sales?
Enter 0 if you had not credit card sales.
200
What is the total in check sales?
Enter 0 if you had no check sales.
100
No deposit, no Cash Sales today!

---- NO CASH SALES ---- 

Total Credit Card Sales is $200
Total Check Sales is $100
Todays Total Sales is $300





*/


		}
	}
}
