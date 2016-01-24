using System;

namespace TotalProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			 * John G. Giannios Jr.
			 * 11-16-2015
			 * Total Project
			 * Section 01
			*/

			//Calculate the area and perimter of a rectangle from user prompts

			//Tell the user what we are doing and then aske for width
			Console.WriteLine ("Hello! We ar going to find the area and perimeter rectangle.\r\nPlease type in a value for the width and hit enter.");

			//Capture the users response
			string widthString = Console.ReadLine ();

			//Declare a variable to hold the convered value
			double width;

			//Validate the users is typing in a valid number
			while(!double.TryParse(widthString, out width)){

				//alert the user to the error
				Console.WriteLine("Please only type in numbers and do not leave blank\r\nWhat is the width fo the rectangle?");
				//recapture the users response int the same varaible
				widthString = Console.ReadLine();
				
			}


			//Tell the users the width and say thanks and ask for the length
			Console.Write ("Got it! You enter the width of "+ width+ " What is the lenght?");

			//Create a variable to cature the users response
			string lengthString = Console.ReadLine();

			//Declare the variable to hold converted value
			double length;

			//Validate using a while loop
			while(!double.TryParse(lengthString, out length)){

				//alert the user to the error
				Console.WriteLine ("Please only type in numbers and do not leave blank\r\nWhat is the legnth fo the rectangle?");
				//recapture the users response int the same varaible
				lengthString = Console.ReadLine();
			}

			//tell the user we got the legnth and tell them the next step
			Console.WriteLine ("Thank you! You entered a width {0} and a length of {1}. \r\nWe are now going to calculate the perimeter.",width, length);

			//Go create a function to calculate the perimeter
			//REMEMBER to cathc the returned value with a variable and use arguments!
			double perimeter = CalcPeri(width, length);

			//Report to the user
			Console.WriteLine ("The perimeter of the triangle is "+perimeter);

			//Create a function to calculate the area
			///Function call it and stor the returned value
			double area = CalcArea(width, length);

			//report to the user
			Console.WriteLine ("The area of the rectangle is {0}", area);


			//Tell the user we want to find the volume and ask for hight
			Console.WriteLine ("Let's find the volume if the rectangle was actually rectangler prism\r\nWhat is the height?\r\n");

			//Create a variable to hold Height
			string heightString = Console.ReadLine();

			//Declare the height veriable
			double height;

			//Validate the user response
			while(!double.TryParse(heightString, out height)){

				//alert the user to the error
				Console.WriteLine ("Please only type in numbers and do not leave blank\r\nWhat is the height oh the rectangler prism?");
				//recapture the users response int the same varaible
				heightString = Console.ReadLine();
			}
			//report to the user
			Console.WriteLine ("You typed in a height of "+height+". We will now find the volume.");

			//Create another function
			//Function call it and store the returned value
			double volume = CalcVolume(width, length, height);

			//Report to the user
			Console.WriteLine ("The volume of the rectangular prism is {0}", volume);
		}



		public static double CalcPeri(double wid, double len){

			//Create a variable for perimeter and do the math
			double peri = 2*wid + 2*len;

			//return the perimeter value
			return peri;
		}

		public static double CalcArea(double w, double l){

			//Do the math
			double area = w* l;

			//return to the main methon
			return area;
		}

		public static double CalcVolume(double w, double l, double h){

			//Calculate the volume
			double volume = w*l*h;

			//return the volume
			return volume;
		}
	}
}		
