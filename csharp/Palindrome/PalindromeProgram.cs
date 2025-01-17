// objective:	create a palindrome
// date:		2022-06-17 21:58:53
// topic: 		oop

using System;

namespace Palindrome
{
	class PalindromeProgram
	{
		public static void Main(string[] args)
		{
			while(true)
			{
				string word, revword;
				Console.WriteLine("PALINDROME VALIDATOR\nEnter a word: ");
				word = Console.ReadLine();
				char[] wordarray = word.ToCharArray();
				Array.Reverse(wordarray);
				revword = new string(wordarray);
				bool isPalindrome = word.Equals(revword);
				
				if (isPalindrome == true)
				{
					Console.WriteLine("This is a Palindrome.");
				} else
				{
					Console.WriteLine("This is not a Palindrome.");
				}
				Console.Write("Press \"q\" to quit: ");
				string quit = (Console.ReadLine());
				if (quit == "q")
				{
					break;
				}
			}
		}
	}
}
