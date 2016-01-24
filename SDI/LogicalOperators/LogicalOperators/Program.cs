using System;

namespace LogicalOperators
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Logical Operators

			//And Operator &&


			//can we buy an iphone?

			decimal budget = 600.00m;
			decimal iphoneCost = 500.00m;

			decimal paycheck = 500.00m;

			//We can buy the phone if the phone is less than budget and paycheck is greater ;thatn700 to cover bills

			if (iphoneCost < budget && paycheck > 700) {
				//We can buy the phone
				Console.Write ("You can buy the iPhone!");


			} else {
				Console.WriteLine ("Sorry you can not buy the phone.");
			
			}

			//|| or operator
			//We can buy the phone if the phone is less than budget and paycheck is greater ;thatn700 to cover bills

			if (iphoneCost < budget || paycheck > 700) {
				//We can buy the phone
				Console.Write ("You can buy the iPhone as an OR case!");


			} else {
				Console.WriteLine ("Sorry you can not buy the phone in as an OR case.");

			}

			//Not operator !

			if (!(iphoneCost < budget)) {
				Console.WriteLine ("From the not operator you can buy the phone");


			} else
				Console.WriteLine ("From the not operator you cannot by the phone.");
		
		
		}
	}
}
