using System;

namespace VariableConversions
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Implict Converstions
			//smaller datatype to a larger one

			short num = 23456;
			Console.WriteLine (num);

			//implictly convert
			int bignum = num;
			Console.WriteLine (bignum);

			//Exlicit Converstions
			//Be careful and watch for data loss!!

			double x = 1234.56;
			Console.WriteLine (x);

			int xConverted = (int)x;
			Console.WriteLine (xConverted);

			//Convert a large number to a sbyte
			int z = 130;
			sbyte zConverted = (sbyte)z;
			Console.WriteLine (z);
			Console.WriteLine (zConverted);

			//Helper Classes
			//Convert class - parse method

			//Convert class

			string stringValue = "56";

			//This does not work
			//Try to multiple times 2
			//int multipled = stringValue*2;

			//Conver strin to number then multiple
			int multipled = Convert.ToInt32(stringValue);
			multipled = multipled * 2;
			multipled *= 2;

			Console.WriteLine (multipled);

			//parse
			//Converts a string verstion into a different datatype

			//Create a string varaible

			string salaray = "150000";

			//Parse the string and pull out an interger

			int salarayInt = int.Parse (salaray);

			//Divide salary by 4
			salarayInt = salarayInt/4;

			Console.WriteLine (salarayInt);



		}
	}
}
