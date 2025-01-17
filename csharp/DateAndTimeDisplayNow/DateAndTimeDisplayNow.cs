// Author: Viernes, Michael
// Date: 8:53 PM Tuesday, June 21, 2022
// Objective: 
// (1) Write a program that prints on the console the current date and time.
// (2) Gets the deadline differences.
// (3) Asks user input for setting dates and convert formatting.



using System;

class DateAndTimeDisplayNow
{
	public static void Main(string[] args)
	{
		// declaration of vars
		DateTime currentDate, deadline;
		TimeSpan submissionDate;
		
		Console.WriteLine("DISPLAYING DATE AND TIME IN VARIOUS FORMATS\n");
		
		// basic datetime property declaration of today's date and time 
		currentDate = DateTime.Today;
		Console.WriteLine("First Version of Date and Time: {0, -50}", currentDate);
		currentDate = DateTime.Now;
		Console.WriteLine("Second Version of Date and Time: {0, -50}", currentDate.ToString());
		currentDate = DateTime.UtcNow;
		Console.WriteLine("Third Version of Date and Time: {0, -50}", currentDate.ToString());
		
		// [project] deadline countdown
		Console.WriteLine("\nDEADLINE OF A [PROJECT]");
		submissionDate = new TimeSpan(6, 20, 0, 0);
		deadline = currentDate.Add(submissionDate);
		Console.WriteLine("Today is {0} and the deadline of the project is {1, -50}.", currentDate, deadline);
		Console.WriteLine("Days: {0} Hours: {1} Minutes: {2}", submissionDate.Days, submissionDate.Hours, submissionDate.Minutes);
		
		
		// set a date and time
		Console.Write("Set a date and time (year, month, day): ");
		DateTime userTimeAndDate = DateTime.Parse(Console.ReadLine());
		Console.WriteLine("The new date and time is {0}.", userTimeAndDate);
	}
}