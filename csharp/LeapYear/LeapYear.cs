// author: viernes, michael
// date: 10:32 am sunday, june 26, 2022
// objective: check if leap year
using System;
namespace LeapYear
{
    class LeapYear
    {
        public static void Main(string[] args)
        {
            Console.Write("Is leap year: ");
			var year = int.Parse(Console.ReadLine());
			if(0 == year%4)
			{
				Console.WriteLine("This is a leap year.");
			} else
			{
				Console.WriteLine("This is not a leap year.");
			}
        }
    }
}
