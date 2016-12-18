// C# Mikes user input through two dimensional array, using nested for loops. 

using System;

namespace NestedArraysInput2016
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello Mike.\n\n");
			
			int[,] numbers = new int[3,3];
			
			for (int x= 0; x<3; x++) 
			{
				//ask for user input:
				Console.WriteLine("Enter 9 numbers:");
				
				for (int y=0; y<3; y++) 
				{
				//store in array:
				numbers[x,y]= int.Parse(Console.ReadLine());
				}	
			}
			
			for (int x= 0; x<3; x++) 
			{
				for (int y=0; y<3; y++) 
				{
					Console.Write(numbers[x,y] + " ");
				}
				Console.WriteLine(" ");
			}
			//pause.
			Console.ReadKey(true);
			
			//print one number.
			Console.Write("\nPrint down zero and across one: ");
			Console.Write(numbers[0,1]);
			
			//print one number.
			Console.Write("\nPrint down one and across one: ");
			Console.Write(numbers[1,1]);
			
			//print one number.
			Console.Write("\nPrint down two and across one: ");
			Console.Write(numbers[2,1]);
			
			//pause to view and exit:
			Console.Write("\n*Exit Mike.*");
			Console.ReadKey(true);
		}
	}
}
