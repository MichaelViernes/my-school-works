// Author: Viernes, Michael
// Date: 9:54 PM Tuesday, June 21, 2022
// Objective: Create a sequence of alternating positive and negative.

using System;

class AlternatingIntegerSequence
{
	public static void Main(string[] args)
	{
		int? altInt = 0;
		Console.WriteLine("ALTERNATING SIGN OF CONSECUITVE INTEGER SEQUENCE\n");
		while(true)
		{
			if(altInt%2 == 0)
			{
				altInt *= -1;
				altInt += 1;
			} else 
			{
				altInt += 1;
				altInt *= -1;
			}
			
			Console.WriteLine(altInt);
			ConsoleKeyInfo readexit = Console.ReadKey();
		}
	}
}